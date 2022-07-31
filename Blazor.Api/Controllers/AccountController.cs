using Blazor.Api.Helper;
using DataLayer.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser>_signInManager;
        private readonly ApiSettings apiSettings;

        public AccountController(UserManager<IdentityUser> userManager , SignInManager<IdentityUser> signInManager ,IOptions< ApiSettings> apiSettings )
        {
            
            this.userManager = userManager;
            this._signInManager = signInManager;
            this.apiSettings = apiSettings.Value;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp([FromBody] UserRequestDTO user)
        {
            var user1 = new IdentityUser()
            {
                 Email = user.Email,
                 
                 UserName = user.Email,
                 EmailConfirmed = true,
                 PhoneNumber = user.PhoneNo
                  
            };
            var res = await userManager.CreateAsync(user1, user.Password);
            if (!res.Succeeded)
            {
                var errors = res.Errors.Select(r => r.Description);
                return BadRequest(
                    new RegResponseDTO()
                    {
                         Errors =errors,
                         IsRegestedSuccesfully = false
                    }
                    );

            }
           
            return StatusCode(201);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SingIn([FromBody] AuthenticationDTO user)
        {

            var res = await _signInManager.PasswordSignInAsync(user.UserName,user.Password,false , false);
            if (res.Succeeded)
            {
                var user1 = await userManager.FindByNameAsync(user.UserName);
                if (user1==null)
                {
                    return Unauthorized(
                                      new AuthResponseDTO()
                                      {

                                          IsRegestedSuccesfully = false,
                                          Errors ="Invalid"
                                      }
                                      ) ;
                }
                // login 
                var signInCreadential = signingCredentials();
                var claims =await GetClaims(user1);
                var tokenOptions = new JwtSecurityToken(
                    issuer:apiSettings.ValidIssuer , 
                    claims:claims , 
                    audience:apiSettings.ValidAudience,
                    expires:DateTime.Now.AddDays(30),
                    signingCredentials: signInCreadential
                    );

                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                return Ok(new AuthResponseDTO
                {
                    Token=token, 
                    Errors="",
                    IsRegestedSuccesfully = true, 
                    UserDTO = new UserDTO
                    {
                         Email = user1.Email , 
                          Name = user1.UserName
                    }
                });

              

            }
            else
            {
                return Unauthorized(new AuthResponseDTO { Errors = "ivalid" 
                 , IsRegestedSuccesfully=false, 
                    
                });
            }

        }


        private  SigningCredentials signingCredentials()
        {
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(apiSettings.SecretKey));
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private async Task<List<Claim>> GetClaims(IdentityUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name , user.UserName),
                new Claim(ClaimTypes.Email , user.Email),
                new Claim("Id" , user.Id)

            };
            var roles = await userManager.GetRolesAsync(await userManager.FindByEmailAsync(user.Email));
            foreach (var role in roles)
            {
                claims.Add(
                new Claim(ClaimTypes.Role, role)
                );

            }

            return claims;
            
        }

    }
}

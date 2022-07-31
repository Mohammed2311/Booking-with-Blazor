using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Client.Services.IServices
{
    public interface IAuthenticationService
    {
        public Task<AuthResponseDTO> LogIn(AuthenticationDTO userAuth);
        public Task<RegResponseDTO> Register(UserRequestDTO userRequest);
        public Task LogOut();
        
    }
}

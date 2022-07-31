using Blazor_Client.Services.IServices;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Blazor_Client.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient client;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authState;

        public AuthenticationService(HttpClient client ,ILocalStorageService localStorage, AuthenticationStateProvider authState)
        {
            this.client = client;
            this.authState = authState;
            this.localStorage = localStorage;
        }
        public async Task<AuthResponseDTO> LogIn(AuthenticationDTO userAuth)
        {
            var content = JsonConvert.SerializeObject(userAuth);
            var bodyContent = new StringContent(content,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("/api/account/SingIn" , bodyContent);
            var resContent = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AuthResponseDTO>(resContent);
            if (response.IsSuccessStatusCode)
            {
                await localStorage.SetItemAsync("token" , result.Token);
                await localStorage.SetItemAsync("UserDetails", result.UserDTO);
                ((AuthStateService)authState).NotifyUserLoggedIn(result.Token);
                return new AuthResponseDTO { IsRegestedSuccesfully = true };
            }
            else
            {
                return result;
            }

        }

        public async Task LogOut()
        {
            await localStorage.RemoveItemAsync("token");
            await localStorage.RemoveItemAsync("UserDetails");
            ((AuthStateService)authState).NotifyUserLoggedOut();


        }

        public async Task<RegResponseDTO> Register(UserRequestDTO userRequest)
        {
           
            var content = JsonConvert.SerializeObject(userRequest);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/account/signup", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<RegResponseDTO>(contentTemp);

            if (response.IsSuccessStatusCode)
            {

                return new RegResponseDTO { IsRegestedSuccesfully = true };
            }
            else
            {
                return result;
            }
        }
    }
}

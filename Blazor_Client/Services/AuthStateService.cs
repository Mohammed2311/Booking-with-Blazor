using Blazor_Client.Helper;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blazor_Client.Services
{
    public class AuthStateService : AuthenticationStateProvider
    {
        private readonly HttpClient client;
        private readonly ILocalStorageService localStorage;

        public AuthStateService(HttpClient client , ILocalStorageService localStorage)
        {
            this.client = client;
            this.localStorage = localStorage;
        }
        public void NotifyUserLoggedIn(string token)
        {
            var authUser = new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "jwtAuthType" ));
            var authState = Task.FromResult(new AuthenticationState(authUser));
            NotifyAuthenticationStateChanged(authState);
        }
        public void NotifyUserLoggedOut()
        {
            
            var authState = Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
            NotifyAuthenticationStateChanged(authState);
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await localStorage.GetItemAsync<string>("token");

            if (token==null)
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer",token);

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token) ,"jwtAuthType" )));
          
        }
    }
}

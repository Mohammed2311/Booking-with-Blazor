using Blazor_Client.Services.IServices;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Blazor_Client.Pages.Authentication
{
    public partial class LogIn
    {
        private AuthenticationDTO UserForAuthentication = new AuthenticationDTO();
        public bool IsProcessing { get; set; } = false;
        public bool ShowAuthenticationErrors { get; set; }
        public string Errors { get; set; }
        public string ReturnUrl { get; set; }
        [Inject]
        public IAuthenticationService authenticationService { get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }
        
        private async Task LoginUser()
        {
            try
            {
                ShowAuthenticationErrors = false;
                IsProcessing = true;
                

                var result = await authenticationService.LogIn(UserForAuthentication);

                if (result.IsRegestedSuccesfully)
                {
                    IsProcessing = false;
                    var url = new Uri(navigationManager.BaseUri);
                    var queryParams = HttpUtility.ParseQueryString(url.Query);
                    ReturnUrl = queryParams["returnUrl"];
                    if (string.IsNullOrEmpty(ReturnUrl))
                    {
                        navigationManager.NavigateTo("/");
                    }
                    else
                    {
                        
                        navigationManager.NavigateTo($"/{ReturnUrl}");
                    }
                }
                else
                {
                    IsProcessing = false;
                    Errors = result.Errors;
                    ShowAuthenticationErrors = true;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

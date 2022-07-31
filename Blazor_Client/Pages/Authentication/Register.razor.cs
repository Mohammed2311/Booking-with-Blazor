using Blazor_Client.Services.IServices;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Client.Pages.Authentication
{
    public partial class Register
    {
        private UserRequestDTO UserForRegisteration = new UserRequestDTO()        ;
        public bool IsProcessing { get; set; } = false;
        public bool ShowRegistrationErrors { get; set; }
        public IEnumerable<string> Errors { get; set; }
        [Inject]
        public IJSRuntime jSRuntime { get; set; }
        [Inject]
        public IAuthenticationService authenticationService { get; set; }
        [Inject]
        public IJSRuntime jsRunTime { set; get; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        private async Task RegisterUser()
        {
            try
            {

                ShowRegistrationErrors = false;
                IsProcessing = true;
                var result = await authenticationService.Register(UserForRegisteration);
                if (result.IsRegestedSuccesfully)
                {
                    IsProcessing = false;
                    navigationManager.NavigateTo("/login");
                }
                else
                {
                    IsProcessing = false;
                    Errors = result.Errors;
                    ShowRegistrationErrors = true;
                }
            }
            catch (Exception ex)
            {
               
                Console.WriteLine(ex.Message);
            }
        }
    }
}
using Blazor_Client.Services.IServices;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Client.Pages.Authentication
{
    public partial class LogOut
    {
        [Inject]
        public IAuthenticationService authService { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await authService.LogOut();
            navigationManager.NavigateTo("/");

        }
    }
}

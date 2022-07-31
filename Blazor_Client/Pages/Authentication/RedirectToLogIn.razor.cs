using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Client.Pages.Authentication
{
    public partial class RedirectToLogIn
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [CascadingParameter]
        private Task<AuthenticationState> authenticationState { get; set; }
        protected  async override Task OnInitializedAsync()
        {
            var returnUrl = navigationManager.ToBaseRelativePath(navigationManager.Uri);
            if (string.IsNullOrEmpty(returnUrl))
            {
                navigationManager.NavigateTo("/" , true);
            }
            else
            {
                navigationManager.NavigateTo($"/login?returnUrl={returnUrl}" , true);
            }

        }
    }
}

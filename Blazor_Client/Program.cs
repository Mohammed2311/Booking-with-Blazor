using Blazor_Client.Services;
using Blazor_Client.Services.IServices;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider ,AuthStateService>();
            builder.Services.AddScoped<IHotelRoomService ,HotelRoomService>();
            builder.Services.AddScoped<IOrderDetailsService, OrderDetailsService>();
            builder.Services.AddScoped<IAuthenticationService,AuthenticationService>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration.GetValue<string>("BaseAPIUrl")) });

            await builder.Build().RunAsync();
        }
    }
}

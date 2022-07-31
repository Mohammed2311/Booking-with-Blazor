using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Helper
{
    public static class JsRunTimeHelp
    {
        public static async Task ToasterSucess(this IJSRuntime JSRuntime, string message)
        {
            
            await JSRuntime.InvokeVoidAsync("moo", "sucess",message);
        }
        public static async Task ToasterError(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("moo", "error", message);
        }
        public static async Task SwalError(this IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("moo1", "error", message);
        }
        public static async Task SwalSucess(this IJSRuntime JSRuntime, string message)
        {

            await JSRuntime.InvokeVoidAsync("moo1", "sucess", message);
        }

    }
}

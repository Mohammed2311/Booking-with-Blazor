#pragma checksum "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c25cc7d8be1f0245e3900fd6f2a1aca16ed053f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages.LearnBlazorComponants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using BlazorServer.Pages.LearnBlazorComponants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using Busniss.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\_Imports.razor"
using BlazorServer.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
using BlazorServer.Data.Model;

#line default
#line hidden
#nullable disable
    public partial class IndiviualRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light p-2 m-2 col-5");
            __builder.OpenElement(2, "h4");
            __builder.AddAttribute(3, "class", "text-secondary");
            __builder.AddContent(4, 
#nullable restore
#line 4 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
                                 Room.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "checkbox");
            __builder.AddAttribute(8, "name", "name");
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
                                                  CallFunction

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 5 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
                                                                   Room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n    <br>\r\n    ");
            __builder.AddContent(13, 
#nullable restore
#line 7 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
     Room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    <br>\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "checkbox");
            __builder.AddAttribute(17, "checked", 
#nullable restore
#line 9 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
                                      Room.IsActive?"checked":null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
                                                                                  Room.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.IsActive = __value, Room.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "&nbsp; Is Active\r\n\r\n\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, " This Room is ");
            __builder.AddContent(23, 
#nullable restore
#line 15 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
                          Room.IsActive?"Active ": "InActive"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
     if (Room.IsActive)
    {
        foreach (var Room1 in Room.RoomProps)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, 
#nullable restore
#line 21 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
                Room1.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, " - ");
            __builder.AddContent(27, 
#nullable restore
#line 21 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
                              Room1.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServer.Pages.LearnBlazorComponants.EditDeleteButton>(28);
            __builder.AddAttribute(29, "IsAdmin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
                               false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazorComponants\IndiviualRoom.razor"
       
    [Parameter]
    public BlazorRoom Room { get; set; }

    [Parameter]
    public EventCallback<bool> MyProperty { get; set; }
    protected async Task CallFunction(ChangeEventArgs e)
        {
        await MyProperty.InvokeAsync((bool)e.Value);
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

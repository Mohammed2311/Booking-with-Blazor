// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServer.Pages.LearnBlazor
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
#line 2 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\Index.razor"
using BlazorServer.Data.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\Index.razor"
      
    string Prop = "";
    List<BlazorRoom> rooms = new List<BlazorRoom>();
    BlazorRoom Room = new BlazorRoom()
    {
        Id = 1,
        RoomName = "villa"
            ,
        Price = 432,
        IsActive = true,
        RoomProps = new List<Model.BlazorRoomProp>()
            {
               new Model.BlazorRoomProp{Id = 1 , Name =  "Sq Ft" , Value = "100"},
               new Model.BlazorRoomProp{Id = 2 , Name =  "asod" , Value = "3"},
            }

    };

    protected override void OnInitialized()
    {
        base.OnInitialized();
        rooms.Add(
            new BlazorRoom()
            {
                Id = 1,
                RoomName = "villa"
            ,
                Price = 432,
                IsActive = true,
                RoomProps = new List<Model.BlazorRoomProp>()
            {
               new Model.BlazorRoomProp{Id = 1 , Name =  "Sq Ft" , Value = "100"},
               new Model.BlazorRoomProp{Id = 2 , Name =  "asod" , Value = "3"},
            }
            }
            );
        rooms.Add(
            new BlazorRoom()
            {
                Id = 2,
                RoomName = "villa2"
            ,
                Price = 1000,
                IsActive = true,
                RoomProps = new List<Model.BlazorRoomProp>()
            {
               new Model.BlazorRoomProp{Id = 1 , Name =  "Sq Ft" , Value = "141"},
               new Model.BlazorRoomProp{Id = 2 , Name =  "asod" , Value = "53"},
            }
            }
            );
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

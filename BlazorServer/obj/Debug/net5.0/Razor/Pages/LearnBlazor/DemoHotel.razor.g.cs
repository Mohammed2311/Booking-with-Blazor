#pragma checksum "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "267d513c56c33db8c778190c57b30854bdcfac26"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
using BlazorServer.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
using BlazorServer.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/demohotel")]
    public partial class DemoHotel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DemoHotel</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "border p-2 mt-2");
            __builder.AddAttribute(3, "style", "background-color:azure ");
            __builder.AddMarkupContent(4, "<h2 class=\"text-info\"> Room List</h2>\r\n    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "room selected - ");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
                        Counter

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", " row container");
#nullable restore
#line 12 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
         foreach (var item in rooms)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServer.Pages.LearnBlazorComponants.IndiviualRoom>(11);
            __builder.AddAttribute(12, "MyProperty", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 14 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
                                        onChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "Room", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorServer.Data.Model.BlazorRoom>(
#nullable restore
#line 14 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
                                                          item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"


        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.AddMarkupContent(15, "<h2 class=\"text-info\">HotelsMohammed</h2>\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", " row container");
#nullable restore
#line 22 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
         foreach (var item in Hotels)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServer.Pages.LearnBlazor.HotelAmnies>(18);
            __builder.AddAttribute(19, "MyProperty", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 24 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
                                     onClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "Hotel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorServer.Model.HotelAmnie>(
#nullable restore
#line 24 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
                                                     item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 25 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"


        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, "the hotel is : ");
            __builder.AddContent(24, 
#nullable restore
#line 29 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
                       Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\ccc\source\repos\BlazorServer\BlazorServer\Pages\LearnBlazor\DemoHotel.razor"
       
    public int Counter { get; set; } = 0;

    public string Name { get; set; }
    List<BlazorRoom> rooms = new List<BlazorRoom>();
    List<HotelAmnie> Hotels = new List<HotelAmnie>();

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Hotels.Add(
          new HotelAmnie()
          {
              Id = 1,
              Name = "Gym"
              ,
              Description = "asfasjodkasjd"
          });
        Hotels.Add(
            new HotelAmnie()
            {
                Id = 4,
                Name = "pool"
                ,
                Description = "Mohammmed"
            });
        Hotels.Add(
            new HotelAmnie()
            {
                Id = 3,
                Name = "pasdjvasiudviool"
                ,
                Description = "Galal"
            }
            );
        rooms.Add(
        new BlazorRoom()
        {
            Id = 1,
            RoomName = "villa"
        ,
            Price = 432,
            IsActive = false,
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
                IsActive = false,
                RoomProps = new List<Model.BlazorRoomProp>()
            {
               new Model.BlazorRoomProp{Id = 1 , Name =  "Sq Ft" , Value = "141"},
               new Model.BlazorRoomProp{Id = 2 , Name =  "asod" , Value = "53"},
                }
            }
            );
    }

    protected void onChange(bool isChanged)
    {
        if (isChanged )
        {
            Counter++;

        }
        else
        {
            Counter--;
        }
    }

    protected void onClick( string hotelName)
        {
        Name = hotelName;
        }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f7201dae27e7c28ee40606aead72e5f948a18d1"
// <auto-generated/>
#pragma warning disable 1591
namespace Project_FrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Project_FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Project_FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using AdminPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\Counter.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\Counter.razor"
     Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\Counter.razor"
                  StartCountdown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Start Timer");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\Counter.razor"
            
    private int Count { get; set; } = 10;

    void StartCountdown()
    {
        var timer = new Timer(new TimerCallback(_ =>
        {
            if (Count > 0)
            {
                Count--;

                // Note that the following line is necessary because otherwise
                // Blazor would not recognize the state change and not refresh the UI
                InvokeAsync(() =>
                {

                    StateHasChanged();
                });
            }
        }), null, 1000, 1000);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

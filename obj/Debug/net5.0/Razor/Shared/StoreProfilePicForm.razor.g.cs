#pragma checksum "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\StoreProfilePicForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2dcc757362d9c015f63cb32c6f9add0d2e214c"
// <auto-generated/>
#pragma warning disable 1591
namespace Project_FrontEnd.Shared
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
#line 12 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using System.Threading;

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
#line 14 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\StoreProfilePicForm.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class StoreProfilePicForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\StoreProfilePicForm.razor"
                   ShowModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "<i class=\"fas fa-camera\"></i> Change Store logo");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n");
            __builder.OpenComponent<Blazorise.Modal>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.ModalContent>(8);
                __builder2.AddAttribute(9, "IsCentered", "true");
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.ModalHeader>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.CloseButton>(13);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalBody>(15);
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Project_FrontEnd.Shared.ImageFileUpload>(17);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalFooter>(19);
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazorise.Button>(21);
                        __builder4.AddAttribute(22, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 16 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\StoreProfilePicForm.razor"
                           Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\StoreProfilePicForm.razor"
                                                      HideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(25, "Close");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(26, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.Button>(27);
                        __builder4.AddAttribute(28, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 17 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\StoreProfilePicForm.razor"
                           Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\StoreProfilePicForm.razor"
                                                    HideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(31, "Save Changes");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(32, (__value) => {
#nullable restore
#line 7 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\StoreProfilePicForm.razor"
             modalRef = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\StoreProfilePicForm.razor"
      
    private Modal modalRef;
    string fileContent;
    int OneMb =1;

    private void ShowModal()
    {
        modalRef.Show();
    }
    private void HideModal()
    {
        modalRef.Hide();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

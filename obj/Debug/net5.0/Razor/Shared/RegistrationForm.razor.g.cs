#pragma checksum "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab1471b8e2d9ce0e74ab8236e36a30aa3257535"
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
    public partial class RegistrationForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor"
                 UserRegistration

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor"
                                                  OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "container");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col col-sm");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "card align-middle shadow-lg p-3 mb-5 bg-body rounded");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "card-body");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col col-6 col-sm");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "login-form");
                __builder2.AddMarkupContent(22, "<h1>Sign Up</h1>\r\n                                        ");
                __builder2.AddMarkupContent(23, "<div class=\"align-middle\">\r\n                                        I am already registed! <a href=\"/UserLogin\">Log In</a>\r\n                                        <br></div>\r\n                                        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "input-group mb-3");
                __builder2.AddMarkupContent(26, "<span class=\"input-group-text\" id=\"basic-addon1\"><i class=\"fas fa-envelope-open-text\"></i></span>\r\n                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "type", "email");
                __builder2.AddAttribute(29, "placeholder", "Email");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor"
                                                                                                                        UserRegistration.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRegistration.Email = __value, UserRegistration.Email))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRegistration.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                                        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "input-group mb-3");
                __Blazor.Project_FrontEnd.Shared.RegistrationForm.TypeInference.CreateValidationMessage_0(__builder2, 37, 38, 
#nullable restore
#line 24 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor"
                                                                       () => UserRegistration.Email

#line default
#line hidden
#nullable disable
                , 39, "form-label");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                                        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "input-group mb-3");
                __builder2.AddMarkupContent(43, "<span class=\"input-group-text\" id=\"basic-addon1\"><i class=\"fas fa-key\"></i></span>\r\n                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "type", "password");
                __builder2.AddAttribute(46, "placeholder", "Password");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor"
                                                                                                                               UserRegistration.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRegistration.Password = __value, UserRegistration.Password))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRegistration.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                                        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "input-group mb-3");
                __Blazor.Project_FrontEnd.Shared.RegistrationForm.TypeInference.CreateValidationMessage_1(__builder2, 54, 55, 
#nullable restore
#line 32 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor"
                                                                        () => UserRegistration.Password

#line default
#line hidden
#nullable disable
                , 56, "form-label");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                                        ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "input-group mb-3");
                __builder2.AddMarkupContent(60, "<span class=\"input-group-text\" id=\"basic-addon1\"><i class=\"fas fa-key\"></i></span>\r\n                                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "type", "password");
                __builder2.AddAttribute(63, "placeholder", "Comfirm password");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor"
                                                                                                                                       UserRegistration.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserRegistration.ConfirmPassword = __value, UserRegistration.ConfirmPassword))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserRegistration.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                                        ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "input-group mb-3");
                __Blazor.Project_FrontEnd.Shared.RegistrationForm.TypeInference.CreateValidationMessage_2(__builder2, 71, 72, 
#nullable restore
#line 40 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor"
                                                                       () => UserRegistration.ConfirmPassword

#line default
#line hidden
#nullable disable
                , 73, "form-label");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                        <br>\r\n                                        ");
                __builder2.AddMarkupContent(75, "<button type=\"submit\" class=\"btn btn-primary\">Register</button>\r\n                                        <br>\r\n                                        ");
                __builder2.AddMarkupContent(76, "<div><label>-Or Use-</label></div>\r\n                                        ");
                __builder2.AddMarkupContent(77, "<div class=\"d-inline p-2\"><a href=\"#\"><i class=\"fab fa-facebook-square\"></i></a></div>\r\n                                        ");
                __builder2.AddMarkupContent(78, "<div class=\"d-inline p-2\"><a href=\"#\"><i class=\"fab fa-instagram\"></i></a></div>\r\n                                        ");
                __builder2.AddMarkupContent(79, "<div class=\"d-inline p-2\"><a href=\"#\"><i class=\"fab fa-google\" style=\"font-size: 18px;\"></i></a></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "    \r\n                                ");
                __builder2.AddMarkupContent(81, "<div class=\"col col-6 col-sm\"><img src=\"images/signup-image.jpg\" class=\"align-middle\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\RegistrationForm.razor"
      
        [Parameter] public UserRegistrationData UserRegistration { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Project_FrontEnd.Shared.RegistrationForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

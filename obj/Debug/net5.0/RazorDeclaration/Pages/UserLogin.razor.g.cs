// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Project_FrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Project_FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Project_FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using AdminPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\UserLogin.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\UserLogin.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\UserLogin.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\UserLogin.razor"
using AdminPortal.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserLogin")]
    public partial class UserLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "c:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\UserLogin.razor"
      

    private LoginData usrLogin = new LoginData();
    string errorMesssage ="";
    int loadingbit = 0;

    string navEvaluation ="";
    StoreNameValidator storeVal = new StoreNameValidator();
        protected override async Task OnInitializedAsync()
        {
            await localStore.ClearAsync();
        }
            
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await localStore.ClearAsync();
        }

    private async Task PostRequestLogin()
    {
        
        loadingbit =1;
        var newLoging =  new LoginData {

            Email = usrLogin.Email,
            Password = usrLogin.Password

        };
        //remove Authorization
        Http.DefaultRequestHeaders.Remove("Authorization");
        //remove Authorization
        var Uri =  "api/UserAccount/Login";
        var response = await Http.PostAsJsonAsync(Uri,newLoging);
        var result = await response.Content.ReadFromJsonAsync<UserToken>();
        Thread.Sleep(10000);
        var token = result.token;
        var Id = result.Id;
            if (token != null){
                //Session on brower local storage
                await localStore.SetItemAsync("token", token);
                await localStore.SetItemAsync("Id", Id);

                
                navEvaluation = await storeVal.StoreValidationByUser(Http,localStore);
                
                if (navEvaluation == "1"){
                    nav.NavigateTo("/Index");
                }else if (navEvaluation == "2"){
                    nav.NavigateTo("/StoreSetup");
                }
            } else  {
                loadingbit =2;
                errorMesssage = $"Error : Invalid Login";
            } 
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

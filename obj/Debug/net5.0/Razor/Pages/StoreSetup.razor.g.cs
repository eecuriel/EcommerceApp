#pragma checksum "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b622d2951209baaec0712f8a180eee450154e86"
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
#line 14 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
using AdminPortal.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/StoreSetup")]
    public partial class StoreSetup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container justify-content-md-center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-md-center");
            __builder.AddMarkupContent(4, "<img src=\"/images/store.png\" class=\"img-fluid w-25\" alt=\"my store\">");
#nullable restore
#line 15 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
 if (setStep ==0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container justify-content-md-center");
            __builder.OpenComponent<Blazorise.Carousel>(7);
            __builder.AddAttribute(8, "SelectedSlide", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
                                    selectedSlide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "SelectedSlideChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedSlide = __value, selectedSlide))));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.CarouselSlide>(11);
                __builder2.AddAttribute(12, "Name", "1");
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Eum, saepe!</p>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.OpenComponent<Blazorise.CarouselSlide>(16);
                __builder2.AddAttribute(17, "Name", "2");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Nobis suscipit velit excepturi? Totam, neque quaerat?</p>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenComponent<Blazorise.CarouselSlide>(21);
                __builder2.AddAttribute(22, "Name", "3");
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Impedit, doloribus quam! Quam veritatis deleniti perspiciatis, ab aspernatur est soluta dicta?</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "btn btn-info align-middle");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
                                                                        () => ShowStep(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Start your Store");
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"

} else if (setStep ==1){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "container justify-content-md-center");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col col-12");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card align-middle shadow-lg p-3 mb-5 bg-body rounded");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "card-body");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col col-12");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "input-group mb-3");
            __builder.OpenComponent<Project_FrontEnd.Shared.InputextStoreName>(46);
            __builder.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
                                                                      storeShortName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => storeShortName = __value, storeShortName))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "class", "btn btn-info align-middle");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
                                                                                                    () => ShowStep(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Next Step");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
        
    
} else if (setStep ==2){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "container justify-content-md-center");
            __builder.OpenComponent<Project_FrontEnd.Shared.StoreCreateForm>(57);
            __builder.AddAttribute(58, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 55 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
                                            PostStoreRegistration

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(59, "StoreData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AdminPortal.Models.StoreRegistrationData>(
#nullable restore
#line 55 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
                                                                              StoreData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "StoreShortName", "storeShortName");
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Pages\StoreSetup.razor"
      
    private string selectedSlide = "3";
    int setStep = 0;
    private StoreRegistrationData StoreData = new StoreRegistrationData();
    string errorMesssage ="";
    int loadingbit = 0;
    string  ownerId ="";
    string storeShortName ="";

    protected override void OnInitialized()
        {
        StoreValidationByUser();
        }

    async void StoreValidationByUser() {

        ownerId = await localStore.GetItemAsStringAsync("Id");

        var Uri =  $"api/Store/Stores/UserId/{ownerId}";
        //End point unique authorization
        var token = await localStore.GetItemAsStringAsync("token");
        Http.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        //End point unique authorization
        var response = await Http.GetAsync(Uri);
        var result = await response.Content.ReadFromJsonAsync<Store>();
            var UserId = result.UserId;
            if (UserId == ownerId){
                nav.NavigateTo("/Index");
            } 
    } 

    async void ShowStep(int step){
        setStep = step;
        storeShortName = await localStore.GetItemAsStringAsync("StoreName");
    }
    private async Task PostStoreRegistration()
    {

        //try {
    
        //if (loadingbit == 1) {
        ownerId = await localStore.GetItemAsStringAsync("Id");
        storeShortName = await localStore.GetItemAsStringAsync("StoreName");
        loadingbit =1;
        var newStore =  new StoreRegistrationData {

            StoreName = StoreData.StoreName,
            StoreShortName= storeShortName,
            StoreFullDescription =StoreData.StoreFullDescription,
            StoreCreationDate = DateTime.UtcNow,
            StoreStatus = "Pending",
            UserId =  ownerId
        };
        Console.WriteLine($"Store : {newStore.StoreShortName}");
        var Uri =  "api/Store/CreateStore";
        var response = await Http.PostAsJsonAsync(Uri,newStore);
        var result = await response.Content.ReadFromJsonAsync<ResponseState>();
        Thread.Sleep(10000);
            var state = result.state;
            if (state == "Created"){
                nav.NavigateTo("/Index");
            } else  {
                loadingbit =2;
                errorMesssage = $"Error : Not Created";
            } 
       // } else if ( loadingbit == 2){
           // errorMesssage = $"Exist an store with this name.";
        //}
    /* } catch (Exception e){
            loadingbit = 2;
            errorMesssage = $"{e.Message}";
        }*/
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
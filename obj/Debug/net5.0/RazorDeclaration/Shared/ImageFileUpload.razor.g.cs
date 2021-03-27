// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Project_FrontEnd.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 14 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\ImageFileUpload.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\ImageFileUpload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\ImageFileUpload.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\ImageFileUpload.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\ImageFileUpload.razor"
using AdminPortal.Services;

#line default
#line hidden
#nullable disable
    public partial class ImageFileUpload : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\eduar\Documents\Proyectos 2021\04 Haddie\03 Realization\AdminPortal\Shared\ImageFileUpload.razor"
 
    private CancellationTokenSource cancelation;
    private bool displayProgress;
    private EditContext editContext;
    private StoreLogo store;
    private ResponseState result = new ResponseState();
    private int progressPercent;
    protected override void OnInitialized()
    {
        cancelation = new CancellationTokenSource();
        store = new StoreLogo();
        editContext = new EditContext(store);
    }
    private async Task OnChange(InputFileChangeEventArgs eventArgs)
    {
        store.StoreLogoImage = eventArgs.File;
        store.StoreLastModifiedDate = DateTime.UtcNow;
        store.StoreShortName =  await localStorage.GetItemAsStringAsync("storeShortName");
        editContext.NotifyFieldChanged(FieldIdentifier.Create(() => store.StoreLogoImage));
    }

    private async Task OnSubmit()
    {
        using var file = File.OpenWrite(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));
        using var stream = store.StoreLogoImage.OpenReadStream();
        var buffer = new byte[4 * 1096];
        int bytesRead;
        double totalRead = 0;
        displayProgress = true;

        while ((bytesRead = await stream.ReadAsync(buffer, cancelation.Token)) != 0)
        {
            totalRead += bytesRead;
            await file.WriteAsync(buffer, cancelation.Token);
            progressPercent = (int)((totalRead / store.StoreLogoImage.Size) * 100);
            StateHasChanged();
        }
        
        displayProgress = false;
        
        result = await storeDataService.putStoreLogo(store);
        
    }

    public void Dispose()
    {
        cancelation.Cancel();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StoreDataService storeDataService { get; set; }
    }
}
#pragma warning restore 1591

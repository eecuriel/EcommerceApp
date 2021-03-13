using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Blazored.LocalStorage;
using Blazorise;
using Blazorise.Bootstrap;
using AdminPortal.Services;
using Blazored.SessionStorage;

namespace Project_FrontEnd
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services
            .AddBlazoredLocalStorage()
            .AddScoped<StoreDataService>(); 

            builder.Services
            .AddBlazoredSessionStorage()
            .AddScoped<StoreDataService>(); 
            

            builder.Services
            .AddBlazorise( options =>
            {
                options.ChangeTextOnKeyPress = true;
            } )
            .AddBootstrapProviders();

            builder.Services.AddScoped(sp => 
            new HttpClient
            {
                BaseAddress = new Uri("https://localhost:444/")
                //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });

            await builder.Build().RunAsync();
        }

    }
}

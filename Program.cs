using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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

            var url = builder.Configuration.GetValue<string>("ApiConfig:Url");
        
            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddTransient(sp => 
            new HttpClient
            {
                BaseAddress = new Uri(url)
            });


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

            await builder.Build().RunAsync();
        }

    }
}

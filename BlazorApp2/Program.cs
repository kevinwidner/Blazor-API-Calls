using BlazorApp2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var myAPI = "https://api.agify.io";//?name=meelad
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(myAPI) });

await builder.Build().RunAsync();

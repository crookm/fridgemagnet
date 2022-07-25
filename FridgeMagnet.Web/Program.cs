using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FridgeMagnet.Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.RegisterAsCustomElement<MagnetCalculator>("fridgemagnet-calculator");
await builder.Build().RunAsync();
using Blazored.LocalStorage;
using CastleTours.Client;
using CastleTours.Client.Services.CastleService;
using CastleTours.Client.Services.CategoryService;
using CastleTours.Client.Services.TourService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICastleService, CastleService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ITourService, TourService>();
builder.Services.AddScoped<DialogState>();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();

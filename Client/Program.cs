using Blazored.LocalStorage;
using Blazored.Toast;
using CastleTours.Client;
using CastleTours.Client.Services.AuthService;
using CastleTours.Client.Services.CartService;
using CastleTours.Client.Services.CastleService;
using CastleTours.Client.Services.CategoryService;
using CastleTours.Client.Services.StatsService;
using CastleTours.Client.Services.StoreConfigService;
using CastleTours.Client.Services.TicketOrderService;
using CastleTours.Client.Services.TourService;
using CastleTours.Client.Services.UserService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICastleService, CastleService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ITourService, TourService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ITicketOrderService, TicketOrderService>();
builder.Services.AddScoped<IStoreConfigService, StoreConfigService>();
builder.Services.AddScoped<IStatsService, StatsService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();


builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();

builder.Services.AddOptions();

builder.Services.AddAuthorizationCore();


await builder.Build().RunAsync();

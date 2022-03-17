using Blazored.LocalStorage;
using Blazored.Toast;

using CastleTours.Client;
using CastleTours.Client.Services.AuthService;
using CastleTours.Client.Services.CartService;
using CastleTours.Client.Services.CastleService;
using CastleTours.Client.Services.CategoryService;
using CastleTours.Client.Services.DialogService;
using CastleTours.Client.Services.FacilityService;
using CastleTours.Client.Services.SearchService;
using CastleTours.Client.Services.StatsService;
using CastleTours.Client.Services.StoreConfigService;
using CastleTours.Client.Services.TicketOrderService;
using CastleTours.Client.Services.TourService;
using CastleTours.Client.Services.UserService;
using CastleTours.Client.Services.UtilitiesService;

using MudBlazor.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
//using MudBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ICastleService, CastleService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IDialogServiceCustom, DialogServiceCustom>();
builder.Services.AddScoped<IFacilityService, FacilityService>();
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IStatsService, StatsService>();
builder.Services.AddScoped<IStoreConfigService, StoreConfigService>();
builder.Services.AddScoped<ITicketOrderService, TicketOrderService>();
builder.Services.AddScoped<ITourService, TourService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUtilitiesService, UtilitiesService>();

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<DialogState>();

builder.Services.AddMudServices();

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();

builder.Services.AddOptions();

builder.Services.AddAuthorizationCore();


await builder.Build().RunAsync();

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using portfolio;
using portfolio.Services;
using System.Globalization;
using Microsoft.JSInterop;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

#if RELEASE
builder.HostEnvironment.BaseAddress = "/portfolio/";
#endif

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddLocalization();

builder.Services.AddMudServices();
builder.Services.AddSingleton<ThemingService>();
//builder.Services.AddSingleton<LanguageService>();

var host = builder.Build();

var js = host.Services.GetRequiredService<IJSRuntime>();
var stored_culture = await js.InvokeAsync<string>("culture.get");

var culture = new CultureInfo(stored_culture ?? "en");
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;



await host.RunAsync();

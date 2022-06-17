using Gaby.Client;
using Gaby.Client.Services.Client;
using Gaby.Client.Services.SharedServices;
using Gaby.Client.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// for AddClient.razor
builder.Services.AddScoped<IAlertService, AlertService>();
//builder.Services.AddScoped<IUploadService, UploadService>();



// for Client.razor
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IHttpService, HttpService>();
builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();

builder.Services.AddScoped(x =>
{
    var apiUrl = new Uri("http://localhost:7121");
    return new HttpClient() { BaseAddress = apiUrl };
});

builder.Services.AddSingleton<PageHistoryState>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

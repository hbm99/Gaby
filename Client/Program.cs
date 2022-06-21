using Gaby.Client;
using Gaby.Client.Services.Client;
using Gaby.Client.Services.Measurements;
using Gaby.Client.Services.Employee;
using Gaby.Client.Services.GymService;
using Gaby.Client.Services.SharedServices;
using Gaby.Client.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen.Blazor;
using Radzen.Blazor.Rendering;

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

builder.Services.AddScoped<IGymServiceService, GymServiceService>();


// for ListEmployee.razor
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<ICoachService, CoachService>();
builder.Services.AddScoped<ICleanerEmployeeService, CleanerEmployeeService>();
builder.Services.AddScoped<IMaintenanceEmployeeService, MaintenanceEmployeeService>();

builder.Services.AddScoped<IMeasurementsService, MeasurementsService>();

//for radzen components
builder.Services.AddScoped<ChartTooltip>();
builder.Services.AddScoped<RadzenChartTooltipOptions>();
builder.Services.AddScoped<RadzenChart>();


builder.Services.AddScoped(x =>
{
    var apiUrl = new Uri("http://localhost:7121");
    return new HttpClient() { BaseAddress = apiUrl };
});

builder.Services.AddSingleton<PageHistoryState>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

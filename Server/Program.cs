using Gaby.Server.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Gaby.Server.Infrastructure.Repository;
using Gaby.Server.Authorization;
using Gaby.Server.Helpers;
using Gaby.Server.Infrastructure.Repository.Employee;
using Gaby.Shared.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var gabyconnectionString = builder.Configuration.GetConnectionString("DefaultGabyConnection");
builder.Services.AddDbContext<GabyDbContext>(options =>
    options.UseSqlServer(gabyconnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddAuthentication()
    .AddIdentityServerJwt();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddScoped<IGenericRepository<Service>, GymServiceRepository>();
builder.Services.AddScoped<IGenericRepository<ServiceType>, GymServiceTypeRepository>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped(typeof(IGenericEmployeeTypeRepository<>), typeof(GenericEmployeeTypeRepository<>));

builder.Services.AddScoped<IMeasurementsRepository, MeasurementsRepository>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IJwtUtils, JwtUtils>();

builder.Services.AddScoped<ILessonRepository, LessonRepository>();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.UseRouting();

app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseMiddleware<JwtMiddleware>();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

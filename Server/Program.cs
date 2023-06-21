global using AspDotNetCoreBlazorFullStackCrud.Client.Services.EmployeeService;
global using AspDotNetCoreBlazorFullStackCrud.Shared;
using AspDotNetCoreBlazorFullStackCrud.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Microsoft.AspNetCore.ResponseCompression;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add services to the container.
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped<HttpClient>();
//builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();



await builder.Build().RunAsync();
global using Dominio.Modelos.Nucleo;
global using Dominio.Modelos.Intervencion;
global using Dominio.Modelos.Usuarios;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WatchFactory_Client;
using WatchFactory_Client.Services;
using WatchFactory_Client.Services.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7170/") });

builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IIntervencionService, IntervencionService>();
builder.Services.AddScoped<IConfiguracionService, ConfiguracionService>();

await builder.Build().RunAsync();

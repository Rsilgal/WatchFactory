global using Dominio.Modelos.Nucleo;
global using Dominio.Modelos.Intervencion;
global using Dominio.Modelos.Usuarios;
global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;

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

builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<IEstadoIntervencion, EstadoIntervencionService>();
builder.Services.AddScoped<IFabricaService, FabricaService>();
builder.Services.AddScoped<IIntervencionService, IntervencionService>();
builder.Services.AddScoped<ILineaProduccionService, LineaProduccionService>();
builder.Services.AddScoped<IMaquinaService, MaquinaService>();
builder.Services.AddScoped<IPermisoService, PermisoService>();
builder.Services.AddScoped<IRolService, RolService>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<ITipoIntervencionService, TipoIntervencionService>();
builder.Services.AddScoped<ITipoMaquinaService, TipoMaquinaService>();
builder.Services.AddScoped<IUrgenciaService, UrgenciaService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IZonaService, ZonaService>();

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddAuthorizationCore();

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();

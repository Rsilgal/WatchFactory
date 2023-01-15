using Aplicacion.Repository;
using Aplicacion.Services.Interfaces;
using Aplicacion.Services;
using Infraestructura.Repository;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using WatchFactory.Areas.Identity;
using WatchFactory.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

// Add Dependecy Injections
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

builder.Services.AddScoped<IEstadoIntervencionRepository, EstadoIntervencionRepository>();
builder.Services.AddScoped<IEstadoIntervencionService, EstadoIntervecionService>();

builder.Services.AddScoped<IFabricaRepository, FabricaRepository>();
builder.Services.AddScoped<IFabricaService, FabricaService>();

builder.Services.AddScoped<IIntervencionRepository, IntervencionRepository>();
builder.Services.AddScoped<IIntervencionService, IntervencionService>();

builder.Services.AddScoped<ILineaProduccionRepository, LineaProduccionRepository>();
builder.Services.AddScoped<ILinneaProduccionService, LineaProduccionService>();

builder.Services.AddScoped<IMaquinaRepository, MaquinaRepository>();
builder.Services.AddScoped<IMaquinaService, MaquinaService>();

//builder.Services.AddScoped<IPermisoRepository, PermisoRepository>();
//builder.Services.AddScoped<IPermisoService, PermisoService>();

//builder.Services.AddScoped<IRolRepository, RolRepository>();
//builder.Services.AddScoped<IRolService, RolService>();

builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<ITicketService, TicketService>();

builder.Services.AddScoped<ITipoIntervencionRepository, TipoIntervencionRepository>();
builder.Services.AddScoped<ITipoIntervencionService, TipoIntervencionService>();

builder.Services.AddScoped<ITipoMaquinaRepository, TipoMaquinaRepository>();
builder.Services.AddScoped<ITipoMaquinaService, TipoMaquinaService>();

builder.Services.AddScoped<IUrgenciaRepository, UrgenciaRepository>();
builder.Services.AddScoped<IUrgenciaService, UrgenciaService>();

builder.Services.AddScoped<IZonaRepository, ZonaRepository>();
builder.Services.AddScoped<IZonaService, ZonaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

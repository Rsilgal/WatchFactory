using Aplicacion.Repository;
using Aplicacion.Services;
using Aplicacion.Services.Interfaces;
using Infraestructura;
using Infraestructura.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WatchFactoryDbContext>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("sqlServerDataBase")));

builder.Services.AddMvcCore().AddApiExplorer();

builder.Services.AddScoped <ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped <ICategoriaService, CategoriaService>();

builder.Services.AddScoped <IEstadoIntervencionRepository, EstadoIntervencionRepository>();
builder.Services.AddScoped<IEstadoIntervencionService, EstadoIntervecionService>();

builder.Services.AddScoped <IFabricaRepository, FabricaRepository>();
builder.Services.AddScoped <IFabricaService, FabricaService>();

builder.Services.AddScoped<IIntervencionRepository, IntervencionRepository>();
builder.Services.AddScoped<IIntervencionService, IntervencionService>();

builder.Services.AddScoped <ILineaProduccionRepository, LineaProduccionRepository>();
builder.Services.AddScoped<ILinneaProduccionService, LineaProduccionService>();

builder.Services.AddScoped <IMaquinaRepository, MaquinaRepository>();
builder.Services.AddScoped <IMaquinaService, MaquinaService>();

builder.Services.AddScoped <IPermisoRepository, PermisoRepository>();
builder.Services.AddScoped <IPermisoService, PermisoService>();

builder.Services.AddScoped<IRolRepository, RolRepository>();
builder.Services.AddScoped <IRolService, RolService>();

builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<ITicketService, TicketService>();

builder.Services.AddScoped <ITipoIntervencionRepository,TipoIntervencionRepository>();
builder.Services.AddScoped<ITipoIntervencionService,TipoIntervencionService>();

builder.Services.AddScoped<ITipoMaquinaRepository, TipoMaquinaRepository>();
builder.Services.AddScoped<ITipoMaquinaService, TipoMaquinaService>();

builder.Services.AddScoped<IUrgenciaRepository, UrgenciaRepository>();
builder.Services.AddScoped<IUrgenciaService, UrgenciaService>();

builder.Services.AddScoped<IZonaRepository, ZonaRepository>();
builder.Services.AddScoped<IZonaService, ZonaService>();

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Mis cors", builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
    );
});


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var conetxt = scope.ServiceProvider.GetRequiredService<WatchFactoryDbContext>();
//    conetxt.Database.Migrate();
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("Mis cors");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

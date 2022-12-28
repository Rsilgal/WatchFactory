using Aplicacion.Repository;
using Aplicacion.Services;
using Aplicacion.Services.Interfaces;
using Infraestructura;
using Infraestructura.Repository;
using Microsoft.EntityFrameworkCore;

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

builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<ITicketService, TicketService>();

builder.Services.AddScoped<IIntervencionRepository, IntervencionRepository>();
builder.Services.AddScoped<IIntervencionService, IntervencionService>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();

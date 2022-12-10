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

builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();

builder.Services.AddScoped<IIntervencionService, IntervencionService>();
builder.Services.AddScoped<IIntervencionRepository, IntervencionRepository>();

var app = builder.Build();

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

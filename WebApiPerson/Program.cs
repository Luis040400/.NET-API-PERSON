using Microsoft.EntityFrameworkCore;
using WebApiPerson.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Crear variable para la cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("Connection");
//regsitrar servicio para la conexión
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString)); 

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => {
    options.AddPolicy("NuevaPolitica", app => {
    app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("NuevaPolitica");

app.UseAuthorization();

app.MapControllers();

app.Run();

using api_softtek.Busissness_Layer;
using api_softtek.Common_Layer.Interfaces;
using api_softtek.Common_Layer.Mapper;
using api_softtek.Common_Layer.Models;
using api_softtek.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<AppDbContext>(e => e.UseSqlServer("Server=DESKTOP-DNV1UV9; Database=practica3; Integrated Security=True;TrustServerCertificate=true"));

builder.Services.AddScoped<IEstudianteService,EstudianteService>();
builder.Services.AddScoped<ICarreraService,CarreraService>();   
builder.Services.AddScoped<IMateriaService,MateriaService>();
builder.Services.AddScoped<INotaService, NotaService>();
builder.Services.AddScoped<IProfesorService, ProfesorService>();

builder.Services.AddScoped<IGenericRepository<Estudiante>, GenericRepository<Estudiante>>();    
builder.Services.AddScoped<IGenericRepository<Carrera>, GenericRepository<Carrera>>();
builder.Services.AddScoped<IGenericRepository<Materia>, GenericRepository<Materia>>();
builder.Services.AddScoped<IGenericRepository<Nota>, GenericRepository<Nota>>();
builder.Services.AddScoped<IGenericRepository<Profesor>, GenericRepository<Profesor>>();

builder.Services.AddAutoMapper(typeof(Mapper)); // Scan for profiles in the assembly

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



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

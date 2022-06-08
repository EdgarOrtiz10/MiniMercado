using Microsoft.EntityFrameworkCore;
using MinimercadoApp.Application;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Infrastructure.Filters;
using MiniMercadoApp.Infrastructure.Persistance;
using MiniMercadoApp.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(option =>
{
    //se registra el manejo de excepciones de manera globar
    option.Filters.Add<GlobalExceptionFilter>();
});
builder.Services.AddControllers();
builder.Services.AddDbContext<MiniMercadoContext>(options => options.UseSqlServer("name=ConnectionStrings:MiniMercado"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();

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

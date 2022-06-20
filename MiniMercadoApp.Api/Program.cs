using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MinimercadoApp.Application;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Aplication.Services;
using MiniMercadoApp.Infrastructure.Filters;
using MiniMercadoApp.Infrastructure.Persistance;
using MiniMercadoApp.Infrastructure.Repositories;
using System.Text;

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
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IFacturasRepository, FacturasRepository>();
builder.Services.AddTransient<IProductosRepository, ProductosRepository>();
builder.Services.AddTransient<IProveedoresRepository, ProveedoresRepository>();
builder.Services.AddTransient<IVentasRepository, VentasRepository>();

//Registramos la autenticacion con JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    //Se definen los parametros de validación del token
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "https://localhost:44357",
        ValidAudience = "https://localhost:44357",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("hh8f0iiajsiahfawpfjckslirmclslxplk"))
    };
});


builder.Services.AddTransient<ICategoriaService, CategoriaService>();

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

//Se registra la autenticación 
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

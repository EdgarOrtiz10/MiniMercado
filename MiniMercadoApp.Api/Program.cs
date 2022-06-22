using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MinimercadoApp.Application;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Aplication.Services;
using MiniMercadoApp.Infrastructure.Filters;
using MiniMercadoApp.Infrastructure.Persistance;
using MiniMercadoApp.Infrastructure.Repositories;
using System.Reflection;
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

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "MiiniMercado API",
        Description = "Estas son los endpoints disponibles para la API Minimercado"
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"Bienvenido al MiniMercado, recuerde que al escribir el toke debe de ir antes la palabra 'Bearer (token)'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
      {
        {
          new OpenApiSecurityScheme
          {
            Reference = new OpenApiReference
              {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
              },
              Scheme = "oauth2",
              Name = "Bearer",
              In = ParameterLocation.Header,

            },
            new List<string>()
          }
        });

    //Obtener de forma dinamica el nombre del archivo
    var nombreArchivo = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

    //Creamos una variable con la ruta completa del archivo
    var xmlPath = Path.Combine(AppContext.BaseDirectory, nombreArchivo);

    options.IncludeXmlComments(xmlPath);
});
builder.Services.AddApplicationServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(/*options =>
    {
        //Especificar la url en donde se encuentra el swagger de la API
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "MiniMercado API v1");

        //Especificar que swagger sea la pagina por defecto
        options.RoutePrefix = string.Empty;
    }*/);
}

app.UseHttpsRedirection();

//Se registra la autenticación 
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

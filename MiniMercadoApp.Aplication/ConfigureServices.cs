using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;

namespace MinimercadoApp.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //Registra automaticamente todos los mapping de Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //Registra automaticamente todos los validadores de Fluent Validation
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}

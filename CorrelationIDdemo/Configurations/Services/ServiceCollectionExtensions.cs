using CorrelationIDdemo;
using CorrelationIDdemo.Configurations.Interface;
namespace CorrelationIDdemo.Configurations.Services;
public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCorrelationIdGeneratorService(this IServiceCollection services)
        {
            services.AddScoped<ICorrelationIdGenerator, CorrelationIdGenerator>();

            return services;
        }
    }
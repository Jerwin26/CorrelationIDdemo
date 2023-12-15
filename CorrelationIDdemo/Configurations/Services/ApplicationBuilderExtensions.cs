using CorrelationIDdemo.Helpers;

namespace CorrelationIDdemo.Configurations.Services
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder AddCorrelationIdMiddleware(this IApplicationBuilder applicationBuilder)
            => applicationBuilder.UseMiddleware<CorrelationIdMiddleare>();
    }
}

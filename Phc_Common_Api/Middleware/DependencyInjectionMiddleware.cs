using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Phc_Common_Api.DatabaseContext;
using Phc_Common_Api.Service;

namespace Phc_Common_Api.Middleware
{
    public class DependencyInjectionMiddleware
    {
        private readonly RequestDelegate _next;

        public DependencyInjectionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            return _next(httpContext);
        }
    }

    public static class DependencyInjectionMiddlewareExtensions
    {

        public static IApplicationBuilder UseStactive(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DependencyInjectionMiddleware>();
        }

        public static IServiceCollection AddStactive(this IServiceCollection services)
        {
            // IOC
            //services.AddTransient<ELMContext>();
            services.AddScoped<IBMD2Context>();
            services.AddScoped<SupplierService>();
            services.AddScoped<DivisionsLocationsService>();
            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;

namespace MontyClt.Bui.Startup
{
    public static class ServiceExtensions
    {
        public static void AddBui(this IServiceCollection services)
        {
            services.AddTransient<Components.Modal.Alert>();
        }
    }
}

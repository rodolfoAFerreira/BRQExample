using Microsoft.Extensions.DependencyInjection;
using BRQExampleIoC;

namespace BRQExample.Middlewares
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
            Injection.RegisterService(services);
        }
    }
}


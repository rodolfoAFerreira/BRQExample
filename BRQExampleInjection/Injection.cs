using BRQExample.Service;
using Microsoft.Extensions.DependencyInjection;
using BRQExampleDomain.Interface.Service;
using BRQExampleDomain.Service;
using BRQExampleApplication.Interface;
using BRQExampleApplication;

namespace BRQExampleIoC
{
    public class Injection
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Application
            services.AddScoped<IPortfolioAppService, PortfolioAppService>();
            services.AddScoped<ICategoryAppService, CategoryAppService>();


            //DOMAIN
            services.AddScoped<IPortfolioService, PortfolioService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}

using BRQExample.Middlewares;
using BRQExampleApplication.Interface;
using BRQExampleDomain.Interface.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace BRQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            var provider = DependencyInjection();
            var _portfolioAppService = provider.GetService<IPortfolioAppService>();
            var _categoryAppSerivce = provider.GetService<ICategoryAppService>();

            Console.WriteLine("------------------------------");
            Console.WriteLine("---- Welcome to the bank! ----");
            Console.WriteLine("------------------------------");

            bool reapetOperation = true;
            bool listTrades = true;
            int step = 1;
            while (reapetOperation)
            {
                switch (step)
                {
                    case 1:
                        Console.WriteLine("\nPlease, enter a date of reference!");

                        var value = Console.ReadLine();
                        var reference = await _portfolioAppService.getDateReference(value);

                        if (string.IsNullOrEmpty(reference))
                        {
                            step++;
                            continue;
                        }

                        Console.WriteLine(reference);
                        break;
                    case 2:
                        Console.WriteLine("\nPlease, enter a Id of Portfolio!");

                        value = Console.ReadLine();
                        reference = await _portfolioAppService.getPortfolioId(value);

                        if (string.IsNullOrEmpty(reference))
                        {
                            step++;
                            continue;
                        }

                        Console.WriteLine(reference);
                        break;
                    case 3:
                        Console.WriteLine("\nPlease, enter with itens of negociation! ( Ex:. 000000 Public Month/Day/Year )");

                        while (listTrades)
                        {

                            value = Console.ReadLine();
                            reference = await _portfolioAppService.getTrade(value);

                            if (string.IsNullOrEmpty(reference))
                            {

                                Console.WriteLine(_categoryAppSerivce.ValidCategory(await _portfolioAppService.getTrades()).Result.Trim());

                                continue;
                            }

                            Console.WriteLine(reference);
                        }
                        break;
                }
            }
        }


        public static ServiceProvider DependencyInjection()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDIConfiguration();

            return serviceCollection.BuildServiceProvider();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;

namespace TimeAbstraction
{
    public class Services
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static void RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddTransient<IDiscountLogic, DiscountLogic>();
            services.AddSingleton(TimeProvider.System);

            ServiceProvider = services.BuildServiceProvider();
        }

        public static T Get<T>() where T : class
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }
    }
}

using Kata.Main.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Main.DependencyInjection
{
   public  class KataDependencies
    {
        private static IServiceProvider _container;
        public static IServiceProvider Container
        {
            get
            {
                if (_container == null)
                { _container = BuildDefaultServiceCollection().BuildServiceProvider(); }
                return _container;
            }
        }

        private static ServiceCollection BuildDefaultServiceCollection()
        {
            var services = new ServiceCollection();
            
            services.AddSingleton<IStandardPrice, StandardPrice>();;

            return services;
        }
    }
}

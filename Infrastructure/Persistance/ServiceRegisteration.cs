using Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class ServiceRegisteration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}

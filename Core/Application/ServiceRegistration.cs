using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceRegistration));

            ///ServiceRegistrationın bulunduğu assembly hangisi ise orada ki tüm cqrs yapılanmasını bul ve IOC yapısına işle/ekle diyoruz.
            ///örn; GetAllProducstQueryRequest-GetAllProducstQueryResponse-GetAllProducstQueryHandler
        }
    }
}

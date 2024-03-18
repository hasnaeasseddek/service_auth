using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace cleanProject.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }
    }
}

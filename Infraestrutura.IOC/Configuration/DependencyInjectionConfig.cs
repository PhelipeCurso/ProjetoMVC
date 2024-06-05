using Infraestrutura.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Ioc.Configuration
{
    public class DependencyInjectionConfig 
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<DbContextComuns>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();

            return services;
        }
    }

    internal class PessoaRepository
    {
    }

    internal interface IPessoaRepository
    {
    }
}

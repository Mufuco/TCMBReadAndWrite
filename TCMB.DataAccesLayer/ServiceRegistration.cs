using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCMB.BusinessLayer.ReadServices;
using TCMB.CoreLayer.Repositories.CurrencyRep;
using TCMB.DataAccesLayer.Concrate.CurrencyRep;
using TCMB.DataAccesLayer.Configurations;
using TCMB.DataAccesLayer.Contexts;

namespace TCMB.DataAccesLayer
{
    public static class ServiceRegistration
    {

        public static void AddServices(this IServiceCollection services)
        {
            services.AddDbContext<TCMBContext>(options =>
            options.UseSqlServer(Configuration.ConnectionString));
            services.AddDbContext<TCMBContext>();
            services.AddTransient<ICurrencyReadRepository, CurrencyReadRepository>();
            services.AddTransient<ICurrencyWriteRepository, CurrencyWriteRepository>();
            services.AddTransient<IReadServices, TCMBRead>();


        }
    }
}

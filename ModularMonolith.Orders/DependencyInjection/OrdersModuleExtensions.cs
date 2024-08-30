using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModularMonolith.Orders.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolith.Orders.DependencyInjection
{
    public static class OrdersModuleExtensions
    {
        public static IServiceCollection LoadOrdersModule(
       this IServiceCollection services,
       IConfiguration config)
        {
            return services
                .AddDbContext<OrderDbContext>(opt =>
                {
                    opt.UseNpgsql(config.GetConnectionString("ConnectionStrings.DefaultConnection"), opt =>
                    {
                        opt.CommandTimeout(180);
                        opt.EnableRetryOnFailure(5);
                        opt.MigrationsAssembly("ModularMonolith.Module.Orders");
                    });
                })
                .AddScoped<UnitOfWork>();
        }
    }
}

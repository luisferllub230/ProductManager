using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StockApp.Infraestructure.persistence.Context;
using Aplication.Repository;
using StockApp.Core.Application.Interfaces.Repositories;
using StockApp.Infraestructure.persistence.Repositories;

namespace StockApp.Infraestructure.persistence
{
    public static class ServicesRegistration
    {
        public static void addPercistenceInfrastotory(this IServiceCollection service, IConfiguration configuration) 
        {


            #region context
            if (configuration.GetValue<bool>("UseInMemoryDataBase"))
            {
                service.AddDbContext<AplicationsContext>(o => o.UseInMemoryDatabase("applicationDB"));
            }
            else 
            {
                service.AddDbContext<AplicationsContext>(context => context.UseSqlServer(configuration.GetConnectionString("SQLconection")
                        , migration => migration.MigrationsAssembly(typeof(AplicationsContext).Assembly.FullName)));
            }
            #endregion


            #region repositories
            service.AddTransient(typeof(IGeneryRepository<>), typeof(GeneryRepository<>));
            service.AddTransient<IProductRepository, ProductRepository>();
            service.AddTransient<ICategoryRepository, CategoryRepository>();
            #endregion


        }
    }
}

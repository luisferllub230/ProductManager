using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Aplication.Services;
using StockApp.Core.Application.Interfaces.Services;
using StockApp.Core.Application.Services;

namespace StockApp.Infraestructure.persistence
{
    public static class ServicesRegistration
    {
        public static void addAplicationLayer(this IServiceCollection service, IConfiguration configuration) 
        {

            #region repositories
            service.AddTransient<IProductServices, ProductServices>();
            service.AddTransient<ICategoryServices, CategoryServices>();
            #endregion
        }
    }
}

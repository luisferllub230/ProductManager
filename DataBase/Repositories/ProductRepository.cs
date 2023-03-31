using Microsoft.EntityFrameworkCore;
using StockApp.Core.Application.Interfaces.Repositories;
using StockApp.Core.Domain.Entities;
using StockApp.Infraestructure.persistence.Context;
using StockApp.Infraestructure.persistence.Repositories;

namespace Aplication.Repository
{
    public class ProductRepository : GeneryRepository<Product>, IProductRepository
    {
        private readonly AplicationsContext _Dbcontext;

        public ProductRepository(AplicationsContext context) : base(context)
        {
            _Dbcontext = context;
        }
    }
}

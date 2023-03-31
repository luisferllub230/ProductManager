using StockApp.Core.Application.Interfaces.Repositories;
using StockApp.Core.Domain.Entities;
using StockApp.Infraestructure.persistence.Context;

namespace StockApp.Infraestructure.persistence.Repositories
{
    public class CategoryRepository : GeneryRepository<Categories>, ICategoryRepository
    {
        private readonly AplicationsContext _Dbcontext;

        public CategoryRepository(AplicationsContext context) : base(context) 
        {
            _Dbcontext = context;
        }
    }
}

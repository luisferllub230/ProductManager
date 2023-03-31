using StockApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Application.Interfaces.Repositories
{
    public interface IGeneryRepository<Entity> where Entity : class
    {
        public Task addRepository(Entity entity);
        public Task updateRepository(Entity entity);
        public Task deleteRepository(Entity entity);
        public Task<List<Entity>> getAllRepository();
        public Task<Entity> getByIdRepository(int id);
        public Task<List<Entity>> GetAllWhitIncluedeRepository(List<string> entity);
    }
}

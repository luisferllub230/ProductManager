using Microsoft.EntityFrameworkCore;
using StockApp.Core.Application.Interfaces.Repositories;
using StockApp.Infraestructure.persistence.Context;


namespace StockApp.Infraestructure.persistence.Repositories
{
    public class GeneryRepository<Entity> : IGeneryRepository<Entity> where Entity : class
    {

        private readonly AplicationsContext _Dbcontext;

        public GeneryRepository(AplicationsContext aplicationsContext) 
        {
            _Dbcontext = aplicationsContext;
        }


        public async Task addRepository(Entity entity)
        {
            await _Dbcontext.AddAsync(entity);
            await _Dbcontext.SaveChangesAsync();
        }

        public async Task updateRepository(Entity entity)
        {
            _Dbcontext.Entry(entity).State = EntityState.Modified;
            await _Dbcontext.SaveChangesAsync();
        }

        public async Task deleteRepository(Entity entity)
        {
            _Dbcontext.Set<Entity>().Remove(entity);
            await _Dbcontext.SaveChangesAsync();
        }

        public async Task<List<Entity>> getAllRepository()
        {
            return await _Dbcontext.Set<Entity>().ToListAsync();
        }

        public async Task<Entity> getByIdRepository(int id)
        {
            return await _Dbcontext.Set<Entity>().FindAsync(id);
        }

        public async Task<List<Entity>> GetAllWhitIncluedeRepository(List<string> properties)
        {
            var query = _Dbcontext.Set<Entity>().AsQueryable();

            foreach (string property in properties)
            {
                query.Include(property);
            }

            return await query.ToListAsync();
        }
    }
}

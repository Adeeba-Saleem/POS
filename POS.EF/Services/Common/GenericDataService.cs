using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using POS.Domain.Services.Common;
using POS.EF.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace POS.EF.Services.Common
{
    public class GenericDataService<T> : IDataService<T> where T : class
    {
        private readonly POSDBContextFactory _contextFactory;
        private readonly NonQueryDataService<T> _nonQueryDataService;

        public GenericDataService(POSDBContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonQueryDataService<T>(contextFactory);
        }

        public async Task<T> Create(T entity)
        {
            return await _nonQueryDataService.Create(entity);

        }

        public async Task<bool> Delete(T entity)
        {
            return await _nonQueryDataService.Delete(entity);
        }

        public async Task<T> Get(int id)
        {
            using POSDBContext context = _contextFactory.CreateDbContext();
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using POSDBContext context = _contextFactory.CreateDbContext();
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            return await _nonQueryDataService.Update(entity);
        }
    }
}

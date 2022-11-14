using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TCMB.CoreLayer.Repositories;
using TCMB.DataAccesLayer.Contexts;
using TCMB.EntityLayer.Concrate;

namespace TCMB.DataAccesLayer.Concrate
{
    public class ReadRepository<T> : IReadRepository<T> where T :Entity
    {
        private readonly TCMBContext _context;

        public ReadRepository(TCMBContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;

        public T GetById(int id) => Table.FirstOrDefault(p=>p.Id==id);
        

        public T GetSingle(Expression<Func<T, bool>> filter) => Table.FirstOrDefault(filter);
        

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter) => Table.Where(filter);
        

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

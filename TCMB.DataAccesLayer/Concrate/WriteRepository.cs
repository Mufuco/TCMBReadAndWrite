using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCMB.CoreLayer.Repositories;
using TCMB.DataAccesLayer.Contexts;
using TCMB.EntityLayer.Concrate;

namespace TCMB.DataAccesLayer.Concrate
{
    internal class WriteRepository<T> : IWriteRepository<T> where T : Entity
    {
        readonly private TCMBContext _context;

        public WriteRepository(TCMBContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public bool Add(T model)
        {
           EntityEntry<T> entityEntry = Table.Add(model);
            return entityEntry.State == EntityState.Added;
        }

        public bool AddList(List<T> model)
        {
            Table.AddRange(model);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool Remove(int id)
        {
            T model =Table.FirstOrDefault(x=>x.Id==id);
            return Remove(model);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public bool Update(T model)
        {
            EntityEntry<T> entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}

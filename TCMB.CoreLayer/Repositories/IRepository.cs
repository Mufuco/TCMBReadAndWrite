using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCMB.EntityLayer.Concrate;

namespace TCMB.CoreLayer.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        DbSet<T> Table { get; }

        void SaveChanges();
    }
}

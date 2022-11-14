using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TCMB.EntityLayer.Concrate;

namespace TCMB.CoreLayer.Repositories
{
    public interface IReadRepository<T>:IRepository<T> where T : Entity
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetWhere(Expression<Func<T,bool>> filter);

        T GetSingle(Expression<Func<T, bool>> filter);

        T GetById(int id);


    }
}

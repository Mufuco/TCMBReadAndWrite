﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCMB.EntityLayer.Concrate;

namespace TCMB.CoreLayer.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : Entity
    {
        bool Add(T model);
        bool AddList(List<T> model);

        bool Remove(T model);
        bool Remove(int id);
        bool Update(T model);

    }
}

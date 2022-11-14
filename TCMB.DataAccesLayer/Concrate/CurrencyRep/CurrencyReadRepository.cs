using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCMB.CoreLayer.Repositories.CurrencyRep;
using TCMB.DataAccesLayer.Contexts;
using TCMB.EntityLayer.Concrate;

namespace TCMB.DataAccesLayer.Concrate.CurrencyRep
{
    internal class CurrencyReadRepository : ReadRepository<Currency>, ICurrencyReadRepository
    {
        public CurrencyReadRepository(TCMBContext context) : base(context)
        {
        }
    }
}

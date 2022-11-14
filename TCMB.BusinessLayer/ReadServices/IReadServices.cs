using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCMB.EntityLayer.Concrate;
using TCMB.EntityLayer.PostEntites;

namespace TCMB.BusinessLayer.ReadServices
{
    public interface IReadServices
    {
        public List<CurrencyPostModel> TcmbService();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCMB.EntityLayer.Concrate
{
    public class Currency:Entity
    {
       
        public int Code { get; set; }
        public string currencyName { get; set; }
        public decimal forexBuying { get; set; }
        public decimal forexSelling { get; set; }

        public decimal? banknoteBuying { get; set; }
        public decimal? banknoteSelling { get; set; }

    }
}

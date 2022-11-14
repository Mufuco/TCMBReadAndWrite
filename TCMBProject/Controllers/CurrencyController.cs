using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Kerberos;
using Microsoft.IdentityModel.Tokens;
using System.Security.Policy;
using System.Xml;
using TCMB.BusinessLayer.ReadServices;
using TCMB.CoreLayer.Repositories.CurrencyRep;
using TCMB.EntityLayer.Concrate;
using TCMB.EntityLayer.PostEntites;

namespace TCMBProject.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ICurrencyReadRepository _currencyread;
        private readonly ICurrencyWriteRepository _currencywrite;
        private readonly IReadServices _read;

        public CurrencyController(ICurrencyReadRepository currencyread, ICurrencyWriteRepository currencywrite, IReadServices read)
        {
            _currencyread = currencyread;
            _currencywrite = currencywrite;
            _read = read;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var datas = _read.TcmbService();
            var Listdb = _currencyread.GetAll();
            List<Currency> curList = new();
            if (Listdb.Count() == 0)
            {
                foreach (var item in datas)
                {
                    curList.Add(new Currency
                    {
                        Code = item.Code,
                        banknoteSelling = item.banknoteSelling,
                        currencyName = item.currencyName,
                        banknoteBuying = item.banknoteBuying,
                        forexBuying = item.forexBuying,
                        forexSelling = item.forexSelling

                    });




                }
                _currencywrite.AddList(curList);
            }
            else
            {
                foreach (var item in Listdb)
                {
                    item.forexSelling = datas.FirstOrDefault(x => x.currencyName == item.currencyName).forexSelling;
                    item.forexBuying = datas.FirstOrDefault(x => x.currencyName == item.currencyName).forexBuying;
                    item.banknoteBuying = datas.FirstOrDefault(x => x.currencyName == item.currencyName).banknoteBuying;
                    item.banknoteSelling = datas.FirstOrDefault(x => x.currencyName == item.currencyName).banknoteSelling;


                    _currencywrite.Update(item);

                }

            }

            _currencywrite.SaveChanges();
            return View(datas);

        }


    }
}

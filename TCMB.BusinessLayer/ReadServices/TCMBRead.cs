using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TCMB.EntityLayer.Concrate;
using TCMB.EntityLayer.PostEntites;


namespace TCMB.BusinessLayer.ReadServices
{
    public class TCMBRead : IReadServices
    {
        public List<CurrencyPostModel> TcmbService()
        {

            XmlDocument document = new XmlDocument();
            string connection = "https://www.tcmb.gov.tr/kurlar/today.xml";

            document.Load(connection);

            List<CurrencyPostModel> curlist = new();

            foreach (XmlNode node in document.SelectNodes("/Tarih_Date/Currency"))
            {
                curlist.Add(new CurrencyPostModel
                {
                    Code = int.Parse(node["Unit"].InnerText),
                    banknoteSelling = Convert.ToDecimal("0" + node["BanknoteSelling"].InnerText.Replace(".", ",")),
                    currencyName = node["CurrencyName"].InnerText,
                    banknoteBuying = Convert.ToDecimal("0" + node["BanknoteBuying"].InnerText.Replace(".", ",")),
                    forexBuying = Convert.ToDecimal("0" + node["ForexBuying"].InnerText.Replace(".", ",")),
                    forexSelling = Convert.ToDecimal("0" + node["ForexSelling"].InnerText.Replace(".", ","))

                });


                
            }

            return curlist;
        }
    }
    }


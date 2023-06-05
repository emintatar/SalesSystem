using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.CentralBankService
{
    public class CbService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)5.28;
        }
    }
}

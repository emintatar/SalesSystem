using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters
{
    public class IsBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            return currencyRate.Price / (decimal)5.25;
        }
    }
}

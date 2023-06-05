using Business.Services.CentralBankService;
using Entities.Concrete;

namespace Business.Adapters
{
    public class CentralBankServiceAdapter : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            CbService cbService = new CbService();
            return cbService.ConvertRate(currencyRate);
        }
    }
}

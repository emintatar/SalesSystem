using Entities.Concrete;

namespace Business.Adapters
{
    public class IsBankServiceAdapter : IBankService
    {
        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            IsBankService centralBankService = new IsBankService();
            return centralBankService.ConvertRate(currencyRate);
        }
    }
}

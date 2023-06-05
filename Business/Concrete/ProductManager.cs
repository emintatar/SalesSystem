using Business.Abstract;
using Business.Adapters;
using Business.Handlers;
using Business.Services.FakeBankService;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IBankService _bankService;

        public ProductManager(IBankService bankService)
        {
            _bankService = bankService;
        }

        public void Sell(Product product, IPerson person)
        {
            decimal price;
            decimal convertedPrice;

            if (person is Student)
            {
                StudentCampaignHandler studentCampaignHandler = new StudentCampaignHandler();
                price = studentCampaignHandler.Calculate(product);
            }
            else if (person is Officer)
            {
                OfficerCampaignHandler officerCampaignHandler = new OfficerCampaignHandler();
                price = officerCampaignHandler.Calculate(product);
            }
            else
            {
                CustomerCampaignHandler customerCampaignHandler = new CustomerCampaignHandler();
                price = customerCampaignHandler.Calculate(product);
            }

            convertedPrice = _bankService.ConvertRate(new CurrencyRate
            {
                Currency = 1,
                Price = price
            });

            Console.WriteLine("Discount for our customer named " + person.FirstName + " " + person.LastName + ":" + price.ToString());
            Console.WriteLine("Exchange rate of the product:" + convertedPrice.ToString());
        }
    }
}

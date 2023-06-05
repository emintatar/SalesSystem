using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Handlers
{
    public class CustomerCampaignHandler : IPersonCampaignHandler
    { 
        // Default price for customers
        public decimal Calculate(Product product)
        {
            return product.ProductPrice;
        }
    }
}

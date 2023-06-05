
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Handlers
{
    public class OfficerCampaignHandler : IPersonCampaignHandler
    {
        // 20% discount for officers
        public decimal Calculate(Product product)
        {
            return product.ProductPrice * (decimal)0.80;
        }
    }
}

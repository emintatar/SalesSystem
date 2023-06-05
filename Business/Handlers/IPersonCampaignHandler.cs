using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Handlers
{
    public interface IPersonCampaignHandler
    {
        decimal Calculate(Product product);
    }
}

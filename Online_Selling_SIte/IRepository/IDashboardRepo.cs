using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.IRepository
{
   public interface IDashboardRepo
    {
        List<Product> GetSaleProduct();
        DashboardCards GetCards();
    }
}

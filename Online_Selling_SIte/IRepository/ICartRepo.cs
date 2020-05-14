using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.IRepository
{
   public interface ICartRepo
    {
        Cart GetbyProductId(int productid);
        bool InsertCart(Cart cart);
        List<CommanCart> GetAllCart();
        int GetTotalCartCount();
        string RemoveCart(int id);
        string RemoveCartProcess(Cart cart);
        List<Cart> GetByUser();
    }
}

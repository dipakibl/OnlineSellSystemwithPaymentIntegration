using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.IRepository
{
    public interface IProductRepo
    {
        string InsertProduct(Product product);
        List<Product> GetProduct();
        Product GetByeID(int id);

        bool UpdateProduct(Product product);

    }
}

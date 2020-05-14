using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly SiteDbContext _context;
        public ProductRepo(SiteDbContext context)
        {
            _context = context;
        }

        public Product GetByeID(int id)
        {
            try
            {
                return _context.Products.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetProduct()
        {
            try
            {
                return _context.Products.OrderByDescending(x => x.ProductName).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public string InsertProduct(Product product)
        {
            string msg;
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                msg = "Success";
            }
            catch (Exception)
            {
                msg = "Error";
                throw;
            }
            return msg;
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                _context.Update(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

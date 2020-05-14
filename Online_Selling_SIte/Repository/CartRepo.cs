using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.Repository
{
    public class CartRepo:ICartRepo
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        private readonly SiteDbContext _context;
        public CartRepo(SiteDbContext context, IHttpContextAccessor accessor)
        {
            _httpContextAccessor = accessor;
            _context = context;
        }

        public List<CommanCart> GetAllCart()
        {
            string userid = _session.GetString("UserId");
            List<Product> products = _context.Products.ToList();
            List<Cart> carts = _context.Carts.Where(x => x.UserId == Convert.ToInt32(userid)).ToList();

            var CartList = from p in products
                           join c in carts on p.Id equals c.ProductId
                           select new { p.Id, p.ProductName, p.Saleprice, p.Image, c.Qnt, p.Discription, c.Total,cartid = c.Id };
            List<CommanCart> commanCarts = CartList.Select(x => new CommanCart
            {
                productid = x.Id,
                Name = x.ProductName,
                saleprice = x.Saleprice,
                Image = x.Image,
                discription = x.Discription,
                total = x.Total,
                Qnt = x.Qnt,
                CartId = x.cartid
            }).ToList();


            return commanCarts;
        }

        public Cart GetbyProductId(int productid)
        {
            try
            {
              string userid =   _session.GetString("UserId");
                return _context.Carts.Where(a => a.ProductId == productid && a.UserId == Convert.ToInt32(userid)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool InsertCart(Cart cart)
        {
            try
            {
                _context.Carts.Add(cart);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
           
            
        }

        public int GetTotalCartCount()
        {
            try
            {
                string userid = _session.GetString("UserId");
               int count =  _context.Carts.Where(a => a.UserId == Convert.ToInt32(userid)).Count();
                return count;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string RemoveCart(int id)
        {
            try
            {
                Cart cart = _context.Carts.Find(id);
                Product product = _context.Products.Where(a => a.Id == cart.Id).FirstOrDefault();
                if (cart==null)
                {
                    return "Cart is not Found!";
                }
                if (product == null)
                {
                    return "Product is not found!";
                }
                int qnt = (product.Qnt + cart.Qnt);
                product.Qnt =  qnt;
                int total = (Convert.ToInt32(product.Price) * product.Qnt);
                product.Total = total.ToString();

                _context.Carts.Remove(cart);
                _context.Products.Update(product);
                _context.SaveChanges();
                return "Cart Remove Successfully.!";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string RemoveCartProcess(Cart cart)
        {
            try
            {
                _context.Carts.Remove(cart);
                _context.SaveChanges();
                return "Cart Remove SuccessFully.!";

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Cart> GetByUser()
        {
            try
            {
                string userid = _session.GetString("UserId");
                return _context.Carts.Where(a => a.UserId == Convert.ToInt32(userid)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

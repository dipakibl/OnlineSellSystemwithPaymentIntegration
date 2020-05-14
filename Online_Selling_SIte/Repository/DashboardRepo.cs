using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.Repository
{
    public class DashboardRepo: IDashboardRepo
    {
        private readonly SiteDbContext _context;
        public DashboardRepo(SiteDbContext context)
        {
            _context = context;
        }

        public DashboardCards GetCards()
        {
            try
            {
                var Order = _context.Orders.Where(a => a.Status != "Complete").ToList();
                var CompleteOrder = _context.Orders.Where(a => a.Status == "Complete").ToList();
                var users = _context.Users.ToList();
                var product = _context.Products.ToList();
                DashboardCards cards = new DashboardCards();
                cards.TotalOrders = Order.Count().ToString();
                cards.TotalComplateOrder = CompleteOrder.Count().ToString();
                cards.TotalUsers = users.Count().ToString();
                cards.TotalProduct = product.Count().ToString();
                return cards;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public  List<Product> GetSaleProduct()
        {
            return _context.Products.Where(x => x.Qnt > 0).ToList();
        }

       
    }
}

using Microsoft.AspNetCore.Http;
using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Selling_SIte.Repository
{
    public class OrderRepo : IOrderRepo
    {
        private readonly SiteDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public OrderRepo(SiteDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }
        public Order GetbyId(int id)
        {
            try
            {
                return _context.Orders.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Order> GetOrder()
        {
            try
            {
                string userid = _session.GetString("UserId");
                return _context.Orders.Where(a => a.UserId == Convert.ToInt32(userid)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<CommanCart> GetMyOrders()
        {
            string userid = _session.GetString("UserId");
            List<Product> product = _context.Products.ToList();
            List<Order_Detail> order_detail = _context.Order_Details.ToList();
            var orderlist = from p in product
                            join d in order_detail on p.Id equals d.ProductId
                            select new { p.Id, p.ProductName, p.Saleprice, p.Image, d.Qnt, p.Discription, total = d.Price.ToString(), d.OrderId };
            List<CommanCart> commancart = orderlist.Select(x => new CommanCart
            {
                productid = x.Id,
                Name = x.ProductName,
                saleprice = x.Saleprice,
                OrderId = x.OrderId,
                Image = x.Image,
                discription = x.Discription,
                total = x.total,
                Qnt = x.Qnt
            }).OrderByDescending(x => x.OrderId).ToList();

            return commancart;
        }
        public List<CommanCart> GetOrderDetail()
        {
            try
            {
                List<Order> order = _context.Orders.Where(a=>a.Status != "Complete").ToList();
                List<Order_Detail> order_Details = _context.Order_Details.ToList();
                List<Product> products = _context.Products.ToList();

                var orderlist = from p in products
                                join d in order_Details on p.Id equals d.ProductId
                                join o in order on d.OrderId equals o.Id
                                select new
                                {
                                    product_Name = p.ProductName,
                                    Sale_Price = p.Saleprice,
                                    Qnt = d.Qnt,
                                    orderid = o.Id,
                                    total = d.Price.ToString()
                                };
                List<CommanCart> commanCarts = orderlist.Select(x => new CommanCart
                {
                    Name = x.product_Name,
                    saleprice = x.Sale_Price,
                    Qnt = x.Qnt,
                    total = x.total,
                    OrderId = x.orderid
                    

                }).OrderByDescending(x => x.OrderId).ToList();
                return commanCarts;
            }
            catch (Exception)
            {

                throw;
            }
        }
      public  List<CommanCart> OrderHistory()
        {
            try
            {
                List<Order> order = _context.Orders.Where(a => a.Status == "Complete").ToList();
                List<Order_Detail> order_Details = _context.Order_Details.ToList();
                List<Product> products = _context.Products.ToList();

                var orderlist = from p in products
                                join d in order_Details on p.Id equals d.ProductId
                                join o in order on d.OrderId equals o.Id
                                select new
                                {
                                    product_Name = p.ProductName,
                                    Sale_Price = p.Saleprice,
                                    Qnt = d.Qnt,
                                    orderid = o.Id,
                                    total = d.Price.ToString()
                                };
                List<CommanCart> commanCarts = orderlist.Select(x => new CommanCart
                {
                    Name = x.product_Name,
                    saleprice = x.Sale_Price,
                    Qnt = x.Qnt,
                    total = x.total,
                    OrderId = x.orderid


                }).OrderByDescending(x => x.OrderId).ToList();
                return commanCarts;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Order> GetAllOrder()
        {
            try
            {
                return _context.Orders.OrderByDescending(a => a.Id).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Order> GetComplateOrder()
        {
            try
            {
                return _context.Orders.Where(a => a.Status == "Complete").ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Order InsertOrder(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return order;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public Order_Detail InsertOrderDetail(Order_Detail order_Detail)
        {
            try
            {
                _context.Order_Details.Add(order_Detail);
                _context.SaveChanges();
                return order_Detail;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateOrder(Order order)
        {
            try
            {
                _context.Orders.Update(order);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

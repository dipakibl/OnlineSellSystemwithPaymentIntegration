using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;

namespace Online_Selling_SIte.Controllers.AdminPanel
{
    public class OrdersController : Controller
    {
        private readonly IOrderRepo _orderRepo;
        public OrdersController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public ActionResult Order()
        {
            try
            {
                List<CommanCart> commanCarts = _orderRepo.GetOrderDetail();
                ViewBag.Orders = _orderRepo.GetAllOrder();
                return View(commanCarts);

            }
            catch (Exception)
            {

                throw;
            }
          
        }
        [HttpPost]
        public ActionResult Order(string status, string[] orderid)
        {
            try
            {
                for (int i = 0; i < orderid.Length; i++)
                {
                    int id = Convert.ToInt32(orderid[i]);
                    Order order = _orderRepo.GetbyId(id);
                    order.Status = status;
                    _orderRepo.UpdateOrder(order);

                }

                return RedirectToAction("Order");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult OrderHistory()
        {
            try
            {
                List<CommanCart> commanCarts = _orderRepo.OrderHistory();
                ViewBag.Orders = _orderRepo.GetComplateOrder();
                return View(commanCarts);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
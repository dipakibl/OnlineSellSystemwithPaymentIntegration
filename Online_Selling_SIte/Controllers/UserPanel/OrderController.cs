using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;
using Stripe;

namespace Online_Selling_SIte.Controllers.UserPanel
{
    public class OrderController : Controller
    {
        private readonly ILoginRepo _loginRepo;
        private readonly IOrderRepo _orderRepo;
        private readonly ICartRepo _cartRepo;
        private readonly IProductRepo _productRepo;

        public OrderController(ILoginRepo loginRepo, IOrderRepo orderRepo, ICartRepo cartRepo, IProductRepo productRepo)
        {
            _orderRepo = orderRepo;
            _loginRepo = loginRepo;
            _cartRepo = cartRepo;
            _productRepo = productRepo;
        }
        public IActionResult ProceedOrder()
        {
            User user = _loginRepo.GetUser();
            
            
            return View(user);
        }
        [HttpPost]
        public ActionResult ProceedOrder(User user)
        {
            try
            {
                int Payamount = 0;
                string userId = HttpContext.Session.GetString("UserId");
                List<Cart> carts = _cartRepo.GetByUser();
                List<Models.Product> products = _productRepo.GetProduct();
                // Set Pay Amount
                for (int i = 0; i < carts.Count; i++)
                {
                    Payamount = Payamount + Convert.ToInt32(carts[i].Total);
                }

                //Order 

                Models.Order order = new Models.Order();
                order.Name = user.Name;
                order.Address = user.Address;
                order.State = user.State;
                order.City = user.City;
                order.PinCode = user.Pincode;
                order.Email = user.Email;
                order.Phone = user.Phone;
                order.CreateDate = DateTime.Now;
                order.Status = "InProgress";
                order.UserId = Convert.ToInt32(userId);
                order.PayAmount = Payamount.ToString();

                _orderRepo.InsertOrder(order);

                //Order Detail
                foreach (var item in carts)
                {
                    Order_Detail order_Detail = new Order_Detail();
                    order_Detail.OrderId = order.Id;
                    order_Detail.Qnt = item.Qnt;
                    order_Detail.Price = Convert.ToInt32(item.Total);
                    order_Detail.ProductId = item.ProductId;
                    _orderRepo.InsertOrderDetail(order_Detail);
                    _cartRepo.RemoveCartProcess(item);
                }
                return RedirectToAction("PayPayment", new { OrderId = order.Id });
                // bool result = _orderRepo.PlaceOrder(user);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public ActionResult PayPayment(int OrderId)
        {
            Models.Order order = _orderRepo.GetbyId(OrderId);
            payModel payModel = new payModel()
            {
                Id = order.Id,
                Total = order.PayAmount
            };
            return View(payModel);
        }
        [HttpPost]
        public ActionResult PayPayment(payModel payModel)
        {
            Models.Order order = _orderRepo.GetbyId(payModel.Id);
            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = order.Email,
                SourceToken = payModel.Token,
            });

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = Convert.ToInt32(payModel.Total),//charge in cents
                Description = "Online Shopping",
                Currency = "INR",
                CustomerId = customer.Id,
                ReceiptEmail = order.Email,
                Metadata = new Dictionary<string, string>()
                {
                    {"OrderId",order.Id.ToString() },
                    {"Name",order.Name },
                    {"Phone",order.Phone },
                    {"Address",order.Address + order.City+'-'+order.PinCode + order.State}
                }
            });

            if (charge.Status == "succeeded")
            {

                order.PaymentStatus = charge.Status;
                order.Payment_TransactionId = charge.BalanceTransactionId;
                order.ReceiptUrl = charge.ReceiptUrl;
                _orderRepo.UpdateOrder(order);
               
                return RedirectToAction("Paymentreceipt", new {url = order.ReceiptUrl});
            }
            payModel pasyModel = new payModel()
            {
                Id = order.Id,
                Total = order.PayAmount
            };
            // further application specific code goes here

            return View(pasyModel);
        }
        public ActionResult Paymentreceipt(string url)
        {
            ViewBag.url = url;
            return View();
        }
        public ActionResult MyOrders()
        {
            try
            {
                List<CommanCart> commanCart = _orderRepo.GetMyOrders();
                ViewBag.order = _orderRepo.GetOrder();
                return View(commanCart);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
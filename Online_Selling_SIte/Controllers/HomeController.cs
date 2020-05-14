using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;
using Stripe;

namespace Online_Selling_SIte.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SiteDbContext _Context;
        private readonly ICartRepo _cartrepo;
        public HomeController(ILogger<HomeController> logger,SiteDbContext context,ICartRepo cartRepo)
        {
            _logger = logger;
            _Context = context;
            _cartrepo = cartRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Charge(string stripeEmail, string stripeToken)
        {
            var customers = new CustomerService();
            var charges = new ChargeService();

            var customer = customers.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                SourceToken = stripeToken,
            });

            var charge = charges.Create(new ChargeCreateOptions
            {
                Amount = 500,//charge in cents
                Description = "Sample Charge",
                Currency = "INR",
                CustomerId = customer.Id
            });

            if (charge.Status == "succeeded")
            {
                string BalanceTransactionId = charge.BalanceTransactionId;
                return View(); 
            }

            // further application specific code goes here

            return View();
        }

        public ActionResult Tracker()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult ViewProductDetail(int id)
        {
            Models.Product product = _Context.Products.Find(id);
            return View(product);
        }
        public ActionResult totalcart()
        {
         List<CommanCart> comman =  _cartrepo.GetAllCart();
            return View(comman);
        }
        public ActionResult actionResult()
        {
            return View();
        }
    }
}

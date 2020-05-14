using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;

namespace Online_Selling_SIte.Controllers.UserPanel
{
    public class UserDashboardController : Controller
    {
        private readonly IDashboardRepo _dashboardRepo;
        private readonly ICartRepo _cartRepo;
         public UserDashboardController(IDashboardRepo dashboardRepo,ICartRepo cartRepo)
        {
            _dashboardRepo = dashboardRepo;
            _cartRepo = cartRepo;
        }
        public IActionResult Index()
        {
           List<Product> product = _dashboardRepo.GetSaleProduct();
            ViewBag.Product = product;
            return View(product);
        }
        public JsonResult CartCount()
        {
            var data = _cartRepo.GetTotalCartCount();
            return Json(data);
        }
    }
}
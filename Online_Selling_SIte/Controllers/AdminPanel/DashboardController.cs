using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Online_Selling_SIte.IRepository;

namespace Online_Selling_SIte.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepo _dashboardRepo;
        public DashboardController(IDashboardRepo dashboardRepo)
        {
            _dashboardRepo = dashboardRepo;
        }
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CartsCount()
        {
            var data = _dashboardRepo.GetCards();
            return Json(data);
        }
    }

}
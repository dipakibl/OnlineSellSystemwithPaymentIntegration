using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;

namespace Online_Selling_SIte.Controllers.UserPanel
{
    public class UserLoginController : Controller
    {
        private readonly ILoginRepo _loginRepo;
        private readonly ICartRepo _cartRepo;
        public UserLoginController(ILoginRepo loginRepo,ICartRepo cartRepo)
        {
            _loginRepo = loginRepo;
            _cartRepo = cartRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string email,string password)
        {
            try
            {
                Online_Selling_SIte.Models.User user = _loginRepo.UserLogin(email, password);
                if (user != null)
                {
                    HttpContext.Session.SetString("UserName", user.Name);
                    HttpContext.Session.SetString("UserId", user.Id.ToString());
                    int cartcount = _cartRepo.GetTotalCartCount();
                    HttpContext.Session.SetInt32("TotalCart", cartcount);
                    return RedirectToAction("Index", "UserDashboard");
                }
                else
                {
                    ViewBag.invalid = "Invalid Email & Password.!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

        public ActionResult UserRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserRegister(User user, string Isactive)
        {
            try
            {
                bool active;
                if (Isactive != null)
                {
                    active = true;
                }
                else
                {
                    active = false;
                }
                user.IsActive = active;
                user.Created = DateTime.Now;
                _loginRepo.Register(user);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("UserName");
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;

namespace Online_Selling_SIte.Controllers
{
    public class AdminLoginController : Controller
    {
        private readonly ILoginRepo _loginrepo;
        public AdminLoginController(ILoginRepo loginRepo)
        {
            _loginrepo = loginRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin user)
        {
            try
            {
                Admin data = _loginrepo.AdminLogin(user.Email, user.Password);
                if (data != null)
                {
                    HttpContext.Session.SetString("AdminName", data.Name);
                    return RedirectToAction("Index", "Dashboard");
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
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminName");
            return RedirectToAction("Index");
        }
    }
}
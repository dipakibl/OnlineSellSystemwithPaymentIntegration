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
    public class CartController : Controller
    {
        private readonly IProductRepo _productRepo;
        private readonly ICartRepo _cartRepo;
        public CartController(IProductRepo productRepo, ICartRepo cartRepo)
        {
            _productRepo = productRepo;
            _cartRepo = cartRepo;
        }
        public ActionResult AddToCart(int id)
        {
            Product product = _productRepo.GetByeID(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult AddToCart(int quantity, int Product_Id)
        {

            if (HttpContext.Session.GetString("UserName") == null)
            {
                return RedirectToAction("Index", "UserLogin");
            }
            Cart data = _cartRepo.GetbyProductId(Product_Id);
            if (data != null)
            {
                ViewBag.Already = "Product Already Added in Cart.";
                Product product = _productRepo.GetByeID(Product_Id);
                return View(product);
            }
            var prod = _productRepo.GetByeID(Product_Id);
            // Add cart
            Cart cart = new Cart();
            string UserId = HttpContext.Session.GetString("UserId");
            cart.UserId = Convert.ToInt32(UserId);
            cart.ProductId = Product_Id;
            cart.Qnt = quantity;
            int Totalcart = (cart.Qnt) * (Convert.ToInt32(prod.Saleprice));
            cart.Total = Totalcart.ToString();

            _cartRepo.InsertCart(cart);
            // Update Product
            int total;
            prod.Qnt = (prod.Qnt) - (cart.Qnt);
            total = Convert.ToInt32(prod.Price) * prod.Qnt;
            prod.Total = total.ToString();

            _productRepo.UpdateProduct(prod);

            return RedirectToAction("MyCart");
        }

        public ActionResult MyCart()
        {
            int GrandTotal = 0;
            List<CommanCart> carts = _cartRepo.GetAllCart();
            for (int i = 0; i < carts.Count; i++)
            {
                int total = Convert.ToInt32(carts[i].total);
                GrandTotal = GrandTotal + total;
            }
            ViewBag.GrandTotal = GrandTotal;

            return View(carts);
        }

        public ActionResult RemoveCart(int id)
        {
            try
            {
                string cart = _cartRepo.RemoveCart(id);
                ViewBag.Message = cart;
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("MyCart");

        }

    }
}
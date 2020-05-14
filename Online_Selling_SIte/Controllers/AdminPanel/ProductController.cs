using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Selling_SIte.IRepository;
using Online_Selling_SIte.Models;

namespace Online_Selling_SIte.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IProductRepo _productRepo;

        public ProductController(IHostingEnvironment appEnvironment,IProductRepo productRepo)
        {
            _appEnvironment = appEnvironment;
            _productRepo = productRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Product tbl_Product ,string isactive)
        {
            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {
                    var file = Image;
                    //There is an error here
                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "ProductImages");
                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                             file.CopyToAsync(fileStream);

                            //Add product in database
                            bool Isactive;
                            int total;
                            if (isactive==null)
                            {
                                Isactive = false;
                            }
                            else
                            {
                                Isactive = true;
                            }
                            total = Convert.ToInt32(tbl_Product.Price) * tbl_Product.Qnt;

                            tbl_Product.Image = fileName;
                            tbl_Product.IsActive = Isactive;
                            tbl_Product.Total = total.ToString();
                            tbl_Product.UploadDate = DateTime.Now;
                            string msg = _productRepo.InsertProduct(tbl_Product);
                            ViewBag.Message = msg;
                        }
                    }
                }
            }
            ModelState.Clear();

            return View();
        }

        public ActionResult ProductView()
        {
            var data = _productRepo.GetProduct();
            return View(data);
        }

        public ActionResult ManageStock()
        {
          List<Product> data = _productRepo.GetProduct();
            return View(data);
        }

        [HttpPost]
        public ActionResult ManageStock(string[] Id, IFormCollection fc)
        {
            try
            {
                string sale = fc["SalePrice"];
                int qnt  = Convert.ToInt32(fc["qnt"]);
                List<Product> data = _productRepo.GetProduct();
                for (int i = 0; i < Id.Length; i++)
                {
                    int productid = Convert.ToInt32(Id[i]);
                    Product product = _productRepo.GetByeID(productid);

                    if (qnt != 0)
                    {
                        product.Qnt = qnt;
                        int total = Convert.ToInt32(product.Price) * product.Qnt;
                        product.Total = total.ToString();
                    }
                    if (sale != null)
                    {
                        product.Saleprice = sale;
                    }
                   
                    _productRepo.UpdateProduct(product);
                }

                return View(data);
            }
            catch (Exception)
            {

                throw;
            }
            


        }



        }
}
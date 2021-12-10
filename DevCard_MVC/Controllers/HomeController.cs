using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماسی")
        };

        [HttpGet]
        public IActionResult Contact()
        {
            var contact = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(contact);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");

            if (!ModelState.IsValid)
            {
                ViewData["error"] = "اطلاعات وارد شده صحیح نیست. لطفا مجددا تلاش کنید";
                return View(model);
            }

            //return RedirectToAction("Index");
            ModelState.Clear();
            //model.Email = "";
            //model.Name = "";
            //model.Message = "";
            //model.Service = 0;
            ViewData["success"] = "پیغام شما با موفقیت ارسال شد. با تشکر";
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

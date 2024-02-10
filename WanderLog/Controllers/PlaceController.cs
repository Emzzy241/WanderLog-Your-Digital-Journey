using Microsoft.AspNetCore.Mvc;
using WanderLog.Models;

namespace WanderLog.Models
{
    public class PlaceController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/places/show1")]
        public ActionResult Show1()
        {
            return View();
        }

        [HttpGet("/places/show2")]
        public ActionResult Show2()
        {
            return View();
        }

        [HttpGet("/places/show3")]
        public ActionResult Show3()
        {
            return View();
        }

        
    }
}
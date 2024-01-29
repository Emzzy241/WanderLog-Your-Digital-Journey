using Microsoft.AspNetCore.Mvc;
using WanderLog.Models;

namespace WanderLog.Models
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
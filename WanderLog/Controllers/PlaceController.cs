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
    }
}
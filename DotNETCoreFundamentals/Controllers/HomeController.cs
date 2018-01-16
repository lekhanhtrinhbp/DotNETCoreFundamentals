using DotNETCoreFundamentals.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNETCoreFundamentals.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant { Id = 1, Name = "Scott's pizza place" };
            return View(model);
        }
    }
}

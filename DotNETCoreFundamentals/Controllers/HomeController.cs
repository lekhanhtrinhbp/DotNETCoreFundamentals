using DotNETCoreFundamentals.Models;
using DotNETCoreFundamentals.Services;
using DotNETCoreFundamentals.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotNETCoreFundamentals.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMesageOfTheDay();

            return View(model);
        }
    }
}

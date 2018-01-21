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

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel restaurant)
        {
            var newRestaurant = new Restaurant();
            newRestaurant.Name = restaurant.Name;
            newRestaurant.Cuisine = restaurant.Cuisine;

            newRestaurant = _restaurantData.Add(newRestaurant);

            return RedirectToAction(nameof(Details), new { id = newRestaurant.Id });
        }
    }
}

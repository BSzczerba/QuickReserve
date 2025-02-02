using Microsoft.AspNetCore.Mvc;
using QuickReserve.Application.Services.Interfaces;

namespace QuickReserve.Presentation.Controllers
{
    public class QuickReserveController : Controller
    {
        private readonly IRestaurantService restaurantService;

        public QuickReserveController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }
        public async Task<IActionResult> Index()
        {
            var restaurants = await restaurantService.GetAll();
            return View(restaurants);
        }
    }
}

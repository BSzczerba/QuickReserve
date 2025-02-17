using Microsoft.AspNetCore.Components.Forms;
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

        [Route("QuickReserve/{encodedName}/Details")]
        public async Task<IActionResult> Details(string encodedName)
        {
            var dto = await restaurantService.GetByEncodedName(encodedName);
            return View(dto);
        }
        public async Task<IActionResult> Index()
        {
            var restaurants = await restaurantService.GetAll();
            return View(restaurants);
        }
    }
}

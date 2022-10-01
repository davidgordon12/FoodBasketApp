using Microsoft.AspNetCore.Mvc;

using FoodBasketApp.Entities;
using FoodBasketApp.Models;
using FoodBasketApp.Services;

namespace FoodBasketApp.Controllers
{
    public class FoodController : Controller
    {
        public FoodController(FoodService foodService)
        {
            _foodService = foodService;
        }

        [Route("Items/{category?}")]
        public IActionResult Items(string category = "All")
        {
            ItemViewModel itemViewModel = new();
            if(category == null || category == "All")
            {
                itemViewModel.Items = _foodService.GetAllFoodItems();
                return View("Items", itemViewModel);
            }
            else
            {
                itemViewModel.Items = _foodService.GetFoodItemsByCategory(category);
                return View("Items", itemViewModel);
            }

        }

        public IActionResult CreateItem(ItemViewModel itemViewModel)
        {
            return RedirectToAction("Items");
        }

        private FoodService _foodService;
    }
}

using FoodBasketApp.Entities;

namespace FoodBasketApp.Models
{
    public class ItemViewModel
    {
        public FoodItem? Item { get; set; }
        public ICollection<FoodItem>? Items { get; set; }
    }
}

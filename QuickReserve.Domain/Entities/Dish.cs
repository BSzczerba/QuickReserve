namespace QuickReserve.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Price { get; set; } = default!;
        public int RestaurantId { get; set; } = default!;
        public Restaurant Restaurant { get; set; } = default!;
    }
}
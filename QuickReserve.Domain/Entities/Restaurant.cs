
namespace QuickReserve.Domain.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? TypeOfRestaurant { get; set; }
        public string EncodedName { get; private set; } = default!;
        public RestaurantContancDetails ContancDetails { get; set; } = default!;
        public virtual List<Dish> Dishes { get; set; } = new();
        public void EncodeName() => EncodedName = Name.ToLower().Replace(" ", "-") + $"-{ContancDetails.City!.ToLower()}-{ContancDetails.Street!.ToLower()}";
    }
}

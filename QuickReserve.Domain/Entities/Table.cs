
namespace QuickReserve.Domain.Entities
{
    public class Table
    {
        public int Id { get; set; }       
        public int Capacity { get; set; }
        public string? TableNumber { get; set; }
        public int RestaurantId { get; set; } = default!;
        public Restaurant Restaurant { get; set; } = default!;
        public virtual List<Reservation> Reservations { get; set; } = new();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReserve.Domain.Entities
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public RestaurantContancDetails ContancDetails { get; set; } = default!;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickReserve.Application.Dtos
{
    public class RestaurantDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? TypeOfRestaurant { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? EncodedName { get; set; }
    }
}

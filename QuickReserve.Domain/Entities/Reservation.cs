using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace QuickReserve.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public TimeSpan ReservationTime { get; set; }
        [EnumDataType(typeof(ReservationStatus))]
        public ReservationStatus Status { get; set; } = ReservationStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int TableId { get; set; } = default!;
        public Table Table { get; set; } = default!;
        public string? UserId { get; set; }
        public IdentityUser? User { get; set; }
    }

    public enum ReservationStatus
    {
        Pending,
        Confirmed,
        Canceled
    }
}

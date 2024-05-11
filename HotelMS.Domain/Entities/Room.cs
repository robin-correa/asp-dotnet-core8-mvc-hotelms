using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using HotelMS.Domain.Enums;

namespace HotelMS.Domain.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Hotel")]
        public int HotelId { get; set; } // Foreign key referencing Hotel entity

        [ForeignKey("RoomCategory")]
        public int CategoryId { get; set; }
        public string RoomNumber { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Available;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        // Navigation property for the hotel
        public virtual Hotel Hotel { get; set; }
        public virtual RoomCategory Category { get; set; }
    }
}

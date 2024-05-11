using System.ComponentModel.DataAnnotations;

namespace HotelMS.Domain.Entities
{
    public class RoomCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalCapacity { get; set; }
        public int TotalAdult { get; set; }
        public int TotalChild { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

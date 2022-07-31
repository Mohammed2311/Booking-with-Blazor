using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HotelRoomDTO

    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Occupancy { get; set; }
        [Range(1,2000 )]
        [Required]
        public double RegularRate { get; set; }
        public string Details { get; set; }
        public string SqFt { get; set; }
        public  IEnumerable<HotelRoomImageDTO> HotelRoomImages { get; set; }
        public  List<string> ImageUrls { get; set; }
        [Required]
        public double TotalAmount { get; set; }
        [Required]
        public int TotalDays { get; set; }

    }
}

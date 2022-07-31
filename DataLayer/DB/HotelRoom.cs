using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DB
{
    public class HotelRoom
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Occupancy { get; set; }
        public double RegularRate { get; set; }
        public string Details { get; set; }
        public string SqFt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; }
        public DateTime UpdateTime { get; set; }
        public  IEnumerable<HotelRoomImage> HotelRoomImages { get; set; }

    }
}

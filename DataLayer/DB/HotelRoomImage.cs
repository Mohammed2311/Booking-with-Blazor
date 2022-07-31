using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DB
{
    public class HotelRoomImage
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string ImgUrl { get; set; }
        [ForeignKey("RoomId")]
        public  HotelRoom  HotelRoom{ get; set; }

    }
}

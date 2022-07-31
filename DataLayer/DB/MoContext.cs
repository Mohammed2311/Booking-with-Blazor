using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DB
{
    public class MoContext:IdentityDbContext
    {
        public MoContext(DbContextOptions<MoContext> optios):base(optios)
        {
            

        }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<HotelRoomImage> HotelRoomImages { get; set; }
        public DbSet<HotelAmenity> HotelAmenities { get; set; }
        public DbSet<RoomOrderDetails> RoomOrderDetails { get; set; }
    }
}

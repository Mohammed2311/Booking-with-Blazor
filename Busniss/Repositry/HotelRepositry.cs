using AutoMapper;
using Busniss.Interfaces;
using DataLayer.DB;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniss.Repositry
{
    public class HotelRepositry : IHotelRep
    {
        private readonly MoContext mo;
        private readonly IMapper mapper;
        public HotelRepositry(MoContext mo1 , IMapper map)
        {
            mapper = map;
            mo = mo1;
        }
        public async Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoom)
        {
            var data = mapper.Map<HotelRoom>(hotelRoom);
            data.CreatedBy = "";
            data.CreatedTime = DateTime.Now;
            var mo123 =await mo.HotelRooms.AddAsync(data);
            await mo.SaveChangesAsync();

            return mapper.Map<HotelRoomDTO>(mo123.Entity);
            
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetAll()
        {
            var data = await mo.HotelRooms.Include(x=>x.HotelRoomImages).ToListAsync();
            var mapped = mapper.Map<IEnumerable<HotelRoomDTO>>(data);
            return mapped;


        }

        public async Task<HotelRoomDTO> GetHotelRoom(int id)
        {
            var room =await mo.HotelRooms.Include(x=>x.HotelRoomImages).FirstOrDefaultAsync(x=>x.Id==id);
            var data = mapper.Map<HotelRoomDTO>(room);

            return data;
        }

        public async Task<HotelRoomDTO> IsHotelExists(string name)
        {
            var room = await mo.HotelRooms.FirstOrDefaultAsync(roo=>roo.Name ==name);
            var data = mapper.Map<HotelRoomDTO>(room);
            return data;
        }

        public  async Task<HotelRoomDTO> UpdateHotelRoom(HotelRoomDTO hotelRoom)
        {
            var id = hotelRoom.Id;
            var room =await mo.HotelRooms.FindAsync(id);
            room.UpdateBy = "";
            room.Name = hotelRoom.Name;
            room.Occupancy = hotelRoom.Occupancy;
            room.RegularRate = hotelRoom.RegularRate;
            room.Details = hotelRoom.Details;
            room.UpdateTime = DateTime.Now;
            room.SqFt = hotelRoom.SqFt;
            await mo.SaveChangesAsync();
            var mapped = mapper.Map<HotelRoomDTO>(room);
            return mapped;
        }
        public async Task Delete(int id)
        {
            var room = await mo.HotelRooms.FindAsync(id);

            var roomImages = await mo.HotelRoomImages.Where(x => x.RoomId == id).ToListAsync();
            mo.HotelRoomImages.RemoveRange(roomImages);
            mo.HotelRooms.Remove(room);
            await mo.SaveChangesAsync();
        }
    }
}

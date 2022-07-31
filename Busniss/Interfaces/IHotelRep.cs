using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniss.Interfaces
{
    public interface IHotelRep
    {
        public Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoom);
        public Task<HotelRoomDTO> UpdateHotelRoom(HotelRoomDTO hotelRoom);
        public Task<HotelRoomDTO> GetHotelRoom(int id);
        public Task Delete(int id);
        public Task<IEnumerable<HotelRoomDTO>> GetAll();
        public Task<HotelRoomDTO> IsHotelExists(string name);
    }
}

using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Client.Services.IServices
{
    public interface IHotelRoomService
    {
        public Task<IEnumerable<HotelRoomDTO>> GetRooms(string checkInDate, string checkOutDate);
        public Task<HotelRoomDTO> GetRoom(int id , string checkInDate, string checkOutDate);
    }
}

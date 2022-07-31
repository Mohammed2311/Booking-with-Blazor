using Blazor_Client.Services.IServices;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor_Client.Services
{
    public class HotelRoomService : IHotelRoomService
    {
        private readonly HttpClient client;
        public HotelRoomService(HttpClient client)
        {
            this.client = client;
        }
        public async Task<HotelRoomDTO> GetRoom(int id, string checkInDate, string checkOutDate)
        {
            var response = await client.GetAsync($"api/hotelroom/{id}?checkInDate={checkInDate}&checkoutdate={checkOutDate}");
            if (response.IsSuccessStatusCode)
            {
                var content =await response.Content.ReadAsStringAsync();
                var room = JsonConvert.DeserializeObject<HotelRoomDTO>(content);
                return room;
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetRooms(string checkInDate, string checkOutDate)
        {
            var response = await client.GetAsync($"api/hotelroom?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            var content = await response.Content.ReadAsStringAsync();
            //var rooms = JsonConvert.DeserializeObject<IEnumerable<HotelRoomDTO>>(content);
            var rooms = JsonConvert.DeserializeObject<IEnumerable<HotelRoomDTO>>(content);

            return rooms;

        }
    }
}

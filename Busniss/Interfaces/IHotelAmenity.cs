using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniss.Interfaces
{
    public interface IHotelAmenity
    {
        public Task<HotelAmenityDTO> CreateHotelAmenity(HotelAmenityDTO hotelAmenity);
        public Task<HotelAmenityDTO> UpdateHotelAmenity(HotelAmenityDTO hotelRoom);

        public Task<int> Delete(int id);
        public Task<HotelAmenityDTO> GetHotelAmenity(int id);
        public Task<IEnumerable<HotelAmenityDTO>> GetAll();
        public Task<HotelAmenityDTO> IsAmenityExists(string name);




    }
}

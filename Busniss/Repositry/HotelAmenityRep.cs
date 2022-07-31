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
    public class HotelAmenityRep : IHotelAmenity
    {
        private readonly MoContext mo;
        private readonly IMapper map;
        public HotelAmenityRep(MoContext mo1, IMapper map)
        {
            this.map = map;
            mo = mo1;
        }
        public async Task<HotelAmenityDTO> CreateHotelAmenity(HotelAmenityDTO hotelAmenity)
        {
            var data = map.Map<HotelAmenity>(hotelAmenity);
            data.CreatedBy = "";
            data.CreatedDate = DateTime.Now;

            var data1 = await mo.HotelAmenities.AddAsync(data);
            await mo.SaveChangesAsync();
            var hotel = map.Map<HotelAmenityDTO>(data1.Entity);
            return hotel;
        }

        public async Task<int> Delete(int id)
        {
            var amenity =await mo.HotelAmenities.FindAsync(id);

            if (amenity!=null)
            {
                mo.HotelAmenities.Remove(amenity);
                return await mo.SaveChangesAsync();
            }
            return 0;

        }

        public async Task<IEnumerable<HotelAmenityDTO>> GetAll()
        {
            var data = await mo.HotelAmenities.ToListAsync();
            return map.Map<IEnumerable<HotelAmenityDTO>>(data);
        }

        public async Task<HotelAmenityDTO> GetHotelAmenity(int id)
        {
            var amenity =await mo.HotelAmenities.FindAsync(id);
            if (amenity==null)
            {
                return null;
            }
            return map.Map<HotelAmenityDTO>(amenity);
        }

        public async Task<HotelAmenityDTO> IsAmenityExists(string name)
        {
            var amenity = await mo.HotelAmenities.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());

            return map.Map<HotelAmenityDTO>(amenity);
        }

        public async Task<HotelAmenityDTO> UpdateHotelAmenity(HotelAmenityDTO hotelRoom)
        {
            var data = await mo.HotelAmenities.FindAsync(hotelRoom.Id);
            data.UpdatedBy = "";
            data.Name = hotelRoom.Name;
            data.IconStyle = hotelRoom.IconStyle;
            data.Description = hotelRoom.Description;
            data.UpdatedDate = DateTime.Now;
            await mo.SaveChangesAsync();
            return map.Map<HotelAmenityDTO>(data);
        }
    }
}

using AutoMapper;
using DataLayer.DB;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniss.mapper
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<HotelRoomDTO, HotelRoom>();
            CreateMap<HotelRoom, HotelRoomDTO>();

            CreateMap<HotelRoomImageDTO, HotelRoomImage>();
            CreateMap<HotelRoomImage, HotelRoomImageDTO>();

            CreateMap<HotelAmenityDTO, HotelAmenity>();
            CreateMap<HotelAmenity,HotelAmenityDTO>();
            CreateMap<RoomOrderDetails, RoomOrderDetailsDTO>();
            CreateMap<RoomOrderDetailsDTO, RoomOrderDetails>();

        }
    }
}

using AutoMapper;
using Busniss.Interfaces;
using Common;
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
    public class RoomDetailsRep : IRoomDetailsRep
    {
        private readonly IMapper map;
        private readonly MoContext mo;

        public RoomDetailsRep(IMapper map , MoContext mo)
        {
            this.map = map;
            this.mo = mo;
        }

        public async Task<RoomOrderDetailsDTO> Create(RoomOrderDetailsDTO details)
        {
            details.CheckInDate = details.CheckInDate.Date;
            details.CheckOutDate = details.CheckOutDate.Date;
            var data = map.Map<RoomOrderDetails>(details);
            data.Status = SD.Status_Pending;
            var mo1 = await mo.RoomOrderDetails.AddAsync(data);
            await mo.SaveChangesAsync();
            var roomDet = map.Map<RoomOrderDetailsDTO>(mo1.Entity);
            return roomDet;
               
        }

        public async Task<IEnumerable<RoomOrderDetailsDTO>> GetAllRoomOrderDetails()
        {
            var roomDetails = await mo.RoomOrderDetails.Include(x=>x.HotelRoom).ToListAsync();
            return map.Map<IEnumerable<RoomOrderDetailsDTO>>(roomDetails);


        }

        public async Task<RoomOrderDetailsDTO> GetRoomOrderDetail(int roomOrderId)
        {
            var roomDetails = await mo.RoomOrderDetails.Include(x=>x.HotelRoom).ThenInclude(u => u.HotelRoomImages).FirstOrDefaultAsync(x => x.Id== roomOrderId);

            var roomDTO = map.Map<RoomOrderDetailsDTO>(roomDetails);
            roomDTO.HotelRoomDto.TotalDays = roomDTO.CheckOutDate.Subtract(roomDTO.CheckInDate).Days;
            return roomDTO;

        }

        public async Task<bool> IsRoomBooked(int RoomOrderId, DateTime checkInDate, DateTime checkOutDate)
        {
            var status = false;
            var bookedRoom = await mo.RoomOrderDetails.Where(x => x.RoomId == RoomOrderId && x.IsPaymentSuccessful&&
            //checkInDate less than  Room checkOut Date and checkIn Date bigger than Room check In Date
            (checkInDate.Date <x.CheckOutDate.Date && checkInDate.Date>x.CheckInDate.Date
            ||

            //checkOutDate bigger than roomcheckInDate and checkin date less than room checkInDate
            checkOutDate.Date>x.CheckInDate.Date &&checkInDate.Date<x.CheckInDate.Date
            )).FirstOrDefaultAsync();
            if (bookedRoom!=null)
            {
                status = true;
            }
            
            return status;
        }

        public Task<RoomOrderDetailsDTO> MarkPaymentSuccessful(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderStatus(int RoomOrderId, string status)
        {
            throw new NotImplementedException();
        }
    }
}

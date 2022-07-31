using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Client.Services.IServices
{
    public interface IOrderDetailsService
    {
        public Task<RoomOrderDetailsDTO> SaveRoomOrderDetails(RoomOrderDetailsDTO details);
        public Task<RoomOrderDetailsDTO> MarkPaymentSucessfully(RoomOrderDetailsDTO details);

    }
}

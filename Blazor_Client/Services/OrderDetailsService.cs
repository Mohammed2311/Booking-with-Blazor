using Blazor_Client.Services.IServices;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor_Client.Services
{
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly HttpClient client;

        public OrderDetailsService(HttpClient client)
        {
            this.client = client;
        }
        public Task<RoomOrderDetailsDTO> MarkPaymentSucessfully(RoomOrderDetailsDTO details)
        {
            throw new NotImplementedException();
        }

        public Task<RoomOrderDetailsDTO> SaveRoomOrderDetails(RoomOrderDetailsDTO details)
        {
            throw new NotImplementedException();
        }
    }
}

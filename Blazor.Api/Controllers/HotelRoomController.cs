using Busniss.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelRoomController : ControllerBase
    {
        private readonly IHotelRep hotelRep;
        
        public HotelRoomController(IHotelRep hotelRep)
        {
            this.hotelRep = hotelRep;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRooms(string checkInDate, string checkOutDate)
        {
            var data =await hotelRep.GetAll();

            return Ok(data);            
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetById(int? id)
        {
            if (id==null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "Bad Request",
                    StatusCode = StatusCodes.Status400BadRequest,
                    ErrorMessage = "invalid Room Id"
                });
            }
            var room = await hotelRep.GetHotelRoom(id.Value);
            if (room==null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title="Bad Request",
                    StatusCode=StatusCodes.Status404NotFound,
                    ErrorMessage="invalid Room Id"
                });
            }
            return Ok(room);
        }
    }
}

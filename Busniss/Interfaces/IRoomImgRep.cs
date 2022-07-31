using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniss.Interfaces
{
    public interface IRoomImgRep
    {
        public Task<int> CreateHotelRoomImage(HotelRoomImageDTO img);
        public Task<int> DealeteHotelRoomImageByImgId(int imgId);
        public Task<int> DealeteHotelRoomImageByImgName(string imgName);
        public Task<int> DealeteHotelRoomImageByRoomId(int roomId);
        public Task<IEnumerable<HotelRoomImageDTO>> GetHotelRoomImages(int roomId);

    }
}

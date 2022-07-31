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
    public class RoomImageRep : IRoomImgRep
    {
        private readonly MoContext mo;
        private readonly IMapper map;

        public RoomImageRep(MoContext mo , IMapper map)
        {
            this.mo = mo;
            this.map = map;
        }
        public async Task<int> CreateHotelRoomImage(HotelRoomImageDTO img)
        {
            var img1 = map.Map<HotelRoomImage>(img);
            await mo.HotelRoomImages.AddAsync(img1);
          var mm =   await mo.SaveChangesAsync();
            return mm;
            

        }

        public async Task<int> DealeteHotelRoomImageByImgId(int imgId)
        {
            var img =await mo.HotelRoomImages.FindAsync(imgId);
            mo.HotelRoomImages.Remove(img);
            return await mo.SaveChangesAsync();
        }

        public async Task<int> DealeteHotelRoomImageByImgName(string imgName)
        {
            var data = await mo.HotelRoomImages.FirstOrDefaultAsync(x => x.ImgUrl.ToLower() == imgName.ToLower());
            mo.HotelRoomImages.Remove(data);
            return await mo.SaveChangesAsync();
        }

        public async Task<int> DealeteHotelRoomImageByRoomId(int roomId)
        {
            var images = await mo.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();
            mo.HotelRoomImages.RemoveRange(images);
            return await mo.SaveChangesAsync();
        }

        public async Task<IEnumerable<HotelRoomImageDTO>> GetHotelRoomImages(int roomId)
        {
            var images = await mo.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();
            var mappedImgs = map.Map<IEnumerable<HotelRoomImageDTO>>(images);
            return mappedImgs;
        }
    }
}

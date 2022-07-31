using BlazorServer.Services.IServices;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Services.Service
{
    public class FileUploader : IFileUploader
    {
        private readonly IWebHostEnvironment webHost;
        private readonly IHttpContextAccessor httpContext;

        public FileUploader(IWebHostEnvironment webHost , IHttpContextAccessor httpContext)
        {
            this.webHost = webHost;
            this.httpContext = httpContext;
        }
        public bool DeleteFile(string fileName)
        {
            try
            {
                var path = $"{webHost.WebRootPath}\\RoomImgs\\{fileName}";
                if (File.Exists(path))
                {
                    File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
        }

        public async Task<string> UploadFile(IBrowserFile file)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(file.Name);
                var fileName = Guid.NewGuid().ToString() + fileInfo.Extension;
                var folderDirectory = $"{webHost.WebRootPath}\\RoomImgs";
                var path = Path.Combine(webHost.WebRootPath , "RoomImgs"  ,fileName);
                var memstreem =new MemoryStream();

                await file.OpenReadStream().CopyToAsync(memstreem);
                if (!Directory.Exists(folderDirectory))
                {
                    Directory.CreateDirectory(folderDirectory);
                }
                await using (var fs =new  FileStream(path , FileMode.Create ,FileAccess.Write))
                {
                    memstreem.WriteTo(fs);
                }
                var url = $"{httpContext.HttpContext.Request.Scheme}:://{httpContext.HttpContext.Request.Host.Value}/";
                var fullPath = $"{url}RoomImgs/{fileName}";

                return fullPath;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

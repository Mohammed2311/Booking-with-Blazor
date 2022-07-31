using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Services.IServices
{
    public interface IFileUploader
    {
        Task<string> UploadFile(IBrowserFile file);
        bool DeleteFile(string fileName);

    }
}

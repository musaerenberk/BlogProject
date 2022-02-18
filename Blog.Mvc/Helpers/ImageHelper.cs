using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Blog.Entities.Dtos;
using Blog.Mvc.Helpers.Abstract;
using Blog.Shared.Utilities.Extensions;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.Mvc.Helpers
{
    public class ImageHelper:IImageHelper
    {
        private readonly IWebHostEnvironment _env;
        private readonly string _wwwroot;

        public ImageHelper(IWebHostEnvironment env)
        {
            _env = env;
            _wwwroot = _env.WebRootPath;
        }

        public async Task<IDataResult<UploadedImageDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName)
        {
            
            
            string fileExtension = Path.GetExtension(pictureFile.FileName);
            DateTime dateTime = DateTime.Now;
            string fileName = $"{userName}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
            var path = Path.Combine($"{wwwroot}/img", fileName);
            await using (var stream = new FileStream(path, FileMode.Create))
            {
                await pictureFile.CopyToAsync(stream);
            }

            return fileName; 
        }
    }
}

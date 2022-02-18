using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Blog.Entities.Dtos;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.Mvc.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<IDataResult<UploadedImageDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName);
    }
}

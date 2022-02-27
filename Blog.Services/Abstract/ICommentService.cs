using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.Services.Abstract
{
    public interface ICommentService
    {
        Task<IDataResult<int>> Count();
        Task<IDataResult<int>> CountByNonDeleted();
    }
}

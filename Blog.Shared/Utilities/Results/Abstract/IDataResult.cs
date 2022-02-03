using Blog.Shared.Utilities.Results.ComlexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T>:IResult
    {
        public T Data { get; }
        ResultStatus ResultStatus { get; }
    }
}

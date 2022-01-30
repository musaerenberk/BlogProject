using Blog.Shared.Utilities.Results.ComlexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStates { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}

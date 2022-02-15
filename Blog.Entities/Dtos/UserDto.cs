using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;
using Blog.Shared.Entities.Abstract;

namespace Blog.Entities.Dtos
{
    public class UserDto:DtoGetBase
    {
        public User User { get; set; }
    }
}

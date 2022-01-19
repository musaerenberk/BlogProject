using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Concrete;
using Blog.Shared.Data.Abstract;
namespace Blog.Data.Abstract
{
    public interface IRoleRepository : IEntityRepository<Role>
    {
    }
}

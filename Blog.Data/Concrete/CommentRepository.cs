using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blog.Data.Abstract;
using Blog.Entities.Concrete;
using Blog.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;


namespace Blog.Data.Concrete
{
    public class CommentRepository:EfEntityRepositoryBase<Comment>,ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context)
        {
        }
    }
}

using Blog.Data.Abstract;
using Blog.Data.Concrete;
using Blog.Data.Concrete.EntityFramework.Contexts;
using Blog.Services.Abstract;
using Blog.Services.Concerete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BlogContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            return serviceCollection;
        }
    }
}

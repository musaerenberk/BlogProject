﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Blog.Entities.Concrete;
using Blog.Mvc.Areas.Admin.Models;

namespace ProgrammersBlog.Mvc.Areas.Admin.ViewComponents
{
    public class UserMenuViewComponent:ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public UserMenuViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public ViewViewComponentResult Invoke()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            return View(new UserViewModel
            {
                User = user
            });
        }
    }
}

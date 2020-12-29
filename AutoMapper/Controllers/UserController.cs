using AutoMapper;
using AutoMapping.Models;
using AutoMapping.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapping.Controllers
{
    public class UserController : Controller
    {
        public IMapper Mapper { get; }

        public UserController(IMapper mapper)
        {
            Mapper = mapper;
        }

        public IActionResult Index()
        {
            var user = GetUserDetails();

            var userViewModel = Mapper.Map<UserViewModel>(user);
            //var mappedUser = Mapper.Map<User>(userViewModel);

            return View(userViewModel);
        }

        private static User GetUserDetails()
        {
            return new User
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@gmail.com",
                Address = new Address { Country = "USA"}
            };
        }
    }
}

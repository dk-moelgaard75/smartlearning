using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TicTacToe2.Controllers
{
    public class UserRegistrationController : Controller
    {
        private Services.IUserServices _userService;
        public UserRegistrationController(Services.IUserServices userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Models.UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                await _userService.RegisterUser(userModel);
                return Content($"User {userModel.FirstName} {userModel.LastName} has been registered sucessfully");
            }
            return View(userModel);
        }
    }
}
﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using IdentityChatEmailNight.Entities;
using IdentityChatEmailNight.Models;

namespace IdentityChatEmailNight.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Profile", "Profile");
            }

            model.ErrorMessage = "Kullanıcı adı veya şifre yanlış";
            return View(model);
        }

    }
}

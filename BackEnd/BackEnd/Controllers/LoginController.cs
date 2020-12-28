﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.DAL;
using BackEnd.Models;
using BackEnd.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or Password wrong!");
                return View();
            }
            if (user.isDelete)
            {
                ModelState.AddModelError("", "This account blocked!");
                return View();
            }

            Microsoft.AspNetCore.Identity.SignInResult inResult =
                await _signInManager.PasswordSignInAsync(user, login.Password, true, true);

            if (inResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Try after a few minutes");
                return View(login);
            }

            if (!inResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password wrong!!!");
                return View(login);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signup(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();
            AppUser newUser = new AppUser()
            {
                Name = register.Name,
                Surname = register.Surname,
                UserName = register.Username,
                Email = register.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);

            if (!identityResult.Succeeded)
            {
                return View();
            }

            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Serwis.Models;

namespace Serwis.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<Worker> _userManager;
        private SignInManager<Worker> _signInManager;
        private ServiceContext _serviceContext;

        public AccountController(UserManager<Worker> userManager, SignInManager<Worker> signInManager, ServiceContext service)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _serviceContext = service;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterWorker registerUser)
        {
            if (ModelState.IsValid)
            {
                Worker user = new Worker
                {
                    UserName = registerUser.Email,
                    Email = registerUser.Email,
                    Name = registerUser.Name,
                    Surename = registerUser.Surename,
                    PhoneNumber = registerUser.PhoneNumber,
                    City = registerUser.City,
                    Zip_Code = registerUser.Zip_Code,
                    Adress = registerUser.Adress,
                };
                IdentityResult result = await _userManager.CreateAsync(user, registerUser.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, err.Description);
                }

            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> Login(LoginWorker loginViewModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser { Email = loginViewModel.Email, UserName = loginViewModel.Email };

                Microsoft.AspNetCore.Identity.SignInResult identityResult = await _signInManager.PasswordSignInAsync(user.Email, loginViewModel.Password, false, false);


                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Niepoprawny login lub hasło.");
                }

            }
            return View();
        }

    }
}

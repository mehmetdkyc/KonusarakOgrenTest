using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Business.Concrete;
using KonusarakOgrenTest.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KonusarakOgrenTest.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IETicaretServices eTicaretServices;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            eTicaretServices = new ETicaretServices();
        }
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            var model = eTicaretServices.GetProducts();
            TempData["SuccessMes"] = "Login successfully!";
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> LogOut()
        {
            //SignOutAsync is Extension method for SignOut    
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //Redirect to home page    
            return LocalRedirect("/");
        }
    }
}
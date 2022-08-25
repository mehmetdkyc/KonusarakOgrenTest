using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Business.Concrete;
using KonusarakOgrenTest.Enums;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KonusarakOgrenTest.Controllers
{
    public class LoginController : Controller
    {
        private IETicaretServices eTicaretServices;
        public LoginController()
        {
            eTicaretServices = new ETicaretServices();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            //Login işlemi burada yapılıyor eğer kullanıcı varsa onu cookie atıyor yoksa login ekranında sabit kalıyor. Kullanıcı yok ise /Home diyerek gitmenizi engelleyen mantık
            //cookie kontrol ediyor startup.cste.
            var userCheck = eTicaretServices.GetAllUsers().FirstOrDefault(x => x.Username == userName && x.Password == password);
            if (userCheck != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userName)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                TempData["Role"] = Enum.GetName(typeof(RolesEnum), userCheck.RoleId);
                return RedirectToAction("Index", "Home");
            }
            TempData["ErrorMes"] = "Username or password is wrong!";
            return RedirectToAction("Index");
        }
    }
}

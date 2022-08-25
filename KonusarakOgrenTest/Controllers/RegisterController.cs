using KonusarakOgren.Business.Abstract;
using KonusarakOgren.Business.Concrete;
using KonusarakOgren.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgrenTest.Controllers
{
    public class RegisterController : Controller
    {
        private IETicaretServices eTicaretServices;

        public RegisterController()
        {
            eTicaretServices = new ETicaretServices();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAccount(string userName, string password, int roleId)
        {
            //formdan dönen verilerle kayıt oluşturma.
            Users _user = new Users()
            {
                Username = userName,
                Password = password,
                RoleId = roleId
            };
            try
            {
                eTicaretServices.CreateUser(_user);
                TempData["SuccessMes"] = "Register successfully!";
            }
            catch (Exception)
            {
                TempData["SuccessMes"] = "Register failed!";
                return RedirectToAction("Index", "Login");
            }
            return RedirectToAction("Index", "Login");
        }
    }
}

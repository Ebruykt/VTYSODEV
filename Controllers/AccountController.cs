using Microsoft.AspNetCore.Mvc;

namespace VTYSODEV.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, int Password)
        {
            
            // Örnek: Sabit kullanıcı doğrulama
            if (Username == "admin" && Password == 1234)
            {
                return RedirectToAction("Index", "Home"); // Giriş başarılıysa anasayfaya yönlendir
            }

            ViewData["ErrorMessage"] = "Geçersiz kullanıcı adı veya şifre.";
            return View();
        }
    }
}

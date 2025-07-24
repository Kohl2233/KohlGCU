using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Controllers
{
    public class UserController : Controller
    {
        static UserCollection users = new UserCollection();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(LoginViewModel loginViewModel)
        {
            var result = users.CheckCredentials(loginViewModel.Username, loginViewModel.Password);

            if (result > 0)
            {
                var user = users.GetUserById(result);
                return View("ProcessLogin", user);
            } 
            else
            {
                return View("LoginFailure");
            }
        }
    }
}

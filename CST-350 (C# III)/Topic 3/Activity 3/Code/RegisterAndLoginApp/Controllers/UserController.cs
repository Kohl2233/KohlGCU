using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Filters;
using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Controllers
{
    public class UserController : Controller
    {
        //static UserCollection users = new UserCollection();
        UsersDAO users = new UsersDAO();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(string UserName, string password)
        {
            UserCollection users = new UserCollection();
            users.GenerateUserData();

            UserModel userData = new UserModel();
            userData.Id = 1;
            userData.Username = UserName;
            userData.SetPassword(password);

            if (users.CheckCredentials(UserName, password) == 1)
            {
                string userJson = ServiceStack.Text.JsonSerializer.SerializeToString(userData);
                HttpContext.Session.SetString("User", userJson);
                return View("ProcessLogin", userData);
            }
            else
            {
                return View("LoginFailure", userData);
            }
        }

        [SessionCheckFilter]
        public IActionResult MembersOnly()
        {
            return View();
        }

        [SessionCheckFilter]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("User");
            return View("Index");
        }

        [SessionCheckFilter]
        public IActionResult AdminOnly()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        public IActionResult ProcessRegister(RegisterViewModel registerViewModel)
        {
            UserModel user = new UserModel();
            user.Username = registerViewModel.Username;
            user.SetPassword(registerViewModel.Password);
            user.Groups = "";
            foreach (var group in registerViewModel.Groups)
            {
                if (group.IsSelected)
                {
                    user.Groups += group.GroupName + ",";
                }
            }
            user.Groups = user.Groups.TrimEnd(',');
            users.AddUser(user);

            return View("Index");
        }
    }
}

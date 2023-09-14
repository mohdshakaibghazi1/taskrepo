using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
            {
            new User() { UserId=1,UserName="sam",UserPwd="sam@123",UserEmail="sam@yahoo.com"},
            new User() { UserId=2,UserName="jam",UserPwd="jam@123",UserEmail="jam@yahoo.com"}
            };
        public IActionResult Index()
        {

            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        { if(ModelState.IsValid)
            {
                users.Add(model);
            }
            return RedirectToAction("Index");
        }
    }
}

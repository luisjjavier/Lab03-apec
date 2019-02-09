using Lab02.Models;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public string  Create(User user)
        {
            return "Done";
        }
    }
}
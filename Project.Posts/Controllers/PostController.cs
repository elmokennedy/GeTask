using System.Web.Mvc;

namespace Project.Posts.Controllers
{
    public class PostController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
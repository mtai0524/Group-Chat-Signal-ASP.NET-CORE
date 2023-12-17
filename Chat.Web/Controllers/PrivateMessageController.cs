using Microsoft.AspNetCore.Mvc;

namespace Chat.Web.Controllers
{
    public class PrivateMessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

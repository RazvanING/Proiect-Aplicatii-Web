using Microsoft.AspNetCore.Mvc;

namespace CasaDiscuri.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index() => View();
    }
}

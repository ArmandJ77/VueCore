using Microsoft.AspNetCore.Mvc;

namespace VueCore.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index() => View();
  }
}

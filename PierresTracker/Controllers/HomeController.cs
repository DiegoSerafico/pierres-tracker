using Microsoft.AspNetCore.Mvc;
using PierresTracker.Models;

namespace PierresTracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomePage() { return View(); }

 
  }
}
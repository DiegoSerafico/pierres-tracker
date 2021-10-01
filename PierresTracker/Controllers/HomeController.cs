using Microsoft.AspNetCore.Mvc;
using Vendor.Models;

namespace PierresTracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomePage() { return View(); }

 
  }
}
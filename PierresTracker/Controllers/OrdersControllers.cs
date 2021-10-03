using Microsoft.AspNetCore.Mvc;
using PierresTracker.Models;
using System.Collections.Generic;
using System;

namespace PierresTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.GetAll()[vendorId - 1];
      return View(vendor);
    }
  }
}
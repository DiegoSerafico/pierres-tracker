using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresTracker.Models;

namespace PierresTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index", "Home");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Vendor vendor = Vendor.GetAll()[vendorId - 1];
      return View(vendor);
    }

    [HttpPost("/vendors/{vendorId}/order")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, float orderPrice, string orderDate)
    {
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      Vendor vendor = Vendor.GetAll()[vendorId - 1];
      vendor.Orders.Add(newOrder);
      return View("Show", vendor);
    }
  }
}
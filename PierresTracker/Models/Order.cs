using System;
using System.Collections.Generic;

namespace PierresTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string OrderDescription { get; set; }
    public float OrderPrice { get; set; }
    public string OrderDate { get; set; }

    public Order(string title, string description, float price, string date)
    {
      Title = title;
      OrderDescription = description;
      OrderPrice = price;
      OrderDate = date;
    }
  }
}
using Nancy;
using System.Collections.Generic;
using System;
using Addresses.Objects;


namespace AddressNamespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Get["/add"] = _ =>
      {
        return View["addAddress.cshtml"];
      };

      Get["/list"] = _ =>
      {
        var printOut = Contact.getAll();
        return View["addressList.cshtml", printOut];
      };

      Post["/postList"] = _ =>
      {
        Contact newAddress = new Contact(Request.Form["name"], Request.Form["address"], Request.Form["phone"]);
        var printOut = Contact.getAll();
        return View["addressList.cshtml", printOut];
      };

      Get["/deleteAll"] = _ =>
      {
        Contact.clearAll();
        return View["cleared.cshtml"];
      };
    }
  }
}

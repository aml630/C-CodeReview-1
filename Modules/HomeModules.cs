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
        return View["AddressViews/index.cshtml"];
      };

      Get["/add"] = _ =>
      {
        return View["AddressViews/addAddress.cshtml"];
      };

      Get["/list"] = _ =>
      {
        var printOut = Contact.getAll();
        return View["AddressViews/addressList.cshtml", printOut];
      };

      Post["/post"] = _ =>
      {
        Contact newAddress = new Contact(Request.Form["name"], Request.Form["address"], Request.Form["phone"]);
        return View["AddressViews/newContact.cshtml", newAddress];
      };

      Get["/deleteAll"] = _ =>
      {
        Contact.clearAll();
        return View["AddressViews/cleared.cshtml"];
      };

      Get["/deleteOne/{variable}"] = parameters =>
      {
        Contact.Find(parameters.variable).clearOne();
        return View["AddressViews/index.cshtml"];
      };
    }
  }
}

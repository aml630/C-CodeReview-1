using Nancy;
using System.Collections.Generic;
using System;
using Addresses.Objects;
using Person.Objects;


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

      Get["/profileForm/{variable}"] = parameters =>
      {
        var current = Contact.Find(parameters.variable);
        return View["PersonViews/profileForm.cshtml", current];
      };

      Post["/profile/{variable}"] = parameters =>
      {
        Dictionary<string, object> CompleteProfile = new Dictionary <string, object>();
        Profile newPerson = new Profile (Request.Form["activity"], Request.Form["pic"]);
        var currentAddress = Contact.Find(parameters.variable);
        CompleteProfile.Add("newInfo", newPerson);
        CompleteProfile.Add("oldInfo", currentAddress);



        return View["PersonViews/profile.cshtml", CompleteProfile];
      };

    }
  }
}

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
        return View["addressList.cshtml"];
      };

      Post["/postList"] = _ =>
      {


        return View["addressList.cshtml"];
      };

    }
  }
}

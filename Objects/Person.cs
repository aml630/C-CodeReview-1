using System.Collections.Generic;
using System;

namespace Person.Objects
{
  public class Profile

  {
    ///Create Private variables
    private string _activity;
    private string _pic;

    ///Create constructor function for Address

    public Profile(string activity, string pic)
    {
      _activity = activity;
      _pic = pic;
    }

  //Get functions
  public string getActivity()
  {
    return _activity;
  }
  public string getPic ()
  {
    return _pic;
  }



  }
}

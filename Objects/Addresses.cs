using System.Collections.Generic;
using System;

namespace Addresses.Objects
{
  public class Contact
  {
    ///Create Private variables and list
    private string _name;
    private string _address;
    private int _phone;
    private static List<Contact> _addressBook = new List<Contact> {};
    ///Create constructor function for Address
    //Add object to List upon object obstantiation

    public Contact(string name, string address, int phone)
    {
      _name = name;
      _address = address;
      _phone = phone;
      _addressBook.Add(this);
    }

    //Get function for name private variables
    public string getName()
    {
      return _name;
    }

    //Get function for address private variable
    public string getAddress()
    {
      return _address;
    }
    //Get function for address private variable
    //Must convert to string before printing out
    public string getPhone()
    {
      string PhoneString = _phone.ToString();
      return PhoneString;
    }
    //Get full AddressBook List

    public static List<Contact> getAll()
    {
      return _addressBook ;
    }
    ///clear List

    public static void clearAll()
    {
      _addressBook.Clear();
    }




  }
}

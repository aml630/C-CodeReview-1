using System.Collections.Generic;
using todoNamespace;
namespace Todo.Objects
{
  public class Task
  {
      private string _taskMaster;
      private static List <string> _superlist = new List <string> {};
      /////Constructor function
      public Task (string taskMaster)
      {
        _taskMaster = taskMaster
      }
      ////List All function
      public static List<string> GetAll()
      {
        return _superlist;
      }
      /// Save function
      public static Save()
      {
        _superlist.Add(_taskMaster)
      }





  }
}

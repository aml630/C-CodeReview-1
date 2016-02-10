using System.Collections.Generic;
using System;

namespace Todo.Objects
{
  public class Task
  {
      private string _taskMaster;
      private int _id;
      private static List<Task> _superlist = new List<Task> {};
      /////Constructor function
      public Task (string taskMaster)
      {
        _taskMaster = taskMaster;
        _superlist.Add(this);
        _id = _superlist.Count;

      }
      //// Get taskmaster function
      public string GettaskMaster()
      {
        return _taskMaster;
      }
      // Get Taskmaster ID function
      public int GetId()
      {
        return _id;
      }
      ////List All function
      public static List<Task> GetAll()
      {
        return _superlist;
      }
      public static Task Find(int searchId)
      {
        return _superlist[searchId-1];
      }
  }
}

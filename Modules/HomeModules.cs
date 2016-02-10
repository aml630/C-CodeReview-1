using Nancy;
using System.Collections.Generic;
using Todo.Objects;
using System;

namespace todoNamespace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        return View ["add_view.cshtml"];
      };
      Get["/task/{id}"] = parameters => {
        Task newTask = Task.Find(parameters.id);
        return View["/task.cshtml", newTask];
      };
      Post["/view_all"] =_=> {
        Task newTask = new Task(Request.Form["add"]);
        // newTask.Save();
        List<Task> _superlist = Task.GetAll();
        return View ["view_all.cshtml", _superlist];
      };
      Get["/view_all_posts"] =_=> {
        List<Task> _superlist = Task.GetAll();
        return View ["view_all_posts.cshtml", _superlist];
      };
    }
  }
}

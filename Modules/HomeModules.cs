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
      Get["/tasks/{id}"] = parameters => {
        Task task = Task.Find(parameters.id);
        return View["/task.cshtml", task];
};
      Post["/view_all"] =_=> {
        Task newTask = new Task(Request.Form["add"]);
        // newTask.Save();
        List<Task> _superlist = Task.GetAll();
        return View ["view_all.cshtml", _superlist];
      };
    }
  }
}

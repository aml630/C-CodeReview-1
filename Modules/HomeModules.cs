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
      Get["/"] = _ => View["add_task.cshtml"];

      Get["/view_tasks"] = _ => {
        List<string> allTasks = Task.GetAll();
        return View["view_tasks.cshtml", allTasks];
      };

      Post["/new_task_added"] = _ => {
        Task newTask = new Task(Request.Form["new-task"]);
        newTask.Save();
        Console.WriteLine(newTask);
        return View["new_task_added.cshtml", newTask];
      };

      Post["/tasks_cleared"] = _ => {
        Task.ClearAll();
        return View ["add_task.cshtml"];
      };

    }
  }
}

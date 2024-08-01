using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDo.App.Tasks.Services;
using ToDo.App.Tasks.ViewModels;
using ToDo.Models;
using ToDo.Views.Home.ViewModels;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskService _taskService;
        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel();
            var taskList = _taskService.GetAll();
            foreach (var task in taskList) {
                var newTask = new Views.Home.ViewModels.TaskViewModel()
                {
                    Id = task.Id,
                    Title = task.Title,
                    Priority = task.Priority,
                    Description = task.Description,
                };
                model.Tasks.Add(newTask);
            }
            return View(model);
        }

        public IActionResult Delete(DeleteViewModel model)
        {
            var task = new DeleteTaskViewModel();
            task.Id = model.Id;
            _taskService.Delete(task);
            return RedirectToAction(nameof(Index));
        }
      
 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

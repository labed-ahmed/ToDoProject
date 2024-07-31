using Microsoft.AspNetCore.Mvc;
using ToDo.App.Tasks.Services;
using ToDo.App.Tasks.ViewModels;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newTask = new CreateTaskViewModel();
                newTask.Title = model.Title;
                newTask.Description = model.Description;
                _taskService.Create(newTask);
            }
            
            return View(model);
        }


    }
}

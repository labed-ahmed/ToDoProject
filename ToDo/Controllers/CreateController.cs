using Microsoft.AspNetCore.Mvc;
using ToDo.App.Tasks.Services;
using ToDo.App.Tasks.ViewModels;
using ToDo.Views.Create.ViewModels;

namespace ToDo.Controllers
{
    public class CreateController : Controller
    {
        private readonly ITaskService _taskService;

        public CreateController(ITaskService taskService)
        {
            _taskService = taskService;
        }

		public IActionResult Index()
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
                newTask.Priority = model.Priority;
                _taskService.Create(newTask);
            }
            
            return RedirectToAction("Index","Home");
        }


    }
}

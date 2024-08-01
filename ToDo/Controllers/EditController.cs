using Microsoft.AspNetCore.Mvc;
using ToDo.App.Tasks.Services;
using ToDo.App.Tasks.ViewModels;
using ToDo.Views.Edit.ViewModels;

namespace ToDo.Controllers
{
    public class EditController : Controller
    {

        private readonly ITaskService _taskService;
        public EditController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index(int id)
        {
			var model = new GetTaskViewModel()
            {
                Id=id,
            };
            var taskDb = _taskService.Get(model);
            var task = new EditViewModel()
            {
                Id = model.Id,
                Description = taskDb.Description,
                Title = taskDb.Title,
            };
            return View(task);
        }

        [HttpPost]
        public IActionResult Update(EditViewModel model)
        {
            var task = new UpdateTaskViewModel()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
            };

            _taskService.Update(task);

			return RedirectToAction(nameof(Index), "Home");
		}
    }
}

using System.Collections.Generic;
using System.Linq;
using ToDo.App.Tasks.ViewModels;
using ToDo.BusinessObjects;

namespace ToDo.App.Tasks.Services
{
    public class TaskService : ITaskService
    {
        private readonly Context _context;
        public TaskService(Context context) {
            _context = context;
        }
        public void Create(CreateTaskViewModel model)
        {
            var task = new Task()
            {
                Description = model.Description,
                Title = model.Title,
                SubTasks = model.SubTasks,
                Priority = model.Priority,
            };
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void Delete(DeleteTaskViewModel model)
        {
            
            var task = _context.Tasks.Where(x => x.Id == model.Id).FirstOrDefault();
            if (task == null)
            {
                return;
            }
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }

        public TaskViewModel Get(GetTaskViewModel model)
        {
            var taskDB = _context.Tasks.Where(x => x.Id == model.Id).FirstOrDefault();
            var task = new TaskViewModel()
            {
                Id = taskDB.Id,
                Title = taskDB.Title,
                Description = taskDB.Description,
            };
            return task;
        }

        public List<TaskViewModel> GetAll()
        {
            var tasks = _context.Tasks.ToList();
            var taskList = new List<TaskViewModel>();
            foreach (var task in tasks)
            {
                taskList.Add(new TaskViewModel()
                {
                    Id = task.Id,
                    Description = task.Description,
                    Priority = task.Priority,
                    Title = task.Title,

                });
            }

            return taskList;
        }

        public void Update(UpdateTaskViewModel model)
        {
            var task = _context.Tasks.Where(x => x.Id == model.Id).FirstOrDefault();
            task.Title = model.Title;
            task.Description = model.Description;
            _context.SaveChanges();

        }
    }
}

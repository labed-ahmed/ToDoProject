using Microsoft.AspNetCore.Http.HttpResults;
using System.Collections.Generic;
using ToDo.App.Tasks.ViewModels;

namespace ToDo.App.Tasks.Services
{
    public interface ITaskService
    {
        public void Create(CreateTaskViewModel model);

        public void Update(UpdateTaskViewModel model);

        public void Delete(DeleteTaskViewModel model);

        public TaskViewModel Get(GetTaskViewModel model);

        public List<TaskViewModel> GetAll();
    }
}

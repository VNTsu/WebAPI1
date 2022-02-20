using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI1.Model;
using WebAPI1.Data;
using WebAPI1.Service;

namespace WebAPI1.Service
{
    public interface IServiceTask
    {
        void AddTask(TaskModel model);
        TaskModel GetTaskById(int id);
        List<TaskModel> GetAllTask();
        void DeleteTask (int id);
        void EditTask(TaskModel model );
        void DeleteMultipleTasks(List<int> ids); 
        void AddMultipleTasks(List<TaskModel> tasks);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI1.Model;
using WebAPI1.Data;

namespace WebAPI1.Service
{
  public class ServiceTask : IServiceTask
    {
        public void AddTask(TaskModel item)
        {
            TaskData.task.Add(item);
        }

        public TaskModel GetTaskById(int id)
        {
            return TaskData.task.FirstOrDefault(m => m.Id == id);
        }
        public List<TaskModel> GetAllTask()
        {
            return TaskData.task.ToList();
        }
        public void DeleteTask(int id)
        {
            var item = TaskData.task.FirstOrDefault(m => m.Id == id);

            if (item != null)
            {
                TaskData.task.Remove(item);
            }
        }
        public void EditTask(TaskModel task)
        {
            var item = TaskData.task.FirstOrDefault(m => m.Id == task.Id);

            if (item != null)
            {
                item.Title = task.Title;
                item.Completed = task.Completed;
            }
        }

        public void DeleteMultipleTasks(List<int> ids)
        {
            var Tasks = TaskData.task.Where(task => ids.Contains(task.Id));

            if (Tasks.Any())
            {
                TaskData.task.RemoveRange(0,Tasks.Count());
            }
        }

        public void AddMultipleTasks(List<TaskModel> tasks)
        {
            foreach (var item in tasks)
            {
                TaskData.task.Add(item);
            }
        }
    }
}
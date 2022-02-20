using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI1.Controllers;
using WebAPI1.Model;
using WebAPI1.Service;
using WebAPI1.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI1.Controllers
{
   [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private IServiceTask _taskService;
        public TaskController(IServiceTask taskService)
        {
            _taskService = taskService;
        }

        [HttpPost]
        public void AddTask([FromBody] TaskModel taskModel)
        {
            _taskService.AddTask(taskModel);
        }

        [HttpGet("/AllTask")]
        public List<TaskModel> GetAllTask()
        {
            return _taskService.GetAllTask();
        }

        [HttpGet("/TaskByID")]
        public TaskModel GetTaskById(int id)
        {
            return _taskService.GetTaskById(id);
        }

        [HttpDelete]
        public void DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
        }

        [HttpPut]
        public void EditTask([FromBody] TaskModel model)
        {
            _taskService.EditTask(model);
        }

        [HttpDelete("/DeleteMultiTask")]
        public void DeleteMultiTask(List<int> ids)
        {
            _taskService.DeleteMultipleTasks(ids);
        }

        [HttpPost("/AddMultiTask")]
        public void AddMultiTask([FromBody] List<TaskModel> tasks){
            _taskService.AddMultipleTasks(tasks);
        }
    }
}
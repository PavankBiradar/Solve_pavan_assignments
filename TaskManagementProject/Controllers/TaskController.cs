using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementProject.Models;

namespace TaskManagementProject.Controllers
{
    public class TaskController : Controller
    {
        static int count = 1;
        [HttpGet]
        public IActionResult Index()
        {
            TaskViewModel taskViewModel = new TaskViewModel();
            taskViewModel.AssigneeList = TaskDataStore.GetAssignees();
            taskViewModel.TasksList = TaskDataStore.GetTasks();
            return View(taskViewModel);
        }
        [HttpPost]
        public IActionResult Index(string SelectedAssignee)
        {
            TaskViewModel taskViewModel1 = new TaskViewModel();
            taskViewModel1.AssigneeList = TaskDataStore.GetAssignees();
            taskViewModel1.TasksList = TaskDataStore.GetTasksbyAssignee(SelectedAssignee);
            return View(taskViewModel1);
            
        }
        
        [HttpPost]
        public IActionResult Assign(Models.Task task1)
        {

            TaskDataStore.AddTask(task1);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Assign()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(TaskDataStore.GetTaskById(id));
        }

        [HttpPost]
        public IActionResult Edit(Models.Task task1)
        {
            if (task1.TaskId > 0)
            {
                TaskDataStore.UpdateTask(task1);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}

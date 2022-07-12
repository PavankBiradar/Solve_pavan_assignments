using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementProject.Models;

namespace TaskManagementProject
{
    public static class TaskDataStore
    {
        private static List<Models.Task> tasks = new List<Models.Task>();
        static int count = 1;
        public static void AddTask(Models.Task task1) {
            tasks.Add(new Models.Task
            {
                TaskId = count,
                Title = task1.Title,
                Description = task1.Description,
                Assignee = task1.Assignee,
                Due_Date = task1.Due_Date
            }); count++;
        }
        
   

        public static void UpdateTask(Models.Task task1)
        {
            var matchedTasks = tasks.Where(m => m.TaskId == task1.TaskId).ToList();
            matchedTasks.ForEach(m =>
            {
                m.Title = task1.Title;
                m.Description = task1.Description;
                m.Assignee = task1.Assignee;
                m.Due_Date = task1.Due_Date;

            });
        }

        public static void DeleteTask(int taskId)
        {
            tasks.RemoveAll(m => m.TaskId == taskId);
        }

        public static List<Models.Task> GetTasks() {
            return tasks;
        }

        public static List<string> GetAssignees()
        {
            var Assignees= tasks.Select(e => e.Assignee).Distinct();
            return Assignees.ToList();
           
        }

        public static List<Models.Task> GetTasksbyAssignee(string SelectedAssignee)
        {
            var TasksbyAssignee = tasks.Where (e => e.Assignee == SelectedAssignee);
            
            return TasksbyAssignee.ToList();
        }

        public static Models.Task GetTaskById(int id)
        {
            return tasks.Find(m=>m.TaskId == id);
        }
    }
}

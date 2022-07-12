
using System.Collections.Generic;

namespace TaskManagementProject.Models
   
{
    public class TaskViewModel
    {
        public List<string> AssigneeList { get; set; }

        public List<Task> TasksList { get; set; }

        public string SelectedAssignee { get; set; }
    }
}

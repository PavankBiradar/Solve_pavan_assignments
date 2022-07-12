using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TaskManagementProject.Models
{
    public class Task
    {

        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Assignee { get; set; }
        public string Due_Date{ get; set; }

    }
}

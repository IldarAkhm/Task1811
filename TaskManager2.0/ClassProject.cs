using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager2._0
{
    internal class Project
    {
        public List<string> Description { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public Initiator Initiator { get; set; }
        public TeamLead TeamLead { get; set; }
        public List<Task> Tasks { get; set; }
        public string status { get; set; }

        public Project(List<string> description, DateTime date1, DateTime date2, Initiator initiator, TeamLead teamLead, List<Task> tasks, string status)
        {
            Description = description;
            Date1 = date1;
            Date2 = date2;
            Initiator = initiator;
            TeamLead = teamLead;
            Tasks = tasks;
            this.status = status;
        }
        public Project(List<string> description, DateTime date1, DateTime date2, Initiator initiator, TeamLead teamLead, string status)
        {
            Description = description;
            Date1 = date1;
            Date2 = date2;
            Initiator = initiator;
            TeamLead = teamLead;
            this.status = status;
        }

        public Project() { }
    }
}

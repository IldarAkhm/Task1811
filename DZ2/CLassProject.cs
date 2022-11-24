using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Project : Program
    {
        public string Description;
        public DateTime data1;
        public DateTime data2;
        public string Initiator;
        public string TeamLead;
        public List<string> TaskList;
        public string status;

        public Project(string Description,DateTime data1,
            DateTime data2, string Name, string TeamLead, List<string> TaskLisk,
            string status)
        {
            this.Description = Description;
            this.data1 = data1;
            this.data2 = data2;
            this.Initiator = Name;
            this.TeamLead = TeamLead;
            this.TaskList = TaskLisk;
            this.status = status;
        }

        public Project() { }
    }
}

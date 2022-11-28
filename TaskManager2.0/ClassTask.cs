using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager2._0
{
    internal class Task
    {
        public string description { get; set; }
        public DateTime date1 { get; set; }
        public DateTime date2 { get; set; }
        public Initiator initiator { get; set; }
        public Person person { get; set; }
        public string status { get; set; }
        public List<Report> report { get; set; }
        public Task(string description, DateTime date1, DateTime date2, Initiator initiator, Person person, string status, List<Report> report)
        {
            this.description = description;
            this.date1 = date1;
            this.date2 = date2;
            this.initiator = initiator;
            this.person = person;
            this.status = status;
            this.report = report;
        }
        public Task(string description, Initiator initiator, Person person, string status, List<Report> report)
        {
            this.description = description;
            this.initiator = initiator;
            this.person = person;
            this.status = status;
            this.report = report;
        }
        public Task() { }
    }
}

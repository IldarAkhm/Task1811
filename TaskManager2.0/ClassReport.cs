using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager2._0
{
    internal class Report
    {
        public string report { get; set; }
        public Task off { get; set; }
        public List<Report> report11 { get; set; }
        public Report(string report, Task off)
        {
            this.report = report;
            this.off = off;
        }
        public Report(string report) { this.report = report; }
        public Report(List<Report> report11) { this.report11 = report11; }
        public Report() { }
    }
}

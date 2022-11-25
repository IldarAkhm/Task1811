using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Task : Project
    {
        public string initiator;
        public string Executor;
        public string Status;
        public Entity Reports;
        public DateTime data3;
        public DateTime data4;
        public string nametask;

        public Task( string executor, string status, string initiator, DateTime data3, DateTime data4, string nametask)
        {
            this.Executor = executor;
            this.Status = status;
            this.initiator = initiator;
            this.data4 = data4;
            this.data3 = data3;
            this.nametask = nametask;
        }
        public Task() { }
    }
}

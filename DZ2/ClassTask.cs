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

        public Task( string executor, string status, string initiator)
        {
            this.Executor = executor;
            this.Status = status;
            this.initiator = initiator;
        }

        public Task() { }
    }
}

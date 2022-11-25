using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumak
{
    class BankTransaction : Bank
    {
        readonly double CheckBalanse;
        public DateTime date;
        public BankTransaction(double CheckBalanse)
        {
            this.CheckBalanse = CheckBalanse;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Person : Entity
    {
        public string Name;
        public List<string> Abilities;

        public Person() { }

        public Person(string Name, List<string> Abilities)
        {
            this.Name = Name;
            this.Abilities = Abilities;
        }
    }
}

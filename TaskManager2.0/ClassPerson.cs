using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager2._0
{
    internal class Person
    {
        public string Name { get; set; }
        public List<string> ability { get; set; }
        public Person(string name, List<string> ability)
        {
            Name = name;
            this.ability = ability;
        }
        public Person() { }
    }
}

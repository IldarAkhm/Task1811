using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Entity : Task
    {
        public string Text;
        public string person;


        public Entity(
            string Text, string person)
        {
            this.Text = Text;
            this.person = person;
        }
        public Entity() { }
    }
}


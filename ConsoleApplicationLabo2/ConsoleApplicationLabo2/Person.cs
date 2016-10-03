using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public abstract class Person
    {
        private string head = "\n";
        public string Name { get; set; }
        public string Lastname { get; set; }

        public Person(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }

        public override string ToString()
        {
            return ( head + Name + " " + Lastname);
        }

        public abstract bool HasHisBirthday();

    }
}

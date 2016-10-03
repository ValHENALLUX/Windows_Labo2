using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
   public class Enterprise
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public Enterprise(string name = "SpeedStars", string location = "Akina")
        {
            Name = name;
            Location = location;
        }

        public override string ToString()
        {
            return (Name + " située à : " + Location);
        }
    }
}

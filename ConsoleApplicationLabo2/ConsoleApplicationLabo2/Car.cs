using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public class Car
    {
        public string LiscencePlate { get; set; }

        public Car(string liscencePlate)
        {
            LiscencePlate = liscencePlate;
        }

        public override string ToString()
        {
            return LiscencePlate;
        }
    }
}

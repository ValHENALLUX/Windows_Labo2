using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public class PrivateContact : Person
    {
        public DateTime BirthDate { get; set; }

        public PrivateContact(string name, string lastname, DateTime birthDate) : base(name, lastname)
        {
            BirthDate = birthDate;
        }

        public PrivateContact(string name, string lastname) : base(name, lastname)
        {}

        public override bool HasHisBirthday()
        {
            return (DateTime.Today.Month == BirthDate.Month && DateTime.Today.Day == BirthDate.Day);
        }

        public override string ToString()
        {
            return (base.ToString() + (HasHisBirthday()? " Bon anniversaire !" : "."));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public class ProfessionalContact : Person
    {
        public bool Consultant { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public List<Enterprise> Enterprises { get; set; }

        public ProfessionalContact(string name, string lastname, bool consultant, string phone, string eMail):base(name, lastname)
        {
            Consultant = consultant;
            Phone = phone;
            EMail = eMail;
            Enterprises = new List<Enterprise>();
        }

        public override string ToString()
        {
            string chaine = (base.ToString() + " (" + Phone + ")\n" + Job() + "\n" + EMail + "\n");
            int nbEntr = Enterprises.Count();

            for (int i = 0; i < nbEntr; i++)
            {
                chaine += Enterprises[i].ToString();
                chaine += (i<nbEntr-1)? ", " :"" ;
            }

            return chaine;
        }

        public override bool HasHisBirthday()
        {
            return false;
        }

        public string Job()
        {
            return "";
        }

        /*public void EnterpriseAdd(string name, string location)
        {
            Enterprise.Add(new Enterprise(name, location));
        }*/

        public void EnterpriseAdd(Enterprise enterprise)
        {
            Enterprises.Add(enterprise);
        }
    }
}

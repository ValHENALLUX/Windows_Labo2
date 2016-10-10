using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateContact pv1 = new PrivateContact("Ludo", "Ansel");
            PrivateContact pv2 = new PrivateContact("Kevin", "Van Passenhove",new DateTime(1983,10,03));

            Console.WriteLine(pv1.ToString());
            Console.WriteLine(pv2.ToString());

            //ProfessionalContact i1 = new ProfessionalContact("Yukio", "Asakura", "indépendant", "001/68.83.558", "asakura.y@contactyou.jp");

            //ProfessionalContact c1 = new ProfessionalContact("Light", "Yagami", "consultant", "001/68.63.255", "yagami.l@contactcentre.jp");
            //ProfessionalContact c2 = new ProfessionalContact("Takumi", "Fujiwara", "consultant", "001/69.03.855", "fujiwara.takumi@centralconsulting.jp");

            Enterprise e1 = new Enterprise("bidon", "bidonville");
            Enterprise e2 = new Enterprise("SpeedStars", "Akina");

            //c1.EnterpriseAdd(e1);
            //c1.EnterpriseAdd(e2);
            //c2.EnterpriseAdd(e2);

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);

            List<ProfessionalContact> listPro = new List<ProfessionalContact>()
            {
                new ProfessionalContact("Yukio", "Asakura", false, "001/68.83.558", "asakura.y@contactyou.jp"),
                new ProfessionalContact("Light", "Yagami", true, "001/68.63.255", "yagami.l@contactcentre.jp"),
                new ProfessionalContact("Takumi", "Fujiwara", true, "001/69.03.855", "fujiwara.takumi@centralconsulting.jp")
            };

            Car c1 = new Car("93-32");

            ContactCar cc1 = new ContactCar(listPro[2], c1);

            cc1.DynamicPrint(cc1.Person);

            Console.Read();

        }
    }
}

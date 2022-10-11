using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class StepIT
    {
        class Programlasdirmaders1
        {
            public void Metod1()
            {
                Console.WriteLine("WEB dizayn");
            }
        }

        class Programlasdirmaders2
        {
            public void Metod2()
            {
                Console.WriteLine("Veri Tabani");
            }
        }

        class Programlasdirmaders3
        {
            public void Metod3()
            {
                Console.WriteLine("Ileri sevye programlasdirma");
            }
        }

        class Officeders1
        {
            public void Metod4()
            {
                Console.WriteLine("Word");
            }
        }

        class Officeders2
        {
            public void Metod5()
            {
                Console.WriteLine("Excel");
            }
        }

        class Officeders3
        {
            public void Metod6()
            {
                Console.WriteLine("PowerPoint");
            }
        }

        class Dersler
        {
            private Programlasdirmaders1 pr1;
            private Programlasdirmaders2 pr2;
            private Programlasdirmaders3 pr3;

            private Officeders1 of1;
            private Officeders2 of2;
            private Officeders3 of3;

            public Dersler()
            {
                pr1 = new Programlasdirmaders1();
                pr2 = new Programlasdirmaders2();
                pr3 = new Programlasdirmaders3();
                of1 = new Officeders1();
                of2 = new Officeders2();
                of3 = new Officeders3();

            }

            public void ProgramlasdirmaDersleri()
            {
                Console.WriteLine("-----Programlasrima Dersleri ------");
                pr1.Metod1();
                pr2.Metod2();
                pr3.Metod3();
            }

            public void OfficeDersleri()
            {
                Console.WriteLine("----- Office Dersleri ----");
                of1.Metod4();
                of2.Metod5();
                of3.Metod6();
            }
        }
        static void Main(string[] args)
        {

            Dersler facade = new Dersler();

            facade.OfficeDersleri();
            facade.ProgramlasdirmaDersleri();
            Console.ReadKey();
        }
    }
}

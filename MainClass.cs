using CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Isik isik = new Isik("Juku", 25, "12345678901", "Tallinna mnt 1");
            isik.PrindiInfo();
            Isik isik2 = new Isik();
            isik2.Nimi = "Mari";
            isik2.Isikukood = "12345678901";
            isik2.Aadress = "Tartu";
            isik2.PrindiInfo();

            //ii osa kordused, massivid, listid, klassid
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");
            for (int j = i; j >0; j--)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("----------------");
            while (i>0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("----------------");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();
            }
            while (key.Key!=ConsoleKey.Backspace); 

            Console.WriteLine("----------------");

            Console.OutputEncoding = Encoding.UTF8;

            // 1. Tervitus ja Juku
            Console.Write("Mis on sinu nimi? ");
            string nimi = Console.ReadLine();
            Console.WriteLine(FunktsioonideClass_1osa.Tervita(nimi));
            Console.WriteLine(FunktsioonideClass_1osa.KontrolliJuku(nimi));

            // 2. Naabrid
            Console.Write("Sisesta esimene nimi: ");
            string naaber1 = Console.ReadLine();
            Console.Write("Sisesta teine nimi: ");
            string naaber2 = Console.ReadLine();
            Console.WriteLine(FunktsioonideClass_1osa.Naabrid(naaber1, naaber2));

            // 3. Ruumi pindala ja remont
            Console.Write("Sisesta toa pikkus meetrites: ");
            float pikkus = float.Parse(Console.ReadLine());
            Console.Write("Sisesta toa laius meetrites: ");
            float laius = float.Parse(Console.ReadLine());
            float pindala = FunktsioonideClass_1osa.ArvutaPindala(pikkus, laius);
            Console.WriteLine("Pindala: " + pindala + " m2");

            Console.Write("Kas soovid remonti teha? (jah/ei): ");
            string remont = Console.ReadLine().ToLower();
            if (remont == "jah")
            {
                Console.Write("Ruutmeetri hind (€): ");
                float hind = float.Parse(Console.ReadLine());
                float maksumus = FunktsioonideClass_1osa.ArvutaRemont(pindala, hind);
                Console.WriteLine("Remondi kogumaksumus: " + maksumus + " €");
            }

            // 4. Soodushind
            Console.Write("Sisesta algne hind (€): ");
            float hindOrig = float.Parse(Console.ReadLine());
            Console.WriteLine("Soodushind (30%): " + FunktsioonideClass_1osa.ArvutaSoodushind(hindOrig) + " €");

            // 5. Temperatuur
            Console.Write("Sisesta toatemperatuur: ");
            float temp = float.Parse(Console.ReadLine());
            Console.WriteLine(FunktsioonideClass_1osa.KontrolliTemperatuuri(temp));

            // 6. Pikkus
            Console.Write("Sisesta oma pikkus (cm): ");
            int pikkusCm = int.Parse(Console.ReadLine());
            Console.WriteLine(FunktsioonideClass_1osa.KontrolliPikkust(pikkusCm));

            // 7. Pikkus ja sugu
            Console.Write("Sisesta sugu (m/f): ");
            string sugu = Console.ReadLine().ToLower();
            Console.WriteLine(FunktsioonideClass_1osa.KontrolliPikkustSugu(pikkusCm, sugu));

            // 8. Ostukorv
            Console.Write("Kas soovid piima? (jah/ei): ");
            bool piim = Console.ReadLine().ToLower() == "jah";

            Console.Write("Kas soovid saia? (jah/ei): ");
            bool sai = Console.ReadLine().ToLower() == "jah";

            Console.Write("Kas soovid leiba? (jah/ei): ");
            bool leib = Console.ReadLine().ToLower() == "jah";

            float summa = FunktsioonideClass_1osa.ArvutaOstukorv(piim, sai, leib);
            Console.WriteLine("Ostukorvi summa: " + summa + " €");

            Console.ReadKey();
        }
    }
}
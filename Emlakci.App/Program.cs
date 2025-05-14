using Sube2EmlakciLib;
using System.Security.Claims;

namespace Emlakci.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KiralikEv ke = new KiralikEv(500, 600, "Gazi", 3, 100, 2);
            KiralikEv ke1 = new KiralikEv(800, 900, "Kiralik Ev", 2, 120, 90);
            KiralikEv ke2 = new KiralikEv(10000, 10000, "Kiralik Ev", 4, 200, 100);

            #region Class yazma-Erişim belirleyiciler-Static sayac
            var se = new SatilikEv(400, 3, 110, "Satılık Ev", 60);
            var se1 = new SatilikEv(700, 2, 120, "Satılık Ev", 70);
            var se2 = new SatilikEv(900, 4, 140, "Satılık Ev", 80);

            Ev[] evler = { ke, ke1, ke2, se, se1, se2 };


            for (int i = 0; i < evler.Length; i++)
            {
                Console.WriteLine(evler[i].EvBilgileri());
                Console.WriteLine("------------------");
            }
        }
    }

    #endregion
}



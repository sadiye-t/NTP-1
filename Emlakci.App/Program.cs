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
            var se1 = new SatilikEv(700, 2, 120, "Satılık Ev",  70);
            var se2 = new SatilikEv(900, 4, 140, "Satılık Ev",  80);

            Ev[] evler = { ke, ke1, ke2, se, se1, se2 };

            // evim2.SetOdaSayisi(-3); //SET
            // Console.WriteLine(evim2.GetOdaSayisi()); //GET

            //Başka bir nesne türetme yöntemi ise:
            // var evim = new Ev{katno=2, odasayisi=3};

            for (int i = 0; i < evler.Length; i++)
            {
                //if (evler[i] is SatilikEv)
                //{
                //    SatilikEv sev = (SatilikEv)evler[i];
                //    Console.WriteLine(sev.EvBilgileri());
                //}
                //else
                //{
                //    KiralikEv kev = (KiralikEv)evler[i];
                //    Console.WriteLine(kev.EvBilgileri());
                //}
                Console.WriteLine(evler[i].EvBilgileri());
                Console.WriteLine("------------------");
            }
           //var evim3 = new Ev(2, 3, 120);
            //Console.WriteLine(evim3.EvBilgileri());

            //Console.WriteLine($"Bellekteki ev sayısı:{Ev.sayac}");

            //try
            //{
            //    var evim = new Ev();
            //    evim.Alan = 60;
            //    evim.Odasayisi = 3;
            //    evim.Semt = "Gazi";
            //    evim.Katno = 2;
            //    Console.WriteLine(Ev.Sayac);
            //    //evim.Buyukluk = "Küçük Ev";
            //    Console.WriteLine(evim.Buyukluk);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine($"Bellekteki evlerin sayısı:{Ev.sayac}"); // Bir class içinde static olarak tanımlanan üyelere, class ismi ile erişilir ve bu üyeler program çalıştığı sürece bellekte tutulur. Nesnelerden bağımsız classa ait yapılar. 

        }
        /*1.YAZIM YOLU*/
        //string bilgi = evim.EvBilgileri();
        //Console.WriteLine(bilgi);

        ///*2.YAZIM YOLU*/
        //Console.WriteLine(evim2.EvBilgileri());

        //Ev classından bir nesne türetildi.
        //evim:Nesnenin referansıdır. Nesnelere ulaşmakta kullanılır.Referanslar(HEAP bölgesindeki nesnenin adresini tutar) STACK bölgesinde oluşturulur. 
        //Ev: Referansın veri tipi. Her class aynı zamanda bir "veri tipidir." 
        //new: Nesne üretmek için kullanılan anahtar sözcük. Nesneler HEAP bölgesinde oluşturulur.

        //             ERİŞİM BELİRLEYİCİLER-Acces Modifiers
        // Private: Sadece class içinden erişilebilir üyeler tanımlar.
        // Public: Class dışındanda-içindende erişilebilir üyeler tanımlar.
        //Bir classtan birden fazla nesne üretilebilir.
    }

    #endregion
}



namespace açıklama
{
    public class Class1
    {//-ev.cs
       // DDL-.NET-Constructe-Defaul const-Optional paramt
        //.Net sürümü hangi versiyonlar ile uyumludur diye bakmalıyız(.NET compatibility) 2.0-2.1
         //.NET: Class lib framework ile uyumlu olması gerekmektedir.
         //.NET standart: Tekrar kullanılabilir kod örnekleri oluştururken kullanılır.Ayrıca .NET FRAEMWORK,.NET CORE, XAMARIN gibi uygulama modellerinde de kullanabiliriz.
         //DLL uzantılı dosya-Dinamik bağlantı kitaplığı-Dynamic Link Library:Dependenciesten haberdar etmemiz gerekiyor.Add Project Reference.Hatalı koda giderek (Ctrl + .) using yapmamız gerekmektedir.

            //        Constructer-Yapıcı Methos Kurucu Method
            //Class içinde bulunan fieldlara varsayılan değerlerini atarlar.
            //Her classta mutlaka bulunur, hiçbir parametre almazlar. Bir classtan nesne türetildiğinde ilk çalışılan metoddur.
            //Constructer tanımlamasında isim verilirken, class adı ile aynı isim verilmelidir.
            //Bu memthodlar geriye hiçbir değer döndürmezler. **Ancak VOİD de değillerdir, geri dönüş tipi yoktur.
            //Constructerları visual studio ile oluştururken ctor code snippeti kullanılabilir. (ctor+tab)

            //Optional Parameter: Semte değer gönderirsek onu yazar, göndermezsek kızılay yazar. **Ama hep sonda tanımlanmalı, yazılmalıdır.

            //Constructer Overloading: Hangisini istersem o overloadingi kullanabiliyorum  1 of 2
            //Default-Constructer:Atama yapılmamış.     
            // (): Hep methodların sonunda kullanılırdı.

            //Alan
            //50-75:Küçük ev
            //75-120: Orta büyüklükte ev
            //>120: Büyük ev

            //Auto-Property: Get ve set bloklarında işlem yapılmayacağı zaman kullanılır.
            //Lambda ile tek satırlı property örnekleri 

        //Metodlarla yapılan Getter ve Setter'lar
        //public void SetOdaSayisi(int odasayisi) => this.odasayisi = Math.Abs(odasayisi); //Oda sayısını pozitife çevirir.
        //public int GetOdaSayisi() => this.odasayisi;

        //Full Property: Get ve Set bloklarında çok satırlı işlemler yapmak için kullanılır.
        //private int myVar;

        //public int MyProperty
        //{
        //    get
        //    { 
        //        //
        //        return myVar;

        //    }
        //    set
        //    { 
        //        //
        //        myVar = value;
        //        //
        //    }
        //} 
             //public int MyProperty { get; set; }

         //public void SetOdaSayisi(int odasayisi) //Yukarıda odasayisini private yaptık ama o fielda erişebilmek ve değer atama yapabilmek için public bir method yazdık. Set:Atama 

        //this.odasayisi = Math.Abs(odasayisi);
        //Abs-Absolute: Gelen paramterenin değerini mutlak değere alarak öyle atama işlemi yapar.

        //       Nesne Tabanlı Programlamanın Kapsülleme-Encapsülation İlkesi: 
        //Class içerisinde yapılan işlemin class dışından gizlenmesidir. Örn: odayisi field'ına değer atama işlemi yapmak için öncelikle field private yapıldı, sonrasında bu fielda erişebilen public SetOdaSayisi(int odasayisi) metodu yazıldı. Bu metod içinde gelen değerin mutlak değeri alınarak odasayisi fieldına aktarıldı ve bu işlemden metodu kullananların bilgisi olmadı.  

        //virtual: Override edilmesi gereken üyeler, virtual anahtar kelimesi ile tanımlanır.
        //Polymorphisim(Çok biçimlilik): base classta virtual olarak tanımlanan üyeler, türeyen classlarda override edilerek farklı biçimlerde kullanılabilir.

        //public string EvBilgileri()    {    return $"Oda Sayısı:{this.odasayisi}\nKat No:{this.katno}\nSemt No:{this.semt}\nAlan:{this.alanbilgisi}\n";
     //***Console.WriteLine demememe sebebim başka platformlarda da çalışabilmesi için.Ama yazmaz çünkü diğer dosyada Console.WriteLine denmelidir. 


        //-program.cs

        // evim2.SetOdaSayisi(-3); //SET
        // Console.WriteLine(evim2.GetOdaSayisi()); //GET

        //Başka bir nesne türetme yöntemi ise:
        // var evim = new Ev{katno=2, odasayisi=3};

        
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
    // Internal Erişim Belirleyicisi: Yalnızca aynı namespace içersindeki tüm classlar tarafından erişilebilir.
     // :base() Constructerin tuttuğu değerleri gösterir.

    //public new string EvBilgileri()
    //   {    return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";    }
    //is-a ilişkisi, base, derived class,Inheritence-Kalıtım
        // KALITIM: Kod tekrarını önlemek, bellek-depolama tasarrufu yapmak, önceden yazılmış bir classın özelliklerini yeni classta kullanmak için ama arada is-a ilişkisi olmak zorundadır.
        // İS-A SORUSU:  ÖRN:   ---Her satılık ev bir ev midir?evet türetilebilir      ---Her okul bir öğrenci midir?hayır türetilemez    ---Her araba bir taşıt mıdır?evet türetilebilir
        //Her classda sadece bir "base class" olur başka olamaz.
        // MiİRAS ALMA: üst classtan alt classa bilgi aktarımı
        // Derived class: türetilmiş class.
 
        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nSatış Fiyat:{this.Satisfiyat}";
        //}

        //Name Hiding: Türeyen classlarda, base classtaki üye(ler)in ismiyle aynı isimli bir üye tanımlanırsa, artık türeyen class referansıyla base classtaki üyeye erişilemez.
}
}

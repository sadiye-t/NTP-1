using System;
using System.Threading;

namespace Sube2EmlakciLib
#region DDL-.NET-Constructe-Defaul const-Optional paramt
{//.Net sürümü hangi versiyonlar ile uyumludur diye bakmalıyız(.NET compatibility) 2.0-2.1
 //.NET: Class lib framework ile uyumlu olması gerekmektedir.
 //.NET standart: Tekrar kullanılabilir kod örnekleri oluştururken kullanılır.Ayrıca .NET FRAEMWORK,.NET CORE, XAMARIN gibi uygulama modellerinde de kullanabiliriz.
 //DLL uzantılı dosya-Dinamik bağlantı kitaplığı-Dynamic Link Library:Dependenciesten haberdar etmemiz gerekiyor.Add Project Reference.Hatalı koda giderek (Ctrl + .) using yapmamız gerekmektedir.
    public class Ev
    {
        #region Constructer
        public static int sayac = 0;
        public static int Sayac { get; private set; }
        public Ev()
        {
            sayac++;
        }
        //        Constructer-Yapıcı Methos Kurucu Method
        //Class içinde bulunan fieldlara varsayılan değerlerini atarlar.
        //Her classta mutlaka bulunur, hiçbir parametre almazlar. Bir classtan nesne türetildiğinde ilk çalışılan metoddur.
        //Constructer tanımlamasında isim verilirken, class adı ile aynı isim verilmelidir.
        //Bu memthodlar geriye hiçbir değer döndürmezler. **Ancak VOİD de değillerdir, geri dönüş tipi yoktur.
        //Constructerları visual studio ile oluştururken ctor code snippeti kullanılabilir. (ctor+tab)

        public Ev(int odasayisi, double alanbilgisi, int katno, string semt = "Kızılay")
        { //Optional Parameter: Semte değer gönderirsek onu yazar, göndermezsek kızılay yazar. **Ama hep sonda tanımlanmalı, yazılmalıdır.
            this.odasayisi = odasayisi;
            this.semt = semt;
            this.alanbilgisi = alanbilgisi;
            this.katno = katno;
            sayac++;
        }

        public Ev(int odasayisi, double alanbilgisi, int katno)
        {
            this.odasayisi = odasayisi;
            this.semt = "Kızılay";
            this.alanbilgisi = alanbilgisi;
            this.katno = katno;
            sayac++;
        }

        private string Semt;
        public string Buyukluk { get; private set; }
        //Constructer Overloading: Hangisini istersem o overloadingi kullanabiliyorum  1 of 2
        //Default-Constructer:Atama yapılmamış.     
        // (): Hep methodların sonunda kullanılırdı.

        //Alan
        //50-75:Küçük ev
        //75-120: Orta büyüklükte ev
        //>120: Büyük ev

        //Auto-Property: Get ve set bloklarında işlem yapılmayacağı zaman kullanılır.
        public int katno { get; set; }

        //Lambda ile tek satırlı property örnekleri      
        public string semt { get => Semt; set => Semt = value.ToUpper(); }//Property

        private int odasayisi;//field      
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }

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

        private double alanbilgisi;//field

        public double Alan//full property
        {

            get { return alanbilgisi; }
            set
            {
                if (value < 50)
                {
                    throw new Exception("Min alan değeri 50 olmalıdır");
                }
                alanbilgisi = value;
                if (this.alanbilgisi > 50 && this.alanbilgisi < 75)
                {
                    this.Buyukluk = "Küçük Ev";
                }
                else if (this.alanbilgisi > 75 && this.alanbilgisi < 120)
                {
                    this.Buyukluk = "Orta büyüklükte ev";
                }
                else
                {
                    this.Buyukluk = "Büyük ev";
                }
            }
        }


        //public void SetOdaSayisi(int odasayisi) //Yukarıda odasayisini private yaptık ama o fielda erişebilmek ve değer atama yapabilmek için public bir method yazdık. Set:Atama 

        //this.odasayisi = Math.Abs(odasayisi);
        //Abs-Absolute: Gelen paramterenin değerini mutlak değere alarak öyle atama işlemi yapar.

        //       Nesne Tabanlı Programlamanın Kapsülleme-Encapsülation İlkesi: 
        //Class içerisinde yapılan işlemin class dışından gizlenmesidir. Örn: odayisi field'ına değer atama işlemi yapmak için öncelikle field private yapıldı, sonrasında bu fielda erişebilen public SetOdaSayisi(int odasayisi) metodu yazıldı. Bu metod içinde gelen değerin mutlak değeri alınarak odasayisi fieldına aktarıldı ve bu işlemden metodu kullananların bilgisi olmadı.  
        #endregion
        public virtual string EvBilgileri()
        {
            return $"Oda Sayısı:{this.odasayisi}\nKat no:{this.katno}\nAlan:{this.alanbilgisi}\nSemt:{this.semt}\nBüyüklük:{this.Buyukluk}";
        }
        //virtual: Override edilmesi gereken üyeler, virtual anahtar kelimesi ile tanımlanır.
        //Polymorphisim(Çok biçimlilik): base classta virtual olarak tanımlanan üyeler, türeyen classlarda override edilerek farklı biçimlerde kullanılabilir.

        //public string EvBilgileri()    {    return $"Oda Sayısı:{this.odasayisi}\nKat No:{this.katno}\nSemt No:{this.semt}\nAlan:{this.alanbilgisi}\n";
    } //***Console.WriteLine demememe sebebim başka platformlarda da çalışabilmesi için.Ama yazmaz çünkü diğer dosyada Console.WriteLine denmelidir.
}
}
#endregion

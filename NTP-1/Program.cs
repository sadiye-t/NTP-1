using System.Reflection.Metadata.Ecma335; //classların bu projenin içerisind ekullanılmasını sağlıyor.Ama önce library referansı bağlamalıyız.

namespace NTP_1
{
    internal class Program
    {
        static void Main(string[] args) { }
        //{
        //    Console.WriteLine("Kaç sayı girmek istiyorsunuz?:");
        //    int adet = int.Parse(Console.ReadLine());
        //    int[] dizi = new int[adet];
        //    for (int i = 0; i < dizi.Length; i++)
        //    {
        //        Console.WriteLine($"{i + 1}.Sayıyı giriniz:");
        //        dizi[i] = int.Parse(Console.ReadLine());
        //    }
        //    Console.WriteLine($"İşlemin Sonucu:{Topla(dizi)}");
        //} 
        #region Diziler Kadar Dönen
        //static int Topla(int[] sayilar)
        //{
        //    int toplam = 0;
        //    for (int i = 0; i < sayilar.Length; i++)
        //    {
        //        toplam += sayilar[i];
        //    }
        //}
        #endregion
        #region Void-Method İmzası

        //    Console.WriteLine("Sayı giriniz:");
        //    int a1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Diğer sayıyı giriniz:");
        //    int a2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Yapmak istediğiniz işlemi seçin:Toplama için 1 Çıkarma için 2");
        //    int secim = int.Parse(Console.ReadLine());
        //    if (secim == 1)
        //    {
        //        Console.WriteLine(Topla(a1, a2));
        //    }
        //    else if (secim == 2)
        //     {
        //        Console.WriteLine(Cikar(a1, a2));                   

        //static int Cikar(int a3, int a4) ////Methoddaki 2 parametrenin (Method parametresi parantez içinde.) yanına 3.cüyü atarsam kötü yoldan 3.cü sayıyı 0 verebilirim.

        ////    *** METHOD İMZASI-OVERLOADİNG*** int,int gibidir.Method imzaları farklı olursa, aynı isimle metodlar tanımlanabilir. Bu durum methodun işlevselliğini arttırır. Daha önce kodu kullandıysanız ve silemiyorsanız overloading kullanmak durumunda kalıyoruz.
        ////Örneğin: (int a1, int a2, int a3) - (int a1, int a2) gibi.
        //{
        //    int sonuc = a3 - a4;
        //    return sonuc;
        //}
        #endregion
        #region METHODLAR-Lambda-Void
        ////***Metod içine başka bir metod tanımlaması yapılamaz.Metod tanımlaması sonunda ; olmaz.Return ifadesi ile metodlar değer dönüşü yaparlar. Bu değerler, metodların çağrıldığı yere döndürülür.
        ////***LAMBDA OP: İçerisinde tek satır işlem olan metodlarda gövde(tek satır metod skobu) tanımlaması yerine => (LAMBDA Operatörü) kullanılabilir 
        //Örneğin: static int Cikar(int a1, int a2) => a1-a2;)

        //Debug işlemlerinde F10: ilerlemek için F11: methoda içerisine girip ilerlemek için.
        //    Console.WriteLine("Sayı giriniz:");
        //    int a1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Bir sayı daha giriniz:");
        //    int a2 = int.Parse(Console.ReadLine());
        //    int sonuc = Topla(a1, a2);
        //    Console.WriteLine(sonuc); ////Console.WriteLine(Topla(a1,a2)); değişkenleri farklı yazabiliriz. Topla methodunu kullancağı için değişkenlerin ismi  farketmeksizin görevini yapar.
    }
    //static int Topla(int a2, int a3)
    //{
    //    int sonuc = a2 + a3;
    //    return sonuc;
    //}
    ////Parametre döndürüp döndürmediğini kodun üstüne gelip parantez içine bakarak anlayabiliriz. Parametre işlerin yapılacağı verilerdir.
    
    ////VOİD METHODU: geriye değer döndürmez. Örneğin: toplama işlemini yaptım der sonucu söylemez. Dolayısıyla return yapılmasına gerek yoktur. Kullanılırsa da return; şeklinde kullanılabilir ve metoddan çıkış anlamına gelir.

    //static int Topla(int a1, int a2) ////Her parametrenin tipini aynı da olsa yazmak zorundayız.
    //{
    //    int sonuc = a1 + a2;
    //    return sonuc;
    //}
    #endregion

}
using System;
using System.Collections.Generic;
using System.Text;

namespace Sube2EmlakciLib
{
    #region is-a ilişkisi, base, derived class,Inheritence-Kalıtım
    // KALITIM: Kod tekrarını önlemek, bellek-depolama tasarrufu yapmak, önceden yazılmış bir classın özelliklerini yeni classta kullanmak için ama arada is-a ilişkisi olmak zorundadır.
    // İS-A SORUSU:  ÖRN:   ---Her satılık ev bir ev midir?evet türetilebilir      ---Her okul bir öğrenci midir?hayır türetilemez    ---Her araba bir taşıt mıdır?evet türetilebilir
    //Her classda sadece bir "base class" olur başka olamaz.
    // MiİRAS ALMA: üst classtan alt classa bilgi aktarımı
    // Derived class: türetilmiş class.
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {

        }
        public SatilikEv(double satisfiyat, int odasayisi, int katno, string semt, int alanbilgisi)
        {
            Satisfiyat = satisfiyat;
        }
        public double Satisfiyat { get; set; }
        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nSatış Fiyat:{this.Satisfiyat}";
        //}
        public override string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nSatış Fiyat:{this.Satisfiyat}";
        }
    }
}
//Name Hiding: Türeyen classlarda, base classtaki üye(ler)in ismiyle aynı isimli bir üye tanımlanırsa, artık türeyen class referansıyla base classtaki üyeye erişilemez. 
#endregion
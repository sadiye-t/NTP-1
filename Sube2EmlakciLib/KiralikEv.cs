using System;
using System.Collections.Generic;
using System.Text;

namespace Sube2EmlakciLib
{
    public class KiralikEv : Ev
    {
        public KiralikEv(double kirafiyati, double depozitofiyati, string semt, double alanbilgisi, int katno, int odasayisi) : base(odasayisi, alanbilgisi, katno, semt)
        {
            this.Kira = kirafiyati;
            this.Depozito = depozitofiyati;

        }
        public double Kira { get; set; }
        public double Depozito { get; set; }
    

    public override string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        }
    }
}

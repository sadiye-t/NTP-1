using System;
using System.Collections.Generic;
using System.Text;

namespace Sube2EmlakciLib
{
    #region 
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
        
        public override string EvBilgi()
        {
            return $"{base.ToString()}\nSatış Fiyat:{this.Satisfiyat}";
        }
    }
}
 
#endregion
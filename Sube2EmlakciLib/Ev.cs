using System;
using System.Threading;

namespace Sube2EmlakciLib
#region DDL-.NET-Constructe-Defaul const-Optional paramt
{
    public abstract class Ev
    {
        #region Constructer
        public static int sayac = 0;
        public static int Sayac { get; private set; }
        public Ev()
        {
            sayac++;
        }
        
        public Ev(int odasayisi, double alanbilgisi, int katno, string semt = "Kızılay")
        {
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
        
        public int katno { get; set; }

             
        public string semt { get => Semt; set => Semt = value.ToUpper(); }

        private int odasayisi;     
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }

        
        private double alanbilgisi;

        public double Alan
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

        #endregion
        public abstract string EvBilgi();
        public virtual string EvBilgileri()
        {
            return $"Oda Sayısı:{this.odasayisi}\nKat no:{this.katno}\nAlan:{this.alanbilgisi}\nSemt:{this.semt}\nBüyüklük:{this.Buyukluk}";
        }
        }
}

#endregion

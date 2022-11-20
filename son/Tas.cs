using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Tas : Nesne
    {
        private float katilik;
        public float Katilik { get => katilik; set => katilik = value; }
      
        public float a;
        public override double etkiHesapla() 
        {
            return katilik;
        }
        public override void durumGuncelle(double damage, double seviye)
        {
            Dayaniklilik -= damage;
            SeviyePuan += seviye;
        }
        public override void PuanGoster(dynamic can, dynamic seviye)
        {
            can.Text= "Can " +Dayaniklilik.ToString();
            seviye.Text = "Seviye " + SeviyePuan.ToString();
        }
        public Tas() : base()
        {
            katilik = 2;
        }  
        public Tas(float tas_seviye, float tas_dayaniklilik,float katilik) : base(tas_seviye,  tas_dayaniklilik)
        {
            this.katilik = katilik;
        }

     
    }
}

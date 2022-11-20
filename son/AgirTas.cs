using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class AgirTas : Tas
    {
        private float sicaklik;
        public float Sicaklik { get => sicaklik; set => sicaklik = value; }
       
        public AgirTas(float agirtas_seviye, float agirtas_dayaniklilik,float agirtas_katilik) : base(agirtas_seviye,agirtas_dayaniklilik,agirtas_katilik) 
        {
            this.sicaklik = sicaklik;
        }

        public AgirTas() : base()
        {
            sicaklik = 2;
        }
        public override double etkiHesapla() 
        {
            return sicaklik*Katilik;
        }

        public override void durumGuncelle(double damage, double seviye)
        {
            Dayaniklilik -= damage;
            SeviyePuan += seviye;
            SeviyePuan += seviye;
        }
        public override void PuanGoster(dynamic can, dynamic seviye)
        {
            can.Text = "Can " + Dayaniklilik.ToString();
            seviye.Text = "Seviye " + SeviyePuan.ToString();
        }
    }
}

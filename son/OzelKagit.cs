using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class OzelKagit : Kagit
    {
       
        private float kalinlik;
        public float Kalinlik { get => kalinlik; set => kalinlik = value; }

        public OzelKagit(float ozelkagit_seviye, float ozelkagit_dayaniklilik, float ozelkagit_nufuz) : base(ozelkagit_seviye, ozelkagit_dayaniklilik, ozelkagit_nufuz)
        {
            this.kalinlik = kalinlik;
        }
        public OzelKagit() : base()
        {
            kalinlik = 2;
        }
        public override double etkiHesapla()
        {
            return kalinlik * Nufuz;
        }
        public override void durumGuncelle(double damage, double seviye)
        {
            Dayaniklilik -= damage;
            SeviyePuan += seviye;
        }
        public override void PuanGoster(dynamic can, dynamic seviye)
        {
            can.Text = "Can " + Dayaniklilik.ToString();
            seviye.Text = "Seviye " + SeviyePuan.ToString();
        }
    }

}

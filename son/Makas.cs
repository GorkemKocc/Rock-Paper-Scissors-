using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    public class Makas : Nesne
    {
        
        private float keskinlik ;
        public float Keskinlik { get => keskinlik; set => keskinlik = value; }

        public float a;
        public override double etkiHesapla()
        {
            return keskinlik;
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

        public Makas() : base()
        {
            keskinlik = 2;
        }

        public Makas(float makas_seviye, float makas_dayaniklilik, float keskinlik) : base(makas_seviye, makas_dayaniklilik)
        {
            this.keskinlik = keskinlik;
        }
    }
}

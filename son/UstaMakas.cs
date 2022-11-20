using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class UstaMakas : Makas
    {
        private float hiz;
        public float Hiz { get => hiz; set => hiz = value; }

        public UstaMakas(float ustamakas_seviye, float ustamakas_dayaniklilik, float ustamakas_keskinlik) : base(ustamakas_seviye, ustamakas_dayaniklilik, ustamakas_keskinlik)
        {
            this.hiz = hiz;
        }

        public UstaMakas() : base()
        {
            hiz = 2;
        }
        public override double etkiHesapla()
        {
            return hiz * Keskinlik;
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

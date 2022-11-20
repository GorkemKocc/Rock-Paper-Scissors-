using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Kagit : Nesne
    {

        private float nufuz;
        public float Nufuz { get => nufuz; set => nufuz = value; }

        public float a;
        public override double etkiHesapla()
        {
            return nufuz;
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

        public Kagit() : base()
        {
            nufuz = 2;
        }

        public Kagit(float kagit_seviye, float kagit_dayaniklilik, float nufuz) : base(kagit_seviye, kagit_dayaniklilik)
        {
            this.nufuz = nufuz;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Bilgisayar : Oyuncu
    {
        public Bilgisayar(int oyuncuID,string oyuncuAdi,int skor) : base(oyuncuID, oyuncuAdi, skor)
        {

        }
        public Bilgisayar() : base()
        {
     
        }
        public override void NesneSec(dynamic nesne)
        {
            var random = new Random();
            int a;
            for (int i = 0; i < 5; i++)
            {
                a = random.Next(3);
                if (a == 0)
                {
                    dynamic tas = new Tas();
                    nesne.NesneListesi.Add(tas);
                }
                if (a == 1)
                {
                    dynamic kagit = new Kagit();
                    nesne.NesneListesi.Add(kagit);
                }
                if (a == 2)
                {
                    dynamic makas = new Makas();
                    nesne.NesneListesi.Add(makas);
                }
            }
        }
        public override void SkorGoster()
        {

        }

    }
}

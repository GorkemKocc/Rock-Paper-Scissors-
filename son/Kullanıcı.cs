using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Kullanıcı : Oyuncu
    {
        public Kullanıcı(int oyuncuID, string oyuncuAdi, int skor) : base(oyuncuID, oyuncuAdi, skor)
        {

        }
        public Kullanıcı() : base()
        {

        }
        public override void NesneSec(dynamic nesne)
        {
            NesneListesi.Add(nesne);
            
        }
        public override void SkorGoster()
        {

        }

    }
}

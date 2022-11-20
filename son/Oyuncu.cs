using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public abstract class Oyuncu
    {
        private int oyuncuID;
        public int OyuncuID { get => oyuncuID; set => oyuncuID = value; }

        private string oyuncuAdi;
        public string OyuncuAdi { get => oyuncuAdi; set => oyuncuAdi = value; }

        private int skor;
        public int Skor { get => skor; set => skor = value; }

        private dynamic nesneListesi= new List<dynamic>();
        public dynamic NesneListesi { get => nesneListesi; set => nesneListesi = value; }
     
        abstract public void SkorGoster();
        abstract public void NesneSec(dynamic nesne);

        public Oyuncu(int oyuncuID, string oyuncuAdi, int skor)
        {
            this.OyuncuID = oyuncuID;
            this.OyuncuAdi = oyuncuAdi;
            this.Skor = skor;
        }
        public Oyuncu()
        {
            oyuncuAdi = "";
            oyuncuID = 0;
            skor = 0;
        }


    }
}

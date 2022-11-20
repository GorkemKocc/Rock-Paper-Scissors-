using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public abstract class Nesne
    {   
        private double seviyePuani;

        private double dayaniklilik; 
        public double Dayaniklilik { get => dayaniklilik; set => dayaniklilik = value; }
        public double SeviyePuan { get => seviyePuani; set => seviyePuani =  value; }


        abstract public  void PuanGoster(dynamic can, dynamic seviye);
        abstract public double etkiHesapla();
        abstract public void durumGuncelle(double damage, double seviye);

        public Nesne(float seviyePuani, float dayaniklilik) 
        {
            this.SeviyePuan = seviyePuani;
            this.Dayaniklilik = dayaniklilik;   
        }

        public Nesne()
        {
            seviyePuani = 0;
            dayaniklilik = 20;
        }

    } 
}



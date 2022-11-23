using Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace son
{
    public partial class vs : UserControl
    {
        public UserControl user = new UserControl();
        public string winner;
        public Kullanıcı kullanıcı1 = new Kullanıcı();
        public Bilgisayar bilgisayar1 = new Bilgisayar();
        public Bilgisayar bilgisayar2 = new Bilgisayar(); 
        public Button[] player_list = new Button[5];
        public Button[] pc_list= new Button[5];
        public Label[] pc_label = new Label[10];
        public Label[] player_label = new Label[10];
        public List<int> pc_olu = new List<int>();
        public List<int> player_olu = new List<int>();
        public List<int> pc_secim = new List<int>();
        public int tekrar = 0, pc_tekrar = 0, hamle = 0;
        public double skor1, skor2;
     

        public vs()
        {
            InitializeComponent();
        }

        private void vs_Load(object sender, EventArgs e)
        {
            pc_label[0] = label8;
            pc_label[1] = label9;
            pc_label[2] = label10;
            pc_label[3] = label11;
            pc_label[4] = label12;
            pc_label[5] = label18;
            pc_label[6] = label19;
            pc_label[7] = label20;
            pc_label[8] = label21;
            pc_label[9] = label22;

            player_label[0] = label3;
            player_label[1] = label4;
            player_label[2] = label5;
            player_label[3] = label6;
            player_label[4] = label7;
            player_label[5] = label13;
            player_label[6] = label14;
            player_label[7] = label15;
            player_label[8] = label16;
            player_label[9] = label17;
           

        }

        public void ad()
        {
            if (kullanıcı1.OyuncuAdi == null || kullanıcı1.OyuncuAdi == "")
                label1.Text = "Oyuncu 1";
            else
              label1.Text = kullanıcı1.OyuncuAdi;
            
            if (bilgisayar1.OyuncuAdi == null || bilgisayar1.OyuncuAdi == "")
                label2.Text = "Oyuncu 2";
            else
            label2.Text = bilgisayar1.OyuncuAdi;
            
        }
        
        public void nesnelist()
        {   
            player_list[0] = button1;
            player_list[1] = button2;
            player_list[2] = button3;
            player_list[3] = button4;
            player_list[4] = button5;

            pc_list[0] = button6;
            pc_list[1] = button7;
            pc_list[2] = button8;
            pc_list[3] = button9;
            pc_list[4] = button10;

            for (int i=0;i<5;i++)
            {
                if (kullanıcı1.NesneListesi[i].GetType() == typeof(Tas))
                {
                    player_list[i].Image = ımageList1.Images[2];
                }
                if (kullanıcı1.NesneListesi[i].GetType() == typeof(Kagit))
                {
                    player_list[i].Image = ımageList1.Images[1];
                }
                if (kullanıcı1.NesneListesi[i].GetType() == typeof(Makas))
                {
                    player_list[i].Image = ımageList1.Images[0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (bilgisayar1.NesneListesi[i].GetType() == typeof(Tas))
                {
                    pc_list[i].Image = ımageList1.Images[2];
                }
                if (bilgisayar1.NesneListesi[i].GetType() == typeof(Kagit))
                {
                    pc_list[i].Image = ımageList1.Images[1];
                }
                if (bilgisayar1.NesneListesi[i].GetType() == typeof(Makas))
                {
                    pc_list[i].Image = ımageList1.Images[0];
                }
            }
        }
        
        public void pc_label_update(int x)
        {
            

            bilgisayar1.NesneListesi[x].PuanGoster(pc_label[x], pc_label[x+5]);
 
        }
       
        public double etki(dynamic nesne)
        {
            double etki1=0;
            if(nesne.GetType() == typeof(Tas))
            {
                 etki1= nesne.etkiHesapla();
            }
            if (nesne.GetType() == typeof(Kagit))
            {
                 etki1 = nesne.etkiHesapla();
            }
            if (nesne.GetType() == typeof(Makas))
            {
                 etki1 = nesne.etkiHesapla();
            }
            if (nesne.GetType() == typeof(AgirTas))
            {
                etki1 = nesne.etkiHesapla();
            }
            if (nesne.GetType() == typeof(OzelKagit))
            {
                etki1 = nesne.etkiHesapla();
            }
            if (nesne.GetType() == typeof(UstaMakas))
            {
                etki1 = nesne.etkiHesapla();
            }

            return etki1;
        }

        public double katsayı(dynamic attacker, dynamic defender)
        {
            double a = 0.5;
            if (attacker.GetType() == typeof(Tas) && defender.GetType() == typeof(Makas))
            {
                a = 0.2;
            }
            if (attacker.GetType() == typeof(Tas) && defender.GetType() == typeof(Kagit))
            {
                a = 0.8;
            }
            if (attacker.GetType() == typeof(Kagit) && defender.GetType() == typeof(Makas))
            {
                a = 0.8;
            }
            if (attacker.GetType() == typeof(Kagit) && defender.GetType() == typeof(Tas))
            {
                a = 0.2;
            }
            if (attacker.GetType() == typeof(Makas) && defender.GetType() == typeof(Kagit))
            {
                a = 0.2;
            }
            if (attacker.GetType() == typeof(Makas) && defender.GetType() == typeof(Tas))
            {
                a = 0.8;
            }

            return a;
        }
      
        public void alive(dynamic nesne, int x, bool pc)
        { 
            if(pc)
            {
                if(nesne.Dayaniklilik <= 0)
                {
                    pc_list[x].BackColor = Color.Black;
                    pc_list[x].Enabled = false; 
                    nesne.Dayaniklilik = 0;
                    pc_olu.Add(x);
                    pc_label_update(x);
                }
            }
            else
            {
                if (nesne.Dayaniklilik <= 0)
                {
                    player_list[x].BackColor = Color.Black;
                    player_list[x].Enabled = false;
                    nesne.Dayaniklilik = 0;
                    player_olu.Add(x);
                    kullanıcı1.NesneListesi[2].PuanGoster(player_label[x], player_label[x+5]);

                }
            }   
            if(pc_olu.Count == 5)
            {
                winner = "Kazanan "+label1.Text;
                this.Visible = false;
                user.Visible = true;           
            }
            if (player_olu.Count == 5)
            {   
                winner = "Kazanan "+label2.Text;
                this.Visible = false;
                user.Visible = true;
    
            }
        }
        
        public async void tekrar_kont()
        {
             await Task.Delay(50);
           if(pc_tekrar == 5)
            {
                button6.Enabled = true;
                button6.BackColor = Color.White;
                button7.Enabled = true;
                button7.BackColor = Color.White;
                button8.Enabled = true;
                button8.BackColor = Color.White;
                button9.Enabled = true;
                button9.BackColor = Color.White;
                button10.Enabled = true;
                button10.BackColor = Color.White;
            }

            if (tekrar == 5)
            {
                button1.Enabled = true;
                button1.BackColor = Color.White;
                button2.Enabled = true;
                button2.BackColor = Color.White;
                button3.Enabled = true;
                button3.BackColor = Color.White;
                button4.Enabled = true;
                button4.BackColor = Color.White;
                button5.Enabled = true;
                button5.BackColor = Color.White;
            }

        }

        public double skor_bul(dynamic nesne)
        {
            double skor = 0;
            for(int i=0;i<5;i++)
            {
                skor += nesne.NesneListesi[i].Dayaniklilik;
            }
            return skor;

        }

        public void hamle_kont()
        {
            if(hamle == 10 && pc_olu.Count < 5 && player_olu.Count < 5)
            {
                skor1 = skor_bul(kullanıcı1);
                skor2 = skor_bul(bilgisayar1);
                if(skor1>skor2)
                {
                    winner = "Kazanan " + label1.Text;

                    this.Visible = false;
                    user.Visible = true;
                }
                else
                {
                    winner = "Kazanan " + label2.Text;
                    this.Visible = false;
                    user.Visible = true;
                }
            }
        }            

        public dynamic upgrade_check(dynamic nesne, double can)
        {
            if(nesne.SeviyePuan > 30)
            {   
              
                if (nesne.GetType() == typeof(Tas))
                {
                    nesne = new AgirTas();
                   
                }
                if (nesne.GetType() == typeof(Kagit))
                {
                    nesne = new OzelKagit();
                }
                if (nesne.GetType() == typeof(Makas))
                {
                    nesne = new UstaMakas();
                }
                nesne.SeviyePuan = 40;
                nesne.Dayaniklilik = can;
            }
            return nesne;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            double a ;
            button1.BackColor = Color.Red;
            Random random = new Random();
            int pc_kart = random.Next(5);
            while(pc_secim.Contains(pc_kart) && pc_tekrar < 5)
            {
                pc_kart = random.Next(5);
            }
            pc_secim.Add(pc_kart);
            while(pc_olu.Contains(pc_kart))
            {
                pc_kart = random.Next(5);
            }
            pc_list[pc_kart].BackColor= Color.Red;

            double pc_etki = etki(bilgisayar1.NesneListesi[pc_kart]);
            double player_etki = etki(kullanıcı1.NesneListesi[0]);
            a = katsayı(kullanıcı1.NesneListesi[0],bilgisayar1.NesneListesi[pc_kart]);
            double player_damage = player_etki / (a*pc_etki);
            a = katsayı(bilgisayar1.NesneListesi[pc_kart],kullanıcı1.NesneListesi[0]);
            double pc_damage = pc_etki /(a*player_etki);
            await Task.Delay(500);

            if(player_damage > pc_damage)
            {
                button1.BackColor = Color.Green;
                kullanıcı1.NesneListesi[0].durumGuncelle(0,20);
                kullanıcı1.NesneListesi[0] = upgrade_check(kullanıcı1.NesneListesi[0], kullanıcı1.NesneListesi[0].Dayaniklilik);
            }
            if(pc_damage>player_damage)
            {
                pc_list[pc_kart].BackColor = Color.Green;
                bilgisayar1.NesneListesi[pc_kart].durumGuncelle(0, 20);
                bilgisayar1.NesneListesi[pc_kart] = upgrade_check(bilgisayar1.NesneListesi[pc_kart], bilgisayar1.NesneListesi[pc_kart].Dayaniklilik);
            }
            await Task.Delay(500);

            kullanıcı1.NesneListesi[0].durumGuncelle(pc_damage,0);
            bilgisayar1.NesneListesi[pc_kart].durumGuncelle(player_damage,0);
            alive(kullanıcı1.NesneListesi[0], 0, false);
            kullanıcı1.NesneListesi[0].PuanGoster(label3,label13);
            alive(bilgisayar1.NesneListesi[pc_kart], pc_kart, true);
            pc_label_update(pc_kart);
            
            if (tekrar < 5)
            {
                button1.Enabled = false;
                button1.BackColor = Color.Blue;
            }
            tekrar++;
            if (pc_tekrar < 5)
            {
                pc_list[pc_kart].Enabled = false;
                pc_list[pc_kart].BackColor = Color.Blue;
            }
            pc_tekrar++;
            hamle++;
            tekrar_kont();
            hamle_kont();

            if (tekrar >= 5 && pc_olu.Contains(pc_kart) != true && player_olu.Contains(0) != true)
            {

                pc_list[pc_kart].BackColor = Color.White;
                pc_list[pc_kart].BackColor = Color.White;
                player_list[0].BackColor = Color.White;
                player_list[0].BackColor = Color.White;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            double a;
            button2.BackColor = Color.Red;
            Random random = new Random();
            int pc_kart = random.Next(5);
            while (pc_secim.Contains(pc_kart) && pc_tekrar < 5)
            {
                pc_kart = random.Next(5);
            }
            pc_secim.Add(pc_kart);
            while (pc_olu.Contains(pc_kart))
            {
                pc_kart = random.Next(5);
            }
            pc_list[pc_kart].BackColor = Color.Red;
          
            double pc_etki = etki(bilgisayar1.NesneListesi[pc_kart]);
            double player_etki = etki(kullanıcı1.NesneListesi[1]);
            a = katsayı(kullanıcı1.NesneListesi[1], bilgisayar1.NesneListesi[pc_kart]);
            double player_damage = player_etki / (a * pc_etki);
            a = katsayı(bilgisayar1.NesneListesi[pc_kart], kullanıcı1.NesneListesi[1]);
            double pc_damage = pc_etki / (a * player_etki);
            await Task.Delay(500);
        
            if (player_damage > pc_damage)
            {
                button2.BackColor = Color.Green;
                kullanıcı1.NesneListesi[1].durumGuncelle(0, 20);
                kullanıcı1.NesneListesi[1] = upgrade_check(kullanıcı1.NesneListesi[1], kullanıcı1.NesneListesi[1].Dayaniklilik);
            }
            if (pc_damage > player_damage)
            {
                pc_list[pc_kart].BackColor = Color.Green;
                bilgisayar1.NesneListesi[pc_kart].durumGuncelle(0, 20);
                bilgisayar1.NesneListesi[pc_kart] = upgrade_check(bilgisayar1.NesneListesi[pc_kart], bilgisayar1.NesneListesi[pc_kart].Dayaniklilik);
            }
            await Task.Delay(500);
           
            kullanıcı1.NesneListesi[1].durumGuncelle(pc_damage, 0);
            bilgisayar1.NesneListesi[pc_kart].durumGuncelle(player_damage, 0);
            alive(kullanıcı1.NesneListesi[1], 1, false);
            kullanıcı1.NesneListesi[1].PuanGoster(label4, label14);
            alive(bilgisayar1.NesneListesi[pc_kart], pc_kart, true);
            pc_label_update(pc_kart);

            if (tekrar < 5)
            {
                button2.Enabled = false;
                button2.BackColor = Color.Blue;
            }
            tekrar++;
            if (pc_tekrar < 5)
            {
                pc_list[pc_kart].Enabled = false;
                pc_list[pc_kart].BackColor = Color.Blue;
            }
            pc_tekrar++;
            hamle++;
            tekrar_kont();
            hamle_kont();

            if (tekrar >= 5 && pc_olu.Contains(pc_kart) != true && player_olu.Contains(1) != true)
            {

                pc_list[pc_kart].BackColor = Color.White;
                pc_list[pc_kart].BackColor = Color.White;
                player_list[1].BackColor = Color.White;
                player_list[1].BackColor = Color.White;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            double a;
            button3.BackColor = Color.Red;
            Random random = new Random();
            int pc_kart = random.Next(5);
            while (pc_secim.Contains(pc_kart) && pc_tekrar < 5)
            {
                pc_kart = random.Next(5);
            }
            pc_secim.Add(pc_kart);
            while (pc_olu.Contains(pc_kart))
            {
                pc_kart = random.Next(5);
            }
            pc_list[pc_kart].BackColor = Color.Red;

            double pc_etki = etki(bilgisayar1.NesneListesi[pc_kart]);
            double player_etki = etki(kullanıcı1.NesneListesi[2]);
            a = katsayı(kullanıcı1.NesneListesi[2], bilgisayar1.NesneListesi[pc_kart]);
            double player_damage = player_etki / (a * pc_etki);
            a = katsayı(bilgisayar1.NesneListesi[pc_kart], kullanıcı1.NesneListesi[2]);
            double pc_damage = pc_etki / (a * player_etki);
            await Task.Delay(500);

            if (player_damage > pc_damage)
            {
                button3.BackColor = Color.Green;
                kullanıcı1.NesneListesi[2].durumGuncelle(0, 20);
                kullanıcı1.NesneListesi[2] = upgrade_check(kullanıcı1.NesneListesi[2], kullanıcı1.NesneListesi[2].Dayaniklilik);
            }
            if (pc_damage > player_damage)
            {
                pc_list[pc_kart].BackColor = Color.Green;
                bilgisayar1.NesneListesi[pc_kart].durumGuncelle(0, 20);
                bilgisayar1.NesneListesi[pc_kart] = upgrade_check(bilgisayar1.NesneListesi[pc_kart], bilgisayar1.NesneListesi[pc_kart].Dayaniklilik);
            }
            await Task.Delay(500);

            kullanıcı1.NesneListesi[2].durumGuncelle(pc_damage, 0);
            bilgisayar1.NesneListesi[pc_kart].durumGuncelle(player_damage, 0);
            alive(kullanıcı1.NesneListesi[2], 2, false);
            kullanıcı1.NesneListesi[2].PuanGoster(label5, label15);
            alive(bilgisayar1.NesneListesi[pc_kart], pc_kart, true);
            pc_label_update(pc_kart);

            if (tekrar < 5)
            {
                button3.Enabled = false;
                button3.BackColor = Color.Blue;
            }
            tekrar++;
            if (pc_tekrar < 5)
            {
                pc_list[pc_kart].Enabled = false;
                pc_list[pc_kart].BackColor = Color.Blue;
            }
            pc_tekrar++;
            hamle++;
            tekrar_kont();
            hamle_kont();

            if (tekrar >= 5 && pc_olu.Contains(pc_kart) != true && player_olu.Contains(2) != true)
            {

                pc_list[pc_kart].BackColor = Color.White;
                pc_list[pc_kart].BackColor = Color.White;
                player_list[2].BackColor = Color.White;
                player_list[2].BackColor = Color.White;
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            double a;
            button4.BackColor = Color.Red;
            Random random = new Random();
            int pc_kart = random.Next(5);
            while (pc_secim.Contains(pc_kart) && pc_tekrar < 5)
            {
                pc_kart = random.Next(5);
            }
            pc_secim.Add(pc_kart);
            while (pc_olu.Contains(pc_kart))
            {
                pc_kart = random.Next(5);
            }
            pc_list[pc_kart].BackColor = Color.Red;

            double pc_etki = etki(bilgisayar1.NesneListesi[pc_kart]);
            double player_etki = etki(kullanıcı1.NesneListesi[3]);
            a = katsayı(kullanıcı1.NesneListesi[3], bilgisayar1.NesneListesi[pc_kart]);
            double player_damage = player_etki / (a * pc_etki);
            a = katsayı(bilgisayar1.NesneListesi[pc_kart], kullanıcı1.NesneListesi[3]);
            double pc_damage = pc_etki / (a * player_etki);
            await Task.Delay(500);

            if (player_damage > pc_damage)
            {
                button4.BackColor = Color.Green;
                kullanıcı1.NesneListesi[3].durumGuncelle(0, 20);
                kullanıcı1.NesneListesi[3] = upgrade_check(kullanıcı1.NesneListesi[3], kullanıcı1.NesneListesi[3].Dayaniklilik);
            }
            if (pc_damage > player_damage)
            {
                pc_list[pc_kart].BackColor = Color.Green;
                bilgisayar1.NesneListesi[pc_kart].durumGuncelle(0, 20);
                bilgisayar1.NesneListesi[pc_kart] = upgrade_check(bilgisayar1.NesneListesi[pc_kart], bilgisayar1.NesneListesi[pc_kart].Dayaniklilik);
            }
            await Task.Delay(500);

            kullanıcı1.NesneListesi[3].durumGuncelle(pc_damage, 0);
            bilgisayar1.NesneListesi[pc_kart].durumGuncelle(player_damage, 0);
            alive(kullanıcı1.NesneListesi[3], 3, false);
            kullanıcı1.NesneListesi[3].PuanGoster(label6, label16);
            alive(bilgisayar1.NesneListesi[pc_kart], pc_kart, true);
            pc_label_update(pc_kart);

            if (tekrar < 5)
            {
                button4.Enabled = false;
                button4.BackColor = Color.Blue;
            }
            tekrar++;
            if (pc_tekrar < 5)
            {
                pc_list[pc_kart].Enabled = false;
                pc_list[pc_kart].BackColor = Color.Blue;
            }
            pc_tekrar++;
            hamle++;
            tekrar_kont();
            hamle_kont();

            if (tekrar >= 5 && pc_olu.Contains(pc_kart) != true && player_olu.Contains(3) != true)
            {

                pc_list[pc_kart].BackColor = Color.White;
                pc_list[pc_kart].BackColor = Color.White;
                player_list[3].BackColor = Color.White;
                player_list[3].BackColor = Color.White;
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            double a;
            button5.BackColor = Color.Red;
            Random random = new Random();
            int pc_kart = random.Next(5);
            while (pc_secim.Contains(pc_kart) && pc_tekrar < 5)
            {
                pc_kart = random.Next(5);
            }
            pc_secim.Add(pc_kart);
            while (pc_olu.Contains(pc_kart))
            {
                pc_kart = random.Next(5);
            }
            pc_list[pc_kart].BackColor = Color.Red;

            double pc_etki = etki(bilgisayar1.NesneListesi[pc_kart]);
            double player_etki = etki(kullanıcı1.NesneListesi[4]);
            a = katsayı(kullanıcı1.NesneListesi[4], bilgisayar1.NesneListesi[pc_kart]);
            double player_damage = player_etki / (a * pc_etki);
            a = katsayı(bilgisayar1.NesneListesi[pc_kart], kullanıcı1.NesneListesi[4]);
            double pc_damage = pc_etki / (a * player_etki);
            await Task.Delay(500);

            if (player_damage > pc_damage)
            {
                button5.BackColor = Color.Green;
                kullanıcı1.NesneListesi[4].durumGuncelle(0, 20);
                kullanıcı1.NesneListesi[4] = upgrade_check(kullanıcı1.NesneListesi[4], kullanıcı1.NesneListesi[4].Dayaniklilik);
            }
            if (pc_damage > player_damage)
            {
                pc_list[pc_kart].BackColor = Color.Green;
                bilgisayar1.NesneListesi[pc_kart].durumGuncelle(0, 20);
                bilgisayar1.NesneListesi[pc_kart] = upgrade_check(bilgisayar1.NesneListesi[pc_kart], bilgisayar1.NesneListesi[pc_kart].Dayaniklilik);
            }
            await Task.Delay(500);

            kullanıcı1.NesneListesi[4].durumGuncelle(pc_damage, 0);
            bilgisayar1.NesneListesi[pc_kart].durumGuncelle(player_damage, 0);
            alive(kullanıcı1.NesneListesi[4], 4, false);
            kullanıcı1.NesneListesi[4].PuanGoster(label7, label17);
            alive(bilgisayar1.NesneListesi[pc_kart], pc_kart, true);
            pc_label_update(pc_kart);

            if (tekrar < 5)
            {
                button5.Enabled = false;
                button5.BackColor = Color.Blue;
            }
            tekrar++;
            if (pc_tekrar < 5)
            {
                pc_list[pc_kart].Enabled = false;
                pc_list[pc_kart].BackColor = Color.Blue;
            }
            pc_tekrar++;
            hamle++;
            tekrar_kont();
            hamle_kont();

            if (tekrar >= 5 && pc_olu.Contains(pc_kart) != true && player_olu.Contains(4) != true)
            {

                pc_list[pc_kart].BackColor = Color.White;
                pc_list[pc_kart].BackColor = Color.White;
                player_list[4].BackColor = Color.White;
                player_list[4].BackColor = Color.White;

            }
        }


    }
}

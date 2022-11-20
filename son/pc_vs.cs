using Microsoft.VisualBasic.ApplicationServices;
using Program;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace son
{
    public partial class pc_vs : UserControl
    {

        public UserControl user = new UserControl();
        public string winner;
        public Kullanıcı kullanıcı1 = new Kullanıcı();
        public Bilgisayar bilgisayar1 = new Bilgisayar();
        public Bilgisayar bilgisayar2 = new Bilgisayar();
        public Button[] player_list = new Button[5];
        public Button[] pc_list = new Button[5];
        public Label[] pc_label = new Label[10];
        public Label[] player_label = new Label[5];
        public List<int> pc_olu = new List<int>();
        public int player_olu = 0;
        public List<int> pc_secim = new List<int>();
        public int tekrar = 0, pc_tekrar = 0, hamle = 0;
        public pc_vs()
        {
            InitializeComponent();
        }

        private void pc_vs_Load(object sender, EventArgs e)
        {
            ad();
            nesnelist();
        }
        public void ad()
        {
            if (bilgisayar1.OyuncuAdi == null || bilgisayar1.OyuncuAdi == "")
                label1.Text = "Oyuncu 1";
            else
                label1.Text = bilgisayar1.OyuncuAdi;

            if (bilgisayar2.OyuncuAdi == null || bilgisayar2.OyuncuAdi == "")
                label2.Text = "Oyuncu 2";
            else
                label2.Text = bilgisayar2.OyuncuAdi;

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

            for (int i = 0; i < 5; i++)
            {
                if (bilgisayar1.NesneListesi[i].GetType() == typeof(Tas))
                {
                    player_list[i].Image = ımageList1.Images[2];
                }
                if (bilgisayar1.NesneListesi[i].GetType() == typeof(Kagit))
                {
                    player_list[i].Image = ımageList1.Images[1];
                }
                if (bilgisayar1.NesneListesi[i].GetType() == typeof(Makas))
                {
                    player_list[i].Image = ımageList1.Images[0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (bilgisayar2.NesneListesi[i].GetType() == typeof(Tas))
                {
                    pc_list[i].Image = ımageList1.Images[2];
                }
                if (bilgisayar2.NesneListesi[i].GetType() == typeof(Kagit))
                {
                    pc_list[i].Image = ımageList1.Images[1];
                }
                if (bilgisayar2.NesneListesi[i].GetType() == typeof(Makas))
                {
                    pc_list[i].Image = ımageList1.Images[0];
                }
            }
        }

        public void pc_label_update(int x)
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

            bilgisayar1.NesneListesi[x].PuanGoster(pc_label[x], pc_label[x + 5]);

        }

        public double etki(dynamic nesne)
        {
            double etki1 = 0;
            if (nesne.GetType() == typeof(Tas))
            {
                etki1 = nesne.etkiHesapla();
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
            if (pc)
            {
                if (nesne.Dayaniklilik <= 0)
                {
                    pc_list[x].BackColor = Color.Black;
                    pc_list[x].Enabled = false;
                    nesne.Dayaniklilik = 0;
                    pc_olu.Add(x);
                }
            }
            else
            {
                if (nesne.Dayaniklilik <= 0)
                {
                    player_list[x].BackColor = Color.Black;
                    player_list[x].Enabled = false;
                    nesne.Dayaniklilik = 0;
                    player_olu++;
                }
            }
            if (pc_olu.Count == 5)
            {
                winner = "Kazanan " + label1.Text;
                this.Visible = false;
                user.Visible = true;
            }
            if (player_olu == 5)
            {
                winner = "Kazanan " + label2.Text;
                this.Visible = false;
                user.Visible = true;

            }
        }

        public async void tekra8r_kont()
        {
            await Task.Delay(50);
            if (pc_tekrar == 5)
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
            for (int i = 0; i < 5; i++)
            {
                skor += nesne.NesneListesi[i].Dayaniklilik;
            }
            return skor;
        }

        public void hamle_kont()
        {
            if (hamle == 10 && pc_olu.Count < 5 && player_olu < 5)
            {
                double skor1 = skor_bul(kullanıcı1);
                double skor2 = skor_bul(bilgisayar1);
                if (skor1 > skor2)
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
            if (nesne.SeviyePuan > 30)
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

    }
}

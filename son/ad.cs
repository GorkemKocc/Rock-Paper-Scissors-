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
    public partial class ad : UserControl
    {
        public ad()
        {
            InitializeComponent();
        }
        
        private void ad_Load(object sender, EventArgs e)
        {

        }
        
        public UserControl user = new UserControl();
        public UserControl user1 = new UserControl();
        public Kullanıcı kullanıcı1 = new Kullanıcı();
        public Bilgisayar bilgisayar1 = new Bilgisayar();
        public Bilgisayar bilgisayar2 = new Bilgisayar();
       
        
        public void pc_random_nesne_secim(dynamic nesne)
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
        private void button1_Click(object sender, EventArgs e)//kullanıcı
        {
            kullanıcı1.OyuncuAdi = textBox1.Text;
            kullanıcı1.OyuncuID = 1;
            bilgisayar1.OyuncuAdi= textBox2.Text;
            bilgisayar1.OyuncuID = 2;
            pc_random_nesne_secim(bilgisayar1);
            user.Visible = true;
            this.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)//pc
        {
            bilgisayar1.OyuncuAdi = textBox1.Text;
            bilgisayar1.OyuncuID = 1;
            pc_random_nesne_secim(bilgisayar1);
            bilgisayar2.OyuncuAdi = textBox2.Text;
            bilgisayar2.OyuncuID = 2;
            pc_random_nesne_secim(bilgisayar2);
            user1.Visible = true;
            this.Visible = false;
            
        }

        
    }
}

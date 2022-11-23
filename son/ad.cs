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
        public UserControl user = new UserControl();
        public UserControl user1 = new UserControl();
        public Kullanıcı kullanıcı1 = new Kullanıcı();
        public Bilgisayar bilgisayar1 = new Bilgisayar();
        public Bilgisayar bilgisayar2 = new Bilgisayar();
        public Label p1 = new Label();
        public Label p2 = new Label();


        public ad()
        {
            InitializeComponent();
        }
        
        private void ad_Load(object sender, EventArgs e)
        {

        }


   
        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcı1.OyuncuAdi = textBox1.Text;
            kullanıcı1.OyuncuID = 1;
            bilgisayar1.OyuncuAdi= textBox2.Text;
            bilgisayar1.OyuncuID = 2;
            bilgisayar1.NesneSec(bilgisayar1);
            user.Visible = true;
            this.Visible = false;
            p1.Text= textBox1.Text;
            p2.Text= textBox2.Text;
            if (p1.Text == null || p1.Text == "")
                p1.Text = "Oyuncu1";

            if (p2.Text == null || p2.Text == "")
                p2.Text = "Oyuncu2";
                

        }

        private void button2_Click(object sender, EventArgs e)//pc
        {
            bilgisayar1.OyuncuAdi = textBox1.Text;
            bilgisayar1.OyuncuID = 1;
            bilgisayar1.NesneSec(bilgisayar1);
            bilgisayar2.OyuncuAdi = textBox2.Text;
            bilgisayar2.OyuncuID = 2;
            bilgisayar2.NesneSec(bilgisayar2);
            user1.Visible = true;
            this.Visible = false;
            p1.Text = textBox1.Text;
            p2.Text = textBox2.Text;
            if (p1.Text == null || p1.Text == "")
                p1.Text = "Oyuncu1";

            if (p2.Text == null || p2.Text == "")
                p2.Text = "Oyuncu2";
        }

        
    }
}

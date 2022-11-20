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
    public partial class secim : UserControl
    {   
        public UserControl user = new UserControl();
        public Kullanıcı kullanıcı1 = new Kullanıcı();
        public Bilgisayar bilgisayar1 = new Bilgisayar();
        public int i = 0,a=4;
        public secim()
        {
            InitializeComponent();
        }

        private void secim_Load(object sender, EventArgs e)
        {
            
        }

        private void Tas_Click(object sender, EventArgs e)
        {   
            dynamic tas= new Tas();
            kullanıcı1.NesneSec(tas);
            label2.Text ="KALAN NESNE " + a.ToString();
            a--;
            if (a==-1)
            {
                user.Visible = true;
                this.Visible = false;
            }   
        }

        private void kagit_Click(object sender, EventArgs e)
        {
            dynamic kagit = new Kagit();
            kullanıcı1.NesneSec(kagit);
            label2.Text = "KALAN NESNE " + a.ToString();
            a--;
            if (a == -1)
            {
                user.Visible = true;
                this.Visible = false;
            }
        }

        private void makas_Click(object sender, EventArgs e)
        {
            dynamic makas = new Makas();
            kullanıcı1.NesneSec(makas);
            label2.Text="KALAN NESNE" + a.ToString();
            a--;
            if (a == -1)
            {
                user.Visible = true;
                this.Visible = false;
            }

        }

    }
}

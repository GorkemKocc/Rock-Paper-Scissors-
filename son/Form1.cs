using Program;

namespace son
{
    public partial class Form1 : Form
    {
        public UserControl user = new UserControl();
        public Kullanıcı kullanıcı11 = new Kullanıcı();
        public Bilgisayar bilgisayar11 = new Bilgisayar();
        public Bilgisayar bilgisayar22 = new Bilgisayar();
        public Label p11= new Label();
        public Label p22= new Label();
        public bool pc;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void anasayfa1_Load(object sender, EventArgs e)
        {
            anasayfa1.user = userControl11;     
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {   
            userControl11.user = secim1;
            userControl11.user1= pc_vs1;
            userControl11.kullanıcı1 = kullanıcı11;
            userControl11.bilgisayar1 = bilgisayar11;
            userControl11.bilgisayar2= bilgisayar22;
            pc_vs1.bilgisayar1 = bilgisayar11;
            pc_vs1.bilgisayar2 = bilgisayar22;
        }

        private void secim1_Load(object sender, EventArgs e)
        {   
            
            secim1.user=vs1;
            secim1.kullanıcı1 = kullanıcı11;
            secim1.bilgisayar1= bilgisayar11;   
           
        }
        
        private void vs1_Load(object sender, EventArgs e)
        {       
            p11 = userControl11.p1;
            p22 = userControl11.p2;
            vs1.user = winner1;
            vs1.kullanıcı1 = kullanıcı11;
            vs1.bilgisayar1 = bilgisayar11;
            vs1.bilgisayar2 = bilgisayar22;
            vs1.ad();
            vs1.nesnelist();
            pc = false;
        }
        
        private void pc_vs1_Load(object sender, EventArgs e)
        {
            p11 = userControl11.p1;
            p22 = userControl11.p2;
            pc_vs1.user = winner1;
            pc = true;
        }

        private void winner1_Load(object sender, EventArgs e)
        {
            if (pc)
            {
                winner1.label1.Text = pc_vs1.winner;
                winner1.label4.Text = p11.Text + " " + pc_vs1.skor1;    
                winner1.label5.Text = p22.Text + " " + pc_vs1.skor2;
            }
            else
            {
                winner1.label1.Text = vs1.winner;
                winner1.label4.Text = p11.Text + " " + vs1.skor1;
                winner1.label5.Text = p22.Text + " " + vs1.skor2;
                
            }
        }
        
    }
}
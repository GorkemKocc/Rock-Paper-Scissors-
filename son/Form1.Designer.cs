namespace son
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.anasayfa1 = new son.Anasayfa();
            this.userControl11 = new son.ad();
            this.secim1 = new son.secim();
            this.vs1 = new son.vs();
            this.winner1 = new son.winner();
            this.pc_vs1 = new son.pc_vs();
            this.SuspendLayout();
            // 
            // anasayfa1
            // 
            this.anasayfa1.BackColor = System.Drawing.Color.Silver;
            this.anasayfa1.Location = new System.Drawing.Point(-9, -37);
            this.anasayfa1.Name = "anasayfa1";
            this.anasayfa1.Size = new System.Drawing.Size(906, 555);
            this.anasayfa1.TabIndex = 0;
            this.anasayfa1.Load += new System.EventHandler(this.anasayfa1_Load);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Silver;
            this.userControl11.Location = new System.Drawing.Point(-9, -37);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(897, 555);
            this.userControl11.TabIndex = 1;
            this.userControl11.Visible = false;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // secim1
            // 
            this.secim1.BackColor = System.Drawing.Color.Silver;
            this.secim1.Location = new System.Drawing.Point(-9, -8);
            this.secim1.Name = "secim1";
            this.secim1.Size = new System.Drawing.Size(897, 490);
            this.secim1.TabIndex = 2;
            this.secim1.Visible = false;
            this.secim1.Load += new System.EventHandler(this.secim1_Load);
            // 
            // vs1
            // 
            this.vs1.BackColor = System.Drawing.Color.Silver;
            this.vs1.Location = new System.Drawing.Point(-9, 1);
            this.vs1.Name = "vs1";
            this.vs1.Size = new System.Drawing.Size(906, 474);
            this.vs1.TabIndex = 3;
            this.vs1.Visible = false;
            this.vs1.Load += new System.EventHandler(this.vs1_Load);
            // 
            // winner1
            // 
            this.winner1.BackColor = System.Drawing.Color.Silver;
            this.winner1.Location = new System.Drawing.Point(-9, 1);
            this.winner1.Name = "winner1";
            this.winner1.Size = new System.Drawing.Size(906, 474);
            this.winner1.TabIndex = 4;
            this.winner1.Visible = false;
            this.winner1.Load += new System.EventHandler(this.winner1_Load);
            // 
            // pc_vs1
            // 
            this.pc_vs1.BackColor = System.Drawing.Color.Silver;
            this.pc_vs1.Location = new System.Drawing.Point(-9, 1);
            this.pc_vs1.Name = "pc_vs1";
            this.pc_vs1.Size = new System.Drawing.Size(906, 474);
            this.pc_vs1.TabIndex = 5;
            this.pc_vs1.Visible = false;
            this.pc_vs1.Load += new System.EventHandler(this.pc_vs1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 471);
            this.Controls.Add(this.pc_vs1);
            this.Controls.Add(this.winner1);
            this.Controls.Add(this.vs1);
            this.Controls.Add(this.secim1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.anasayfa1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Anasayfa anasayfa1;
        private ad userControl11;
        private secim secim1;
        private vs vs1;
        private winner winner1;
        private pc_vs pc_vs1;
    }
}
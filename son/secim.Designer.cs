namespace son
{
    partial class secim
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(secim));
            this.kagit = new System.Windows.Forms.Button();
            this.makas = new System.Windows.Forms.Button();
            this.Tas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kagit
            // 
            this.kagit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kagit.BackgroundImage")));
            this.kagit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kagit.Location = new System.Drawing.Point(400, 223);
            this.kagit.Name = "kagit";
            this.kagit.Size = new System.Drawing.Size(150, 100);
            this.kagit.TabIndex = 0;
            this.kagit.UseVisualStyleBackColor = true;
            this.kagit.Click += new System.EventHandler(this.kagit_Click);
            // 
            // makas
            // 
            this.makas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("makas.BackgroundImage")));
            this.makas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.makas.Location = new System.Drawing.Point(620, 223);
            this.makas.Name = "makas";
            this.makas.Size = new System.Drawing.Size(150, 100);
            this.makas.TabIndex = 1;
            this.makas.UseVisualStyleBackColor = true;
            this.makas.Click += new System.EventHandler(this.makas_Click);
            // 
            // Tas
            // 
            this.Tas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tas.BackgroundImage")));
            this.Tas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Tas.Location = new System.Drawing.Point(174, 223);
            this.Tas.Name = "Tas";
            this.Tas.Size = new System.Drawing.Size(150, 100);
            this.Tas.TabIndex = 2;
            this.Tas.UseVisualStyleBackColor = true;
            this.Tas.Click += new System.EventHandler(this.Tas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "5 OYUN NESNESİ SEÇİNİZ\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(316, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 72);
            this.label2.TabIndex = 4;
            this.label2.Text = "KALAN NESNE 5\r\n\r\n";
       
            // 
            // secim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tas);
            this.Controls.Add(this.makas);
            this.Controls.Add(this.kagit);
            this.Name = "secim";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.secim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button kagit;
        private Button makas;
        private Button Tas;
        private Label label1;
        private Label label2;
    }
}

namespace StokTakip
{
    partial class TelefonEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelefonEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_Modelkodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_Fiyat = new System.Windows.Forms.NumericUpDown();
            this.txt_IMEI1 = new System.Windows.Forms.TextBox();
            this.txt_IMEI2 = new System.Windows.Forms.TextBox();
            this.Telefonekle1 = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            this.cb_Marka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txt_isim
            // 
            resources.ApplyResources(this.txt_isim, "txt_isim");
            this.txt_isim.Name = "txt_isim";
            // 
            // txt_Modelkodu
            // 
            resources.ApplyResources(this.txt_Modelkodu, "txt_Modelkodu");
            this.txt_Modelkodu.Name = "txt_Modelkodu";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // nud_Fiyat
            // 
            resources.ApplyResources(this.nud_Fiyat, "nud_Fiyat");
            this.nud_Fiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_Fiyat.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Fiyat.Name = "nud_Fiyat";
            this.nud_Fiyat.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txt_IMEI1
            // 
            resources.ApplyResources(this.txt_IMEI1, "txt_IMEI1");
            this.txt_IMEI1.Name = "txt_IMEI1";
            // 
            // txt_IMEI2
            // 
            resources.ApplyResources(this.txt_IMEI2, "txt_IMEI2");
            this.txt_IMEI2.Name = "txt_IMEI2";
            // 
            // Telefonekle1
            // 
            resources.ApplyResources(this.Telefonekle1, "Telefonekle1");
            this.Telefonekle1.Name = "Telefonekle1";
            this.Telefonekle1.UseVisualStyleBackColor = true;
            this.Telefonekle1.Click += new System.EventHandler(this.Telefonekle1_Click);
            // 
            // Temizle
            // 
            resources.ApplyResources(this.Temizle, "Temizle");
            this.Temizle.Name = "Temizle";
            this.Temizle.UseVisualStyleBackColor = true;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // cb_Marka
            // 
            resources.ApplyResources(this.cb_Marka, "cb_Marka");
            this.cb_Marka.FormattingEnabled = true;
            this.cb_Marka.Name = "cb_Marka";
            // 
            // TelefonEkle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_Marka);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.Telefonekle1);
            this.Controls.Add(this.txt_IMEI2);
            this.Controls.Add(this.txt_IMEI1);
            this.Controls.Add(this.nud_Fiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Modelkodu);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelefonEkle";
            this.Load += new System.EventHandler(this.TelefonEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Fiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_Modelkodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_Fiyat;
        private System.Windows.Forms.TextBox txt_IMEI1;
        private System.Windows.Forms.TextBox txt_IMEI2;
        private System.Windows.Forms.Button Telefonekle1;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.ComboBox cb_Marka;
    }
}
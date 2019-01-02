namespace StokTakip
{
    partial class Telefonlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telefonlar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_Marka = new System.Windows.Forms.ComboBox();
            this.cb_Modelkodu = new System.Windows.Forms.ComboBox();
            this.SeciliTelefonSil = new System.Windows.Forms.Button();
            this.YeniTelefonEkle1 = new System.Windows.Forms.Button();
            this.Ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            // 
            // cb_Marka
            // 
            resources.ApplyResources(this.cb_Marka, "cb_Marka");
            this.cb_Marka.FormattingEnabled = true;
            this.cb_Marka.Name = "cb_Marka";
            this.cb_Marka.SelectedIndexChanged += new System.EventHandler(this.cb_Marka_SelectedIndexChanged);
            // 
            // cb_Modelkodu
            // 
            resources.ApplyResources(this.cb_Modelkodu, "cb_Modelkodu");
            this.cb_Modelkodu.FormattingEnabled = true;
            this.cb_Modelkodu.Name = "cb_Modelkodu";
            // 
            // SeciliTelefonSil
            // 
            resources.ApplyResources(this.SeciliTelefonSil, "SeciliTelefonSil");
            this.SeciliTelefonSil.Name = "SeciliTelefonSil";
            this.SeciliTelefonSil.UseVisualStyleBackColor = true;
            this.SeciliTelefonSil.Click += new System.EventHandler(this.SeciliTelefonSil_Click);
            // 
            // YeniTelefonEkle1
            // 
            resources.ApplyResources(this.YeniTelefonEkle1, "YeniTelefonEkle1");
            this.YeniTelefonEkle1.Name = "YeniTelefonEkle1";
            this.YeniTelefonEkle1.UseVisualStyleBackColor = true;
            this.YeniTelefonEkle1.Click += new System.EventHandler(this.YeniTelefonEkle1_Click);
            // 
            // Ara
            // 
            resources.ApplyResources(this.Ara, "Ara");
            this.Ara.BackgroundImage = global::StokTakip.Properties.Resources.search_128;
            this.Ara.Name = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // Telefonlar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YeniTelefonEkle1);
            this.Controls.Add(this.SeciliTelefonSil);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.cb_Modelkodu);
            this.Controls.Add(this.cb_Marka);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Telefonlar";
            this.Load += new System.EventHandler(this.Telefonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_Marka;
        private System.Windows.Forms.Button YeniTelefonEkle;
        private System.Windows.Forms.ComboBox cb_Modelkodu;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.Button SeciliTelefonSil;
        private System.Windows.Forms.Button YeniTelefonEkle1;
    }
}
namespace StokTakip
{
    partial class PhoneCaseManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneCaseManage));
            this.StokEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StokSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StokEkle
            // 
            resources.ApplyResources(this.StokEkle, "StokEkle");
            this.StokEkle.Name = "StokEkle";
            this.StokEkle.UseVisualStyleBackColor = true;
            this.StokEkle.Click += new System.EventHandler(this.StokEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // StokSil
            // 
            resources.ApplyResources(this.StokSil, "StokSil");
            this.StokSil.Name = "StokSil";
            this.StokSil.UseVisualStyleBackColor = true;
            this.StokSil.Click += new System.EventHandler(this.StokSil_Click);
            // 
            // PhoneCaseManage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StokSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StokEkle);
            this.Name = "PhoneCaseManage";
            this.Load += new System.EventHandler(this.PhoneCaseManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StokEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StokSil;
    }
}
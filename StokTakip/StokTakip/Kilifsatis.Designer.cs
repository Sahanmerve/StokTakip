namespace StokTakip
{
    partial class Kilifsatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kilifsatis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nm_adet = new System.Windows.Forms.NumericUpDown();
            this.cb_kılıf = new System.Windows.Forms.ComboBox();
            this.btn_kilifsatis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_adet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
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
            // nm_adet
            // 
            resources.ApplyResources(this.nm_adet, "nm_adet");
            this.nm_adet.Name = "nm_adet";
            // 
            // cb_kılıf
            // 
            resources.ApplyResources(this.cb_kılıf, "cb_kılıf");
            this.cb_kılıf.FormattingEnabled = true;
            this.cb_kılıf.Name = "cb_kılıf";
            this.cb_kılıf.SelectedIndexChanged += new System.EventHandler(this.cb_kılıf_SelectedIndexChanged);
            // 
            // btn_kilifsatis
            // 
            resources.ApplyResources(this.btn_kilifsatis, "btn_kilifsatis");
            this.btn_kilifsatis.Name = "btn_kilifsatis";
            this.btn_kilifsatis.UseVisualStyleBackColor = true;
            this.btn_kilifsatis.Click += new System.EventHandler(this.btn_kilifsatis_Click);
            // 
            // Kilifsatis
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_kilifsatis);
            this.Controls.Add(this.cb_kılıf);
            this.Controls.Add(this.nm_adet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kilifsatis";
            this.Load += new System.EventHandler(this.Kilifsatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nm_adet;
        private System.Windows.Forms.ComboBox cb_kılıf;
        private System.Windows.Forms.Button btn_kilifsatis;
    }
}
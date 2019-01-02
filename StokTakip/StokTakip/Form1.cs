using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Markalar m = new Markalar();
            m.MdiParent = this;
            m.Show();
        }

        private void telefonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefonlar t = new Telefonlar();
            t.MdiParent = this;
            t.Show();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayar.ChangedLanguage(Language.tr);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayar.ChangedLanguage(Language.en);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PhoneCaseManage pc = new PhoneCaseManage();
            pc.MdiParent = this;
            pc.Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void telefonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satis s = new Satis();
            s.MdiParent = this;
            s.Show();
        }

        private void kılıfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kilifsatis s = new Kilifsatis();
            s.MdiParent = this;
            s.Show();
        }
    }
}

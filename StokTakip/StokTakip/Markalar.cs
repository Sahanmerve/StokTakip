using StokTakip.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Markalar : Form
    {
        public Markalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brand b1 = new Brand();
            b1.BrandName = textBox1.Text;
            BrandRepo b = new BrandRepo();
            b.InsertBrand(b1);
            RefreshListBox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
  
            BrandRepo b1 = new BrandRepo();
            b1.DeleteBrand((int)listBox1.SelectedValue);

            RefreshListBox();
           
        }

        private void Markalar_Load(object sender, EventArgs e)
        {
            RefreshListBox();
            

        }

        public void RefreshListBox()
        {
            listBox1.DisplayMember = "BrandName";
            listBox1.ValueMember = "BrandID";
            BrandRepo b1 = new BrandRepo();
            listBox1.DataSource = b1.GetBrands();

        }
    }
}

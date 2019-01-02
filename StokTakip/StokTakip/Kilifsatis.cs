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
    public partial class Kilifsatis : Form
    {
        public Kilifsatis()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();

      
        private void cb_kılıf_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _uw.PhoneCases.GetPhoneCases();
        }

        private void FillPhoneCasesCombo()
        {
            cb_kılıf.DataSource = null;
            cb_kılıf.DisplayMember = "ProductName";
            cb_kılıf.ValueMember = "ProductID";
            cb_kılıf.DataSource = _uw.PhoneCases.GetPhoneCases();
        }

        private void btn_kilifsatis_Click(object sender, EventArgs e)
        {
            int id = (int)cb_kılıf.SelectedValue;
            int qty = (int)nm_adet.Value;
            _uw.PhoneCases.ReduceStock1(id, qty);
            RefreshMainGrid();
            FillPhoneCasesCombo();
        }
        public void RefreshMainGrid()
        {
            Kilifsatis f = (Kilifsatis)Application.OpenForms["Kilifsatis"];
            if (f != null)
            {
                f.FillGrid();
            }
        }
        public void FillGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _uw.PhoneCases.GetPhoneCases();

        }

        private void Kilifsatis_Load(object sender, EventArgs e)
        {
            FillPhoneCasesCombo();
            
        }
    }
}

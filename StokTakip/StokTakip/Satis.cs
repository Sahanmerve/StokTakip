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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
   
        }
        UnitOfWork _uw = new UnitOfWork();
        private void txt_IMEI1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _uw.Phone.SearchPhone1(txt_IMEI1.Text);
        }

        private void btn_sat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                var id =(string)item.Cells["IMEI1"].Value;
                _uw.Phone.ReduceStock(id);
            }
            FillGrid();
        }
        public void FillGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _uw.Phone.GetPhonesForDisplay();

        }

        private void Satis_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}

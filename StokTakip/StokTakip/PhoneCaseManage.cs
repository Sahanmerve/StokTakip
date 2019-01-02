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
    public partial class PhoneCaseManage : Form
    {
        PhoneCaseRepo pcr = new PhoneCaseRepo();
        UnitOfWork _uw = new UnitOfWork();
        public PhoneCaseManage()
        {
            InitializeComponent();
        }
        public void FillGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _uw.PhoneCases.GetPhoneCases();

        }

        private void PhoneCaseManage_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void StokEkle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count==0)
            {
                new PhonesCaseCreate().Show();
            }
            else
            {
                int secilenid = (int)dataGridView1.SelectedRows[0].Cells["ProductID"].Value;
                PhonesCaseCreate f = new PhonesCaseCreate();
                f.Show();
                f.SelectPhoneCase(secilenid);
            }
            
            
        }

        private void StokSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = (int)item.Cells["ProductID"].Value;
                _uw.PhoneCases.Delete(id);
            }
            FillGrid();

        }
    }
}

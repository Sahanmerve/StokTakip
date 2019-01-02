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
    public partial class Telefonlar : Form
    {
        public Telefonlar()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        private void YeniTelefonEkle1_Click(object sender, EventArgs e)
        {
            new TelefonEkle().Show();
        }

        private void SeciliTelefonSil_Click(object sender, EventArgs e)
        {
            PhoneRepo b1 = new PhoneRepo();
            b1.DeletePhone((int)dataGridView1.DataSource);

        }

        private void Telefonlar_Load(object sender, EventArgs e)
        {
            UIHelper.FillBrandsComboBox(cb_Marka,Properties.Resources.AllBrands);
            UIHelperPhone.FillPhoneComboBox(cb_Modelkodu,"");
        }

        private void cb_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _uw.Phone.GetPhonesForDisplay();
        }
       
        public void FillPhonesGrid()
        {

            dataGridView1.DataSource = _uw.Phone.GetPhonesForDisplay();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var chosenBranId = (int)cb_Marka.SelectedValue;
            dataGridView1.DataSource = _uw.Phone.SearchPhone((int)cb_Marka.SelectedValue,cb_Modelkodu.Text);
        }
    }
}

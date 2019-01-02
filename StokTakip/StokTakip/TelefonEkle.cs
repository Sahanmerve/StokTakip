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
    public partial class TelefonEkle : Form
    {
        public TelefonEkle()
        {
            InitializeComponent();
        }
        UnitOfWork _uw = new UnitOfWork();
        private void Telefonekle1_Click(object sender, EventArgs e)
        {
            Phone p = new Phone();
            p.Brand = (Brand)cb_Marka.SelectedItem;
            p.ProductName = txt_isim.Text;
            p.IMEI1 = txt_IMEI1.Text;
            p.IMEI2 = txt_IMEI2.Text;
            p.Price = nud_Fiyat.Value;
            p.ModelCode = txt_Modelkodu.Text;
            _uw.Phone.InsertPhone(p);

            RefreshMainPhoneGrid();

        }

        private void RefreshMainPhoneGrid()
        {
            Form openForm = Application.OpenForms["Telefonlar"];
            Telefonlar pcForm = (Telefonlar)openForm;
            pcForm.FillPhonesGrid();
        }

        private void TelefonEkle_Load(object sender, EventArgs e)
        {
            UIHelper.FillBrandsComboBox(cb_Marka,Properties.Resources.Choose);
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            cb_Marka.SelectedIndex = 0;
            txt_IMEI1.Clear();
            txt_IMEI2.Clear();
            txt_isim.Clear();
            txt_Modelkodu.Clear();
            nud_Fiyat.Value = 1000;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{

    public partial class PhonesCaseCreate : Form
    {
        public PhonesCaseCreate()
        {
            InitializeComponent();

        }
        public void SelectPhoneCase(int id)
        {
            tabControl1.SelectTab(1);
            comboBox1.SelectedValue = id;
        }
        UnitOfWork _uw = new UnitOfWork();


        private void PhonesCaseCreate_Load(object sender, EventArgs e)
        {
            FillColorsCombo();
            FillPhoneCasesCombo();
            RefreshCurrentstock();
        }

        private void FillPhoneCasesCombo()
        {
            comboBox1.DataSource = null;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";
            comboBox1.DataSource = _uw.PhoneCases.GetPhoneCases();
        }

        private void FillColorsCombo()
        {
            Type T = typeof(CaseColor);
            List<string> options;
            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en")
            {
                options = T.GetEnumNames().ToList();
            }
            else
            {
                var attrs = T.GetFields().SelectMany(x => x.CustomAttributes);
                var attrNames = attrs.SelectMany(x => x.ConstructorArguments);
                options = attrNames.Select(x => (string)x.Value).ToList();
            }
            cb_Color.DataSource = options;
        }

        private void Telefonekle1_Click(object sender, EventArgs e)
        {
            PhoneCase pc = new PhoneCase();
            pc.ProductName = txt_isim.Text;
            pc.CaseColor = (CaseColor)cb_Color.SelectedIndex;
            pc.Price = nud_Fiyat.Value;
            pc.StockQTY = (int)numericUpDown2.Value;
            _uw.PhoneCases.InsertPhoneCases(pc);
            RefreshMainGrid();
            FillPhoneCasesCombo();




        }
        public void RefreshMainGrid()
        {
            PhoneCaseManage f = (PhoneCaseManage)Application.OpenForms["PhoneCaseManage"];
            if (f != null)
            {
                f.FillGrid();
            }
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            txt_isim.Clear();
            nud_Fiyat.Value = 0;
            numericUpDown2.Value = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedValue;
            int qty = (int)numericUpDown1.Value;
            _uw.PhoneCases.AddStockToPhoneCase(id, qty);
            RefreshMainGrid();
            FillPhoneCasesCombo();

        }
        public void RefreshCurrentstock()
        {
            if (comboBox1.SelectedItem==null)
            {
                return;
            }
            string template = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en" ? "Stock will be update as 0 when saved." : "Kaydettiğinizde adet 0 olarak güncellenecektir.";
            var choosenCase = (PhoneCase)comboBox1.SelectedItem;
            var CurrentStock = choosenCase.StockQTY;
            int latest = CurrentStock + (int)numericUpDown1.Value;
            label5.Text = template.Replace("0", latest.ToString());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCurrentstock();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            RefreshCurrentstock();
        }

        private void numericUpDown1_Scroll(object sender, ScrollEventArgs e)
        {
            RefreshCurrentstock();
        }
    }
}

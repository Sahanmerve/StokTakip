using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    static class UIHelperPhone
    {
        static UnitOfWork _uw = new UnitOfWork();
        public static void FillPhoneComboBox(ComboBox cb,string firstOption)
        {
            cb.DisplayMember = "ModelCode";
            cb.ValueMember = "ProductID";
            var liste = _uw.Phone.GetPhones();
            Phone p = new Phone() { ProductID = 0, ProductName = "" };
            liste.Insert(0, p);
            cb.DataSource = liste;
        }
    }
}

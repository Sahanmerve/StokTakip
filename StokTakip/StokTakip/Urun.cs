using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    abstract class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

    }

    class Phone : Product
    {
        public string IMEI1 { get; set; }
        public string IMEI2 { get; set; }
        public Brand Brand { get; set; }
        public string ModelCode { get; set; }


    }

    class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }

    }
    class PhoneCase : Product
    {
        public CaseColor CaseColor { get; set; }
        public int StockQTY { get; set; }


    }
    public enum CaseColor
    {
        [Description("Siyah")]
        Black,
        [Description("Altın")]
        Gold,
        [Description("Beyaz")]
        White
    }
}

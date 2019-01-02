using StokTakip.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class UnitOfWork
    {
        public BrandRepo Brands { get; set; }

        public PhoneRepo Phone { get; set; }
        public PhoneCaseRepo PhoneCases { get; set; }

        public UnitOfWork()
        {
            Brands = new BrandRepo();
            Phone = new PhoneRepo();
            PhoneCases = new PhoneCaseRepo();
        }
    }
}

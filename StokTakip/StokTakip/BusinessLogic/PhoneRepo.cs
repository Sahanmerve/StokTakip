using StokTakip.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class PhoneRepo
    {
        public List<Phone> GetPhones()
        {
            List<Phone> list = new List<Phone>();
            DataTable dt = Program.SqlHelper.GetTable("exec GetPhones");
            foreach (DataRow row in dt.Rows)
            {
                Phone p = new Phone();
                p.ProductID = (int)row["PhoneID"]; // unboxing
                p.ProductName = row["ProductName"].ToString();
                p.Price = (decimal)row["Price"];
                p.IMEI1 = row["IMEI1"].ToString();
                p.IMEI2 = row["IMEI2"].ToString();
                p.ModelCode = row["ModelCode"].ToString();
                p.Brand = new Brand();
                p.Brand.BrandName = (string)row["BrandName"];
                p.Brand.BrandID = (int)row["BrandID"];
                list.Add(p);
            }
            return list;
            
        }

        public void InsertPhone(Phone newPhone)
        {
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "ProductName";
            p1.Value = newPhone.ProductName;
            SqlParameter p2 = new SqlParameter("Price",newPhone.Price);
            SqlParameter p3 = new SqlParameter("IMEI1",newPhone.IMEI1);
            SqlParameter p4 = new SqlParameter("IMEI2", newPhone.IMEI2);
            SqlParameter p5 = new SqlParameter("ModelCode", newPhone.ModelCode);
            SqlParameter p6 = new SqlParameter("BrandID", newPhone.Brand.BrandID);


            Program.SqlHelper.ExecuteProc("InsertPhone",p1,p2,p3,p4,p5,p6);
        }
        public void DeletePhone(int PhoneId)
        {
            Program.SqlHelper.ExecuteProc("DeletePhone",PhoneId);
        }
        public List<PhoneViewModel> GetPhonesForDisplay()
        {
            List<PhoneViewModel> list = new List<PhoneViewModel>();
            DataTable dt = Program.SqlHelper.GetTable("exec GetPhones");
            foreach (DataRow row in dt.Rows)
            {
                PhoneViewModel p = new PhoneViewModel();
                p.PhoneID = (int)row["PhoneID"]; // unboxing
                p.Name = row["ProductName"].ToString();
                p.Price = ((decimal)row["Price"]).ToString("C");
                p.IMEI1 = row["IMEI1"].ToString();
                //p.IMEI2 = row["IMEI2"].ToString();
                p.ModelCode = row["ModelCode"].ToString();
                p.Brand = (string)row["BrandName"];
                list.Add(p);
            }
            return list;

        }
        public List<PhoneViewModel> SearchPhone(int BrandId=0,string ModelCode="")
        {
            List<PhoneViewModel> list = new List<PhoneViewModel>();
            var dt = Program.SqlHelper.GetTable("exec SearcPhone "+BrandId+",'"+ModelCode+ "'");
            foreach (DataRow row in dt.Rows)
            {
                PhoneViewModel p = new PhoneViewModel();
                p.PhoneID = (int)row["PhoneID"]; // unboxing
                p.Name = row["ProductName"].ToString();
                p.Price = ((decimal)row["Price"]).ToString("C");  
                p.ModelCode = row["ModelCode"].ToString();
                p.Brand = (string)row["BrandName"];
                list.Add(p);
            }

            return list;
        }
        public void ReduceStock(string IMEI1)
        {
            SqlParameter p1 = new SqlParameter("IMEI1", IMEI1);
            Program.SqlHelper.ExecuteProc("sp_ReduceStock", p1);
        }
        public List<PhoneViewModel> SearchPhone1(string IMEI1="" )
        {
            List<PhoneViewModel> list = new List<PhoneViewModel>();
            var dt = Program.SqlHelper.GetTable("exec SearcPhone1 " + IMEI1);
            foreach (DataRow row in dt.Rows)
            {
                PhoneViewModel p = new PhoneViewModel();
                p.PhoneID = (int)row["PhoneID"]; // unboxing
                p.Name = row["ProductName"].ToString();
                p.Price = ((decimal)row["Price"]).ToString("C");
                p.ModelCode = row["ModelCode"].ToString();
                p.IMEI1 = (string)row["IMEI1"];
                list.Add(p);
            }

            return list;
        }


    }
}

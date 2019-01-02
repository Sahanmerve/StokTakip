using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class PhoneCaseRepo
    {
        public List<PhoneCase> GetPhoneCases()
        {
            List<PhoneCase> list = new List<PhoneCase>();
            DataTable dt = Program.SqlHelper.GetTable("SELECT * FROM PhoneCase");
            foreach (DataRow row in dt.Rows)
            {
                PhoneCase pc = new PhoneCase();
                pc.ProductID = (int)row["CaseID"]; // unboxing
                pc.ProductName = row["ProductName"].ToString();
                pc.Price = (decimal)row["Price"];
                pc.StockQTY = (int)row["StockQTY"];
                pc.CaseColor = (CaseColor)row["CaseColor"];
                list.Add(pc);
            }
            return list;
        }

        public void InsertPhoneCases(PhoneCase newPhoneCase)
        {
            SqlParameter p1 = new SqlParameter("Name", newPhoneCase.ProductName);
            SqlParameter p2 = new SqlParameter("price", newPhoneCase.Price);
            SqlParameter p3 = new SqlParameter("qty", newPhoneCase.StockQTY);
            SqlParameter p4 = new SqlParameter("color", newPhoneCase.CaseColor);
            Program.SqlHelper.ExecuteProc("sp_CreatePhoneCase", p1,p2,p3,p4);
           
        }
        public void AddStockToPhoneCase(int id, int qty)
        {
            SqlParameter p1 = new SqlParameter("id",id);
            SqlParameter p2 = new SqlParameter("qty",qty);
            Program.SqlHelper.ExecuteProc("sp_addStock",p1,p2);
        }
        public void Delete(int id)
        {
            Program.SqlHelper.ExecuteCommand("DELETE FROM PhoneCase WHERE CaseID="+id);
        }
        public void ReduceStock1(int id, int qty)
        {
            SqlParameter p1 = new SqlParameter("id", id);
            SqlParameter p2 = new SqlParameter("qty", qty);
            Program.SqlHelper.ExecuteProc("sp_ReduceStock1", p1, p2);
        }
    }
}

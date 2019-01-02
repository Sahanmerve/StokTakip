using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class SQLHelper
    {
        private string ConnectionString { get; set; }

        private SqlConnection Connection { get; set; }

        public SQLHelper()
        {
            ConnectionString = @"Server = DESKTOP-T79GQPE\SQLEXPRESS; Database= StokTakip; User Id = lenova; Integrated Security = true;" ;
            Connection = new SqlConnection(ConnectionString);
        }

        public int ExecuteCommand(string query)
        {
            SqlCommand command = new SqlCommand(query,Connection);
            Connection.Open();
            int r = command.ExecuteNonQuery();
            Connection.Close();
            return r;
        }

        public void ExecuteProc(string procName,int? ID=null)
        {
            SqlCommand command = new SqlCommand();
            Connection.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            if (ID.HasValue)
            {
                command.Parameters.AddWithValue("ID", ID.Value);
            }   
            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();
        }
        public void ExecuteProc(string procName,params SqlParameter[] ps)
        {
            SqlCommand command = new SqlCommand();
            Connection.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;  
            command.Parameters.AddRange(ps);
            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable GetTable(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query,ConnectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

        
    }
}

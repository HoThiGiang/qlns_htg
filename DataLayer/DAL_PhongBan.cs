using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;

namespace DataLayer
{
    public class DAL_PhongBan:DBConnection
    {
        public DataTable getAllPB()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from PhongBan", Conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}

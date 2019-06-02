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
    public class PhongBanDAL
    {
        DBConnection da = new DBConnection();
        
        public DataTable GetAllPhongBan()
        {
            SqlCommand cmd = new SqlCommand("select * from PhongBan");
            da.Load(cmd);
            return da;
        }
        //check ID
        public bool CheckID(int MaPB)
        {
            string Query = "select * from PhongBan where MaPB ='" + MaPB + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        //Thêm phòng ban
        public string InsertPB(PhongBanDTO phongban)
        {
            string Query = "Insert into PhongBan(MaPB, TenPB) values('" + phongban._MaPB + "', N'" + phongban._TenPB + "')";
            return Query;
        }
        //Sửa phòng ban
        public string UpdatePB(PhongBanDTO phongban)
        {
            string Query = "Update PhongBan set TenPB= N'"+phongban._TenPB+"' where MaPB='"+phongban._MaPB+"'";
            return Query;
        }
        //Xóa phòng ban
        public string DeletePB(PhongBanDTO phongBan)
        {
            string Query = "delete PhongBan where MaPB='" + phongBan._MaPB + "'";
            return Query;
        }



    }
}

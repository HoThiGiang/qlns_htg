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
    public class LuongDAL
    {
        DBConnection da = new DBConnection();
        public DataTable GetAllLuong()
        {
            SqlCommand cmd = new SqlCommand("select * from Luong");
            da.Load(cmd);
            return da;
        }
        //Thêm thông tin lương
        public string InsertLuong(LuongDTO luong)
        {
            string query = "insert into Luong(MaLuong,MaCD, LCB, GhiChu) values ('"+luong._MaLuong+"','"+luong._MaCD+"','"+luong._LCB+"','"+luong._GhiChu+"')";
            return query;
        }
        //Sửa thông tin lương
        public string UpdateLuong(LuongDTO luong)
        {
            string query = "Update Luong set MaCD='"+luong._MaCD+"', LCB='"+luong._LCB+"',GhiChu=N'"+luong._GhiChu+"' where MaLuong='"+luong._MaLuong+"'";
            return query;
        }
        //Xóa phòng thông tin Lương
        public string Deleteluong(LuongDTO luong)
        {
            string Query = "delete Luong where MaLuong='" + luong._MaLuong + "'";
            return Query;
        }
    }
}

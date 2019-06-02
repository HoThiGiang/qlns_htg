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
    public class ChamCongDAL
    {
        DBConnection da = new DBConnection();
        public DataTable GetAllChamCong()
        {
            SqlCommand cmd = new SqlCommand("select * from ChamCong");
            da.Load(cmd);
            return da;
        }
        //kiểm tra id
        public bool CheckID(int MaNV)
        {
            string Query = "select * from ChamCong where MaNV ='" + MaNV + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        //Thêm thông tin chấm công
        public string InsertChamCong(ChamCongDTO chamcong)
        {
            string query = "insert into ChamCong(MaNV,Thang, Nam, SoNgayCong, SoNgayNghi) values('"+chamcong._MaNV+"','"+chamcong._Thang+"','"+chamcong._Nam+"','"+chamcong._SoNgayCong+"','"+chamcong._SoNgayNgi+"') ";
            return query;
        }
        //Sửa thông tin cá nhân
        public string UpdateChamCong(ChamCongDTO chamcong)
        {
            string query = "update ChamCong set MaNV='" + chamcong._MaNV + "',Thang='" + chamcong._Thang + "', Nam='" + chamcong._Nam + "',SoNgayCong='" + chamcong._SoNgayCong + "',SoNgayNghi='" + chamcong._SoNgayNgi + "' where MaNV='" + chamcong._MaNV + "' ";
            return query;
        }
        //Xóa phòng thông tin chấm công
        public string DeleteChamCong(ChamCongDTO chamcong)
        {
            string Query = "delete ChamCong where MaNV='" + chamcong._MaNV + "'";
            return Query;
        }
        //Lấy danh sách chấm công
        public DataTable LayDanhSachChamCong()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien");
            da.Load(cmd);
            return da;
        }
    }
}

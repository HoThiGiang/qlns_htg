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
    public class NhanVienDAL
    {
        DBConnection da = new DBConnection();
       
        //get all nhân viên
        public DataTable GetAllNhanVien()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien");
            da.Load(cmd);
            return da;
        }

        //check ID
        public bool CheckID(int MaNV)
        {
            string Query = "select * from NhanVien where MaNV ='" + MaNV + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(Query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        //Thêm nhanvien
        public string InsertNV(NhanVienDTO nhanVien)
        {
            string Query = "Insert into NhanVien(MaNV, MaPB, MaCD, LoaiHD, NgayKi, NgayKT) values('"+nhanVien._MaNV+"', '"+nhanVien._MaPB+"','"+nhanVien._MaCD+"',N'"+nhanVien._LoaiHD+"','"+nhanVien._NgayKi+"','"+nhanVien._NgayKT+"')";
            return Query;
        }
        //Sửa nhân viên
        public string UpdateNV(NhanVienDTO nhanvien)
        {
            string Query = "Update NhanVien set MaPB='" + nhanvien._MaPB + "', MaCD='" + nhanvien._MaCD + "',LoaiHD=N'" + nhanvien._LoaiHD + "',NgayKi='" + nhanvien._NgayKi + "',NgayKT='" + nhanvien._NgayKT + "' where MaNV='"+nhanvien._MaNV+"'";
            return Query;
        }

        //Xóa phòng thông tin nhan viên
        public string DeleteNhanVien(NhanVienDTO nhanvien)
        {
            string Query = "delete NhanVien where MaNV='" + nhanvien._MaNV + "'";
            return Query;
        }
        //Hiển thị comboBox
        //public DataTable ShowComboBox(string query)
        //{
        //    return da.GetTable(query);;
        //}
        public DataTable LayDanhSachNV()
        {
            SqlCommand cmd = new SqlCommand("select * from TTCaNhan");
            da.Load(cmd);
            return da;
        }
        public DataTable LayDanhSachPB()
        {
            SqlCommand cmd = new SqlCommand("select * from PhongBan");
             da.Load(cmd);
            return da;
        }
        public DataTable LayDanhSachCD()
        {
            SqlCommand cmd = new SqlCommand("select * from ChucDanh");
            da.Load(cmd);
            return da;
        }

    }
}

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
    public class TaiKhoanDAL
    {

        DBConnection ds = new DBConnection();
        DBConnection ds1 = new DBConnection();

        //Kiểm tra người đăng nhập thuộc loại 1 hay không
        public bool NguoiDungLoai1(string tk)
        {
            string NguoiDung1 = "select * from DangNhap where MaLoaiNguoiDung= 1 and TenDN like N'"+tk+"%'";
            ds.thucthiketnoi(NguoiDung1);
            if (ds.GetTable(NguoiDung1).Rows.Count > 0)
                return true;
            return false;
        }

        //Kiểm tra người đăng nhập thuộc loại 1 hay không
        public bool NguoiDungLoai2(string tk)
        {
            string NguoiDung2 = "select * from DangNhap where MaLoaiNguoiDung= 2 and TenDN like N'"+tk+"%'";
            ds.thucthiketnoi(NguoiDung2);
            if (ds.GetTable(NguoiDung2).Rows.Count > 0)
                return true;
            return false;
        }

        //Kiểm tra tên đăng kí
        public bool CheckTenDN(string tk)
        {
            string tenDN = "select * from DangNhap where TenDN=N'" + tk + "'";
            ds.thucthiketnoi(tenDN);
            if (ds.GetTable(tenDN).Rows.Count > 0)
                return true;
            return false;

        }

        //Kiểm tra tài khoản đăng kí
        public bool CheckTaiKhoan(string ten, string mk)
        {
            string taikhoan = "select * from DangNhap where TenDN = N'" + ten + "' and MatKhau = N'" + mk + "'";
            if (ds.GetTable(taikhoan).Rows.Count > 0)
                return true;
            return false;
        }

        //Kiểm tra tài khoản đăng nhập
        public bool check(TaiKhoanDTO tk)
        {
            string kn = "select * from DangNhap where TenDN = N'" + tk._TenDN + "' and MatKhau = N'" + tk._MatKhau + "'";
            ds.thucthiketnoi(kn);
            if (ds.GetTable(kn).Rows.Count > 0)
                return true;
            return false;
        }

        //Thêm tài khoản
        public string InsertTaiKhoan(TaiKhoanDTO tk)
        {
            string taikhoan = "Insert into DangNhap(MatKhau,TenDN) values ('" + tk._MatKhau + "',N'" + tk._TenDN + "')";
            return taikhoan;
        }

        //kiểm tra trùng khóa

        public bool kttrungkhoa(string dauvao, string strsql)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            strsql = "insert into DangNhap(TenDN,MatKhau) values TenDN = N'" + tk._TenDN + "' and MatKhau = N'" + tk._MatKhau + "'";
            return ds.kttrungkhoa(dauvao, strsql);
        }
        //public DataTable LayDSNguoiDung()
        //{
        //    SqlCommand cmd = new SqlCommand("Select * from DangNhap");
        //    ds.Load(cmd);
        //    return ds;
        //}
        //public DataTable LayDSNguoiDung(string tenDangNhap)
        //{
        //    String sql = "SELECT * FROM DangNhap WHERE TenDN = @TenDN";
        //    SqlCommand cmd = new SqlCommand(sql);
        //    cmd.Parameters.Add("TenDN", SqlDbType.VarChar).Value = tenDangNhap;
        //    ds.Load(cmd);
        //    return ds;
        //}
        //public void UpdatePassWord(String tenDangNhap, String matKhau)
        //{
        //    ds1.UpdatePassWord(tenDangNhap, matKhau);
        //}
        public DataRow NewRow()
        {
            return ds.NewRow();
        }

        public void Add(DataRow row)
        {
            ds.Rows.Add(row);
        }

        public bool Save()
        {
            return (ds.ExecuteNoneQuery() > 0);
        }

    }
}

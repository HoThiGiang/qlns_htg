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
    public class TangLuongDAL
    {
        DBConnection da = new DBConnection();
        
        //Thống kê lương nhân viên
        public DataTable TimKiemThongKeLuongTheoTen(string TenNV)
        {
            string Query = "select * from View_ThongKeLuongNhanVien where HoTen like N'" + TenNV + "%'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }

        // Lấy danh sách tăng lương
        public DataTable TimKiemNVTheoTenNV(string TenNV)
        {
            string Query = "select * from View_TinhLuongNhanVien where HoTen like N'"+TenNV+"%'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }
        public DataTable GetTTLuong()
        {
            return da.GetTable("select * from View_TinhLuongNhanVien");
        }

        //lấy danh sách lương nhân viên

        public DataTable GetLuongNhanVien()
        {
            return da.GetTable("select nv.MaNV, HoTen, TenCD, l.LCB, PCMoi , (l.LCB+PCMoi)-SoNgayNghi*LCB/30 as N'Lương cứng'" +
                  " from NhanVien as nv, TTCaNhan as ttcn, ChucDanh as cd, Luong as l, TangLuong as tl, ChamCong as cc " +
                  "where ttcn.MaNV = nv.MaNV and nv.MaCD = cd.MaCD and cd.MaCD = l.MaCD and nv.MaCD = cd.MaCD and tl.MaNV= nv.MaNV and nv.MaNV=cc.MaNV ");
            
        }
        /// Thống kê lương nhân viên

        public DataTable ThongKeLuongNV()
        {
            return da.GetTable("select * from View_ThongKeLuongNhanVien");

        }
        ///

        public DataTable GetAllTangLuong()
        {
            SqlCommand cmd = new SqlCommand("select * from TangLuong");
            da.Load(cmd);
            return da;
        }
        //Thêm thông tin luong
        public string InsertTangLuong(TangLuongDTO tangluong)
        {
            string Query = "Insert into TangLuong(MaNV,LCBCu,LCBMoi, PCCu, PCMoi, NgayTang) " +
                "values('" + tangluong._MaNV + "', '" + tangluong._LCBCu+ "', '" + tangluong._LCBMoi+ "'" +
                ",'" + tangluong._PCCu + "','"+tangluong._PCMoi+"','"+tangluong._NgayTang+"')";
            return Query;
        }
        //Sửa thông tin lương
        public string UpdateTangLuong(TangLuongDTO tangluong)
        {
            string Query = "Update TangLuong " +
                           "set LCBCu='"+tangluong._LCBCu+"', LCBMoi='"+tangluong._LCBMoi+"', PCCu='"+tangluong._PCCu+"', PCMoi='"+tangluong._PCMoi+"' " +
                           "where MaNV='"+tangluong._MaNV+"' and NgayTang='"+tangluong._NgayTang+"'";
            return Query;
        }

        //Xóa phòng thông tin tang lương
        public string DeleteTangLuong(TangLuongDTO tangluong)
        {
            string Query = "delete TangLuong where MaNV='" + tangluong._MaNV + "'";
            return Query;
        }

    }
}

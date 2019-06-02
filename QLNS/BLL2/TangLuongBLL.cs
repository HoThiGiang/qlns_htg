using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using DataTransferObject;

namespace BLL2
{
    public class TangLuongBLL
    {
        TangLuongDAL tl = new TangLuongDAL();
        //Thống kê lương theo ten
        public DataTable TimKiemThongKeLuongTheoTen(string TenNV)
        {
            return tl.TimKiemThongKeLuongTheoTen(TenNV);
        }

        ///Tăng lương nhân viên
        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            //Cập nhật dữ liệu đồng thời vào sql và form
            BindingSource bs = new BindingSource();
            bs.DataSource = tl.GetAllTangLuong();
            dg.DataSource = bs;
            bn.BindingSource = bs;
        }
        ///Tìm kiếm lương nhân viên theo tên
        public DataTable TimKiemNVTheoTenNV(string TenNV)
        {
            return tl.TimKiemNVTheoTenNV(TenNV);
        }
        // Hiển thị Lương nhân viên
        public void HienThiComBoBoxLuong(ComboBox cmb)
        {
            cmb.DataSource = tl.GetLuongNhanVien();
            cmb.DisplayMember = "MaNV";
            cmb.ValueMember = "MaNV";
        }

        //Get Luong nhân viên
        public DataTable GetLuongNhanVien()
        {
            return tl.GetLuongNhanVien();
        }
        //Thống kê lương nhân viên
        public DataTable ThongKeLuongNV()
        {
            return tl.ThongKeLuongNV();
        }
        //GetAll tang lương
        public DataTable GetAllTangLuong()
        {
            return tl.GetAllTangLuong();
        }
        //Thêm
        public string InsertTangLuong(TangLuongDTO tangluong)
        {
            return tl.InsertTangLuong(tangluong);
        }
        //Sửa
        public string UpdateTangLuong(TangLuongDTO tangluong)
        {
            return tl.UpdateTangLuong(tangluong);
        }
        //Xóa
        public string DeleteTangLuong(TangLuongDTO tangluong)
        {
            return tl.DeleteTangLuong(tangluong);
        }
    }
}

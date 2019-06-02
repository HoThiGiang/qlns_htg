using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BLL2
{
    public class TTCaNhanBLL
    {
         TTCaNhanDAL tt = new TTCaNhanDAL();
        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            //Cập nhật dữ liệu đồng thời vào sql và form
            BindingSource bs = new BindingSource();
            bs.DataSource = tt.GetAllTTCaNhan();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            
        }
        //get all phong ban
        public DataTable getAllTTCaNhan()
        {
            return tt.GetAllTTCaNhan();
        }
        //Thêm
        public string InsertTTCaNhan(TTCaNhanDTO ttCaNhan)
        {
            return tt.InsertTTCaNhan(ttCaNhan);
        }
        //Sửa
        public string UpdateTTCaNhan(TTCaNhanDTO ttCaNhan)
        {
            return tt.UpdateTTCaNhan(ttCaNhan);
        }
        //Xóa
        public string DeleteTTCaNhan(TTCaNhanDTO ttcanhan)
        {
            return tt.DeleteTTCaNhan(ttcanhan);
        }

        ///Tìm kiếm thông tin theo giá trị combox
        public void HienthiComboBox(ComboBox cmb)
        {
            cmb.DataSource = tt.GetAllTTCaNhan();
            cmb.DisplayMember = "TenKhachHang";
            cmb.ValueMember = "MaKhachHang";
        }
        ///Tìm kiếm nhân viên theo ma
        public DataTable TimKiemNVTheoMa(string MaNV)
        {
            return tt.TimKiemNVTheoMa(MaNV);
        }
        public DataTable TimKiemChiTietMaNV(string MaNV)
        {
            return tt.TimKiemChiTietMaNV(MaNV);
        }

        ///-------------------------------------Tìm kiếm theo Họ tên
        ///tìm kiếm nhân viên theo họ tên
        public DataTable TimKiemNVTheoHoTen(string HoTen)
        {
            return tt.TimKiemNVTheoHoTen(HoTen);
        }

        ///Load thông tin cá nhân theo họ tên
        public DataTable TimKiemChiTietNVTheoHoTen(string HoTen)
        {
            return tt.TimKiemChiTietNVTheoHoTen(HoTen);
        }


        ///-------------------------------------Tìm kiếm theo CMND
        ///Tìm kiếm thông tin theo Số cmnd
        public DataTable TimKiemNVTheoSoCMND(string CMND)
        {
            return tt.TimKiemNVTheoSoCMND(CMND);
        }
        ///Load thông tin theo Số cmnd
        public DataTable TimKiemChiTietNVTheoSoCMND(string CMND)
        {
            return tt.TimKiemChiTietNVTheoSoCMND(CMND);
        }

        ///------------------------------------Tìm kiếm thông tin lí lịch theo tên phòng ban
        public DataTable TimKiemNVTheoPhongBan(string TenPB)
        {
           return tt.TimKiemNVTheoPhongBan(TenPB);
        }
        ///------------------------------------Tìm kiếm thông tin lí lịch theo tên chức danh
        public DataTable TimKiemNVTheoChucDanh(string TenCD)
        {
            return tt.TimKiemNVTheoChucDanh(TenCD);
        }
        ///------------------------------------Tìm kiếm tất cả nhân viên có trong diện nghỉ sinh
        public DataTable TimKiemNVTheoDienNghiSinh(string TenNV)
        {
            return tt.TimKiemNVTheoDienNghiSinh(TenNV);
        }



    }
}

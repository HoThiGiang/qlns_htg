using DataLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace BLL2
{
    public class NhanVienBLL
    {
        NhanVienDAL nv = new NhanVienDAL();
        //get all nhanvien
        public DataTable getAllNV()
        {
            return nv.GetAllNhanVien();
        }
        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            //Cập nhật dữ liệu đồng thời vào sql và form
           // BindingSource bs = new BindingSource();
            //bs.DataSource = nv.GetAllNhanVien();
            //dg.DataSource = bs;
            //bn.BindingSource = bs;
        }
        public bool CheckID(int MaNV)
        {
            return nv.CheckID(MaNV);
        }
        //Thêm
        public string InsertNV(NhanVienDTO nhanVien)
        {
            return nv.InsertNV(nhanVien);
        }
        //Sửa
        public string UpdateNV(NhanVienDTO nhanvien)
        {
            return nv.UpdateNV(nhanvien);
        }
        //Xóa
        public string DeleteNV(NhanVienDTO nhanvien)
        {
            return nv.DeleteNhanVien(nhanvien);
        }
        //Lấy danh sách nhân viên
        //public DataTable LayDanhSachNV()
        //{
        //    return nv.LayDanhSachNV();
        //}
        public void HienthiComboBoxMaNhanVien(ComboBox cmb)
        {
            cmb.DataSource = nv.LayDanhSachNV();
            cmb.DisplayMember = "MaNV";
            cmb.ValueMember = "MaNV";
        }
        public void HienThiComBoBoxMaPB(ComboBox cmb)
        {
            cmb.DataSource = nv.LayDanhSachPB();
            cmb.DisplayMember = "MaPB";
            cmb.ValueMember = "MaPB";
        }

        public void HienThiComBoBoxMaCD(ComboBox cmb)
        {
            cmb.DataSource = nv.LayDanhSachCD();
            cmb.DisplayMember = "MaCD";
            cmb.ValueMember = "MaCD";
        }

    }
}

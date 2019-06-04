using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using DataTransferObject;
//
namespace BLL2
{
    //
    public class ChamCongBLL
    {
        ChamCongDAL cc = new ChamCongDAL();
        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            //Cập nhật dữ liệu đồng thời vào sql và form
            BindingSource bs = new BindingSource();
            bs.DataSource = cc.GetAllChamCong();
            dg.DataSource = bs;
            bn.BindingSource = bs;

        }
        //lấy dữ liệu 
        public DataTable GetAllChamCong()
        {
            return cc.GetAllChamCong();
        }
        //thêm
        public string InsertChamCong(ChamCongDTO chamcong)
        {
            return cc.InsertChamCong(chamcong);
        }
        //Sửa
        public string UpdateChamCong(ChamCongDTO chamcong)
        {
            return cc.UpdateChamCong(chamcong);
        }
        //Xóa
        public string DeleteChamCong(ChamCongDTO chamcong)
        {
            return cc.DeleteChamCong(chamcong);
        }
        //Hiển thị danh sách chấm công
        public void HienThiComBoBoxMV(ComboBox cmb)
        {
            cmb.DataSource = cc.LayDanhSachChamCong();
            cmb.DisplayMember = "MaNV";
            cmb.ValueMember = "MaNV";
        }
        ///Check id
        public bool CheckID(int MaNV)
        {
            return cc.CheckID(MaNV);
        }
    }
}

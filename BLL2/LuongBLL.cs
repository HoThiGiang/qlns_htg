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
    public class LuongBLL
    {
        LuongDAL l = new LuongDAL();
        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            //Cập nhật dữ liệu đồng thời vào sql và form
            BindingSource bs = new BindingSource();
            bs.DataSource = l.GetAllLuong();
            dg.DataSource = bs;
            bn.BindingSource = bs;
        }
        //GetAll Lương

        public DataTable getAllLuong()
        {
            return l.GetAllLuong();
        }

        //Thêm Thong tin Luong
        public string InsertLuong(LuongDTO luong)
        {
            return l.InsertLuong(luong);
        }
        //Sửa
        public string UpdateLuong(LuongDTO luong)
        {
            return l.UpdateLuong(luong);
        }
        //Xóa
        public string DeleteLuong(LuongDTO luong)
        {
            return l.Deleteluong(luong);
        }
    }
}

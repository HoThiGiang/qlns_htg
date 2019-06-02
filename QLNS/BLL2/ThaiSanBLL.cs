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
    public class ThaiSanBLL
    {
        ThaiSanDAL ts = new ThaiSanDAL();
        //get all thai san
        public DataTable getAllThaiSan()
        {
            return ts.GetAllThaiSan();
        }


        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            //Cập nhật dữ liệu đồng thời vào sql và form
            BindingSource bs = new BindingSource();
            bs.DataSource = ts.GetAllThaiSan();
            dg.DataSource = bs;
            bn.BindingSource = bs;

        }
        //Kiểm tra giới tính
        public int CheckGioiTinh()
        {
            return ts.CheckGioiTinh();
        }
        //thêm
        public string InsertThaiSan(ThaiSanDTO thaisan)
        {
            return ts.InsertTTCaNhan(thaisan);
        }
        //sửa
        public string UpdateThaiSan(ThaiSanDTO thaiSan)
        {
            return ts.UpdateThaiSan(thaiSan);
        }
        //Xóa
        public string DeleteThaiSan(ThaiSanDTO thaisan)
        {
            return ts.DeleteThaiSan(thaisan);
        }
    }
}

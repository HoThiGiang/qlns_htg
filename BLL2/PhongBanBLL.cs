using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
using System.Data;
//update 
namespace BLL2
{
    public class PhongBanBLL
    {
        PhongBanDAL pb = new PhongBanDAL();
        public void HienThi(DataGridView dg, BindingNavigator bn)
        {
            //Cập nhật dữ liệu đồng thời vào sql và form
            BindingSource bs = new BindingSource();
            bs.DataSource = pb.GetAllPhongBan();
            dg.DataSource = bs;
            bn.BindingSource = bs;

        }
        public bool CheckID(int MaPB)
        {
            return pb.CheckID(MaPB);
        }
        //get all phong ban
        public DataTable getAllPB()
        {
            return pb.GetAllPhongBan();
        }
        //insertPB
        public string InsertPB(PhongBanDTO phongBan)
        {
            return pb.InsertPB(phongBan);
        }
        //updatePB
        public string UpdatePB(PhongBanDTO phongban)
        {
            return pb.UpdatePB(phongban);
        }
        //deletePB
        public string DeletePB(PhongBanDTO phongban)
        {
            return pb.DeletePB(phongban);
        }

        
    }
}

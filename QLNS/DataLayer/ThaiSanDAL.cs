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
    public class ThaiSanDAL
    {
        DBConnection da = new DBConnection();
        public DataTable GetAllThaiSan()
        {
            SqlCommand cmd = new SqlCommand("select * from ThaiSan");
            da.Load(cmd);
            return da;
        }
        ///Kiểm tra giới tính nữ
        public int CheckGioiTinh()
        {
            string Query = "select * from NhanVien as nv,TTCaNhan as tt where nv.MaNV=tt.MaNV and GioiTinh like N'Nữ'";
            DataTable dt = new DataTable();
            dt = da.GetTable(Query);
            if (dt.Rows.Count > 0)
                return 1;
            return 0;
        }

        //Thêm phòng ban
        public string InsertTTCaNhan(ThaiSanDTO thaiSan)
        {
            string Query = "Insert into ThaiSan(MaNV,NgayNghiSinh,NgayLamTroLai, TroCap) " +
                "values('" + thaiSan._MaNV+ "', N'" + thaiSan._NgayNghiSinh + "', N'" + thaiSan._NgayLamTroLai + "'" +
                ",N'" + thaiSan._TroCap + "')";
            return Query;
        }

        //Sửa thông tin Thai sản
        public string UpdateThaiSan(ThaiSanDTO thaisan)
        {
            string Query = "Update ThaiSan set NgayNghiSinh=N'" + thaisan._NgayNghiSinh + "', NgayLamTroLai='" + thaisan._NgayLamTroLai.ToShortDateString() + "'," +
                "TroCap=N'" + thaisan._TroCap + "'where MaNV='"+thaisan._MaNV+"'";
            return Query;
        }

        //xóa thông tin thai sản

        public string DeleteThaiSan(ThaiSanDTO thaisan)
        {
            string Query = "delete ThaiSan where MaNV='" + thaisan._MaNV + "'";
            return Query;
        }

    }
}

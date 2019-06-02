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
    
    public class TTCaNhanDAL
    {
        DBConnection da = new DBConnection();
        public DataTable GetAllTTCaNhan()
        {
            SqlCommand cmd = new SqlCommand("select * from TTCaNhan");
            da.Load(cmd);
            return da;
        }


        ///-------------------------------------TÌM KIẾM
        
        ///-------------------------------------Tìm kiếm theo mã
        ///Tìm kiếm nhân viên theo ma
        public DataTable TimKiemNVTheoMa(string MaNV)
        {
            string Query = "select * from TTCaNhan where MaNV ='" + MaNV + "'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }

        ///Load thông tin cá nhân theo mã
        
        public DataTable TimKiemChiTietMaNV(string MaNV)
        {
            string Query = "select * from TTCaNhan where MaNV like N'" + MaNV + "%'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }


        ///-------------------------------------Tìm kiếm theo Họ tên
        ///tìm kiếm nhân viên theo họ tên
        public DataTable TimKiemNVTheoHoTen(string HoTen)
        {
            string Query = "select * from TTCaNhan where HoTen='" +HoTen+ "'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }

        ///Load thông tin cá nhân theo họ tên
        public DataTable TimKiemChiTietNVTheoHoTen(string HoTen)
        {
            string Query = "select * from TTCaNhan where HoTen like N'" + HoTen + "%'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }

        
        ///-------------------------------------Tìm kiếm theo CMND
        ///Tìm kiếm thông tin theo Số cmnd
        public DataTable TimKiemNVTheoSoCMND(string CMND)
        {
            string Query = "select * from TTCaNhan where SoCMND='"+CMND+"'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }
        ///Load thông tin theo Số cmnd
        public DataTable TimKiemChiTietNVTheoSoCMND(string CMND)
        {
            string Query = "select * from TTCaNhan where SoCMND like N'" + CMND + "%'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }

        ///------------------------------------Tìm kiếm thông tin lí lịch theo tên phòng ban
        public DataTable TimKiemNVTheoPhongBan(string TenPB)
        {
            string Query = "select *" +
                           "from TTCaNhan as ttcn, NhanVien as nv, PhongBan as pb " +
                           "where ttcn.MaNV = nv.MaNV and nv.MaPB = pb.MaPB and TenPB like N'"+TenPB+"%'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }
        ///------------------------------------Tìm kiếm thông tin lí lịch theo tên chức danh
        public DataTable TimKiemNVTheoChucDanh(string TenCD)
        {
            string Query = "select * " +
                           "from TTCaNhan as ttcn, NhanVien as nv, ChucDanh as cd " +
                           "where ttcn.MaNV = nv.MaNV and nv.MaCD = cd.MaCD and TenCD like N'"+TenCD+"%'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }
        ///------------------------------------Tìm kiếm tất cả nhân viên có trong diện nghỉ sinh
        public DataTable TimKiemNVTheoDienNghiSinh(string TenNV)
        {
            string Query = "select * " +
                           "from TTCaNhan as ttcn, NhanVien as nv, ThaiSan as ts " +
                           "where ttcn.MaNV = nv.MaNV and nv.MaNV = ts.MaNV and HoTen like N'" + TenNV + "%'";
            SqlCommand cmd = new SqlCommand(Query);
            da.Load(cmd);
            return da;
        }
        ///-------------------------------------THÊM
        //Thêm Thông tin cá nhân
        public string InsertTTCaNhan(TTCaNhanDTO ttCaNhan)
        {
            string Query = "Insert into TTCaNhan(MaNV, HoTen, NgaySinh,GioiTinh,QueQuan,TTHonNhan,SoCMND, NgayCap,NoiCap,SĐT, DanToc, TonGiao, HocVan, HocHam,GhiChu) " +
                "values('" + ttCaNhan._MaNV + "', N'" + ttCaNhan._HoTen + "', '" + ttCaNhan._NgaySinh+ "'" +
                ",N'"+ttCaNhan._GioiTinh+"',N'"+ttCaNhan._QueQuan+"',N'"+ttCaNhan._TTHonNhan+"'" +
                ",'"+ttCaNhan._SoCMND+"','"+ttCaNhan._NgayCap+"',N'"+ttCaNhan._NoiCap+"','"+ttCaNhan._SĐT+"',N'"+ttCaNhan._DanToc+"'" +
                ",N'"+ttCaNhan._TonGiao+"',N'"+ttCaNhan._HocVan+"',N'"+ttCaNhan._HocHam+"',N'"+ttCaNhan._GhiChu+"')";
            return Query;
        }


        ///-------------------------------------SỦA
        //Sửa thông tin cá nhân
        public string UpdateTTCaNhan(TTCaNhanDTO ttCaNhan)
        {
            string Query = "Update TTCaNhan set HoTen=N'" + ttCaNhan._HoTen + "', NgaySinh='" + ttCaNhan._NgaySinh.ToShortDateString() + "'," +
                "GioiTinh= N'" + ttCaNhan._GioiTinh + "', QueQuan= N'" + ttCaNhan._QueQuan + "',TTHonNhan=N'" + ttCaNhan._TTHonNhan + "',SoCMND='" + ttCaNhan._SoCMND + "'," +
                "NgayCap='" + ttCaNhan._NgayCap.ToShortDateString() + "',NoiCap=N'" + ttCaNhan._NoiCap + "',SĐT='" + ttCaNhan._SĐT + "',DanToc=N'" + ttCaNhan._DanToc + "',TonGiao=N'" + ttCaNhan._TonGiao + "'," +
                "HocVan=N'" + ttCaNhan._HocVan + "',HocHam=N'" + ttCaNhan._HocHam + "',GhiChu=N'" + ttCaNhan._GhiChu + "' where MaNV='"+ttCaNhan._MaNV+"'" ;
            return Query;
        }


        ///-------------------------------------XÓA
        //Xóa phòng thông tin cá nhân
        public string DeleteTTCaNhan(TTCaNhanDTO ttcanhan)
        {
            string Query = "delete TTCaNhan where MaNV='" +ttcanhan._MaNV + "'";
            return Query;
        }
    }
}

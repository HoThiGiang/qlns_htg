using DataLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL2
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL dn = new TaiKhoanDAL();
        //TaiKhoanDAL dn2 = new TaiKhoanDAL();

        //Insert TaiKhoan
        public string InsertTaiKhoan(TaiKhoanDTO tk)
        {
            return dn.InsertTaiKhoan(tk);

        }
        //Login
        public int login(TaiKhoanDTO tk)
        {
            if (string.IsNullOrEmpty(tk._TenDN) || string.IsNullOrEmpty(tk._MatKhau))
                return 0;
            if (dn.check(tk) == false)
                return -1;
            else return 1;
        }

        //Kiểm tra login thuộc bộ phận nào
        public int checkBoPhan(TaiKhoanDTO tk)
        {
            if (dn.NguoiDungLoai1(tk._TenDN)) return 0;
            if (dn.NguoiDungLoai2(tk._TenDN)) return -1;
            else return 1;
        }

        // kiểm tra trùng khóa

        public bool kttrungkhoa(string dauvao, string strsql)
        {
             return dn.kttrungkhoa(dauvao,strsql);
        }

        public TaiKhoanBLL()
        {

        }
        public DataRow NewRow()
        {
            return this.dn.NewRow();
        }

        public void Add(DataRow row)
        {
            this.dn.Add(row);
        }

        public bool Save()
        {
            return this.dn.Save();
        }
    }
}

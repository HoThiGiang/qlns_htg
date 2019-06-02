using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TaiKhoanDTO
    {
        private string TenDN;

        public string _TenDN
        {
            get { return TenDN; }
            set { TenDN = value; }
        }
        private string MatKhau;

        public string _MatKhau
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }

        private int MaDN;

        public int _MaDN
        {
            get { return MaDN; }
            set { MaDN = value; }
        }

        private int MaLoaiNguoiDung;

        public int _MaLoaiNguoiDung
        {
            get { return MaLoaiNguoiDung; }
            set { MaLoaiNguoiDung = value; }
        }

        public TaiKhoanDTO()
        {

        }
        public TaiKhoanDTO(string MatKhau, string TenDN,int MaDN, int MaLoaiNguoiDung)
        {
            this.MatKhau = MatKhau;
            this.TenDN = TenDN;
            this.MaDN = MaDN;
            this.MaLoaiNguoiDung = MaLoaiNguoiDung;
        }

    }
}

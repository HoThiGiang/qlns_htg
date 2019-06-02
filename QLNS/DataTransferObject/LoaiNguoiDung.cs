using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class LoaiNguoiDung
    {
        private int MaLoaiNguoiDung;

        public int _MaLoaiNguoiDung
        {
            get { return MaLoaiNguoiDung; }
            set { MaLoaiNguoiDung = value; }
        }

        private string TenLoaiNguoiDung;

        public string _TenLoaiNguoiDung
        {
            get { return TenLoaiNguoiDung; }
            set { TenLoaiNguoiDung = value; }
        }

        public LoaiNguoiDung()
        {

        }
        public LoaiNguoiDung(int MaLoaiNguoiDung, String TenLoaiNguoiDung)
        {
            this.MaLoaiNguoiDung = MaLoaiNguoiDung;
            this.TenLoaiNguoiDung = TenLoaiNguoiDung;
        }


    }
}

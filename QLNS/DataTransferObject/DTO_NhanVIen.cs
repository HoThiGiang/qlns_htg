using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTO_NhanVIen
    {
        private int MaNV;

        public int _MaNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        
        private int MaBP;

        public int _MaPB
        {
            get { return MaBP; }
            set { MaBP = value; }
        }

        private int MaCD;

        public int _MaCD
        {
            get { return MaCD; }
            set { MaCD = value; }
        }
        private string LoaiHD;

        public string _LoaiHD
        {
            get { return LoaiHD; }
            set { LoaiHD = value; }
        }

        private String NgayKi;

        public string _NgayKi
        {
            get { return NgayKi; }
            set { NgayKi = value; }
        }

        private string NgayKT;

        public string _ngayKT
        {
            get { return NgayKT; }
            set { NgayKT = value; }
        }
        
    }
}

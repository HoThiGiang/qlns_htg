using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class NhanVienDTO
    {
        private int MaNV;

        public int _MaNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        private int MaPB;

        public int _MaPB
        {
            get { return MaPB; }
            set { MaPB = value; }
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
        private DateTime NgayKi;

        public DateTime _NgayKi
        {
            get { return NgayKi; }
            set { NgayKi = value; }
        }

        private DateTime NgayKT;

        public DateTime _NgayKT
        {
            get { return NgayKT; }
            set { NgayKT = value; }
        }
        public NhanVienDTO()
        {

        }
        public NhanVienDTO(int MaNV, int MaPB, int MaCD, string LoaiHD, DateTime NgayKi, DateTime NgayKT)
        {
            this.MaNV = MaNV;
            this.MaPB = MaPB;
            this.MaCD = MaCD;
            this.LoaiHD = LoaiHD;
            this.NgayKi = NgayKi;
            this.NgayKT = NgayKT;
        }


    }
}

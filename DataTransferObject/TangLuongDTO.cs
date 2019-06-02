using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TangLuongDTO
    {
        private int MaVN;

        public int _MaNV
        {
            get { return MaVN; }
            set { MaVN = value; }
        }
        private decimal LCBCu;

        public decimal _LCBCu
        {
            get { return LCBCu; }
            set { LCBCu = value; }
        }
        private decimal LCBMoi;

        public decimal _LCBMoi
        {
            get { return LCBMoi; }
            set { LCBMoi = value; }
        }
        private decimal PCCu;

        public decimal _PCCu
        {
            get { return PCCu; }
            set { PCCu = value; }
        }
        private decimal PCMoi;

        public decimal _PCMoi
        {
            get { return PCMoi; }
            set { PCMoi = value; }
        }
        private DateTime NgayTang;

        public DateTime _NgayTang
        {
            get { return NgayTang; }
            set { NgayTang = value; }
        }
    }
}






















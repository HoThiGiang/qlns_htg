using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTO_TangLuong
    {
        private int MaVN;

        public int _MaNV
        {
            get { return MaVN; }
            set { MaVN = value; }
        }
        private float LCBCu;

        public float _LCBCu
        {
            get { return LCBCu; }
            set { LCBCu = value; }
        }
        private float LCBMoi;

        public float _LCBMoi
        {
            get { return LCBMoi; }
            set { LCBMoi = value; }
        }
        private DateTime NgayTang;  

        public DateTime _NgayTang
        {
            get { return NgayTang; }
            set { NgayTang = value; }
        }


    }
}

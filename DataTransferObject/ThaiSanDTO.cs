using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DataTransferObject
{
    public class ThaiSanDTO
    {
        private int MaNV;

        public int _MaNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        private DateTime NgayNghiSinh;

        public DateTime _NgayNghiSinh
        {
            get { return NgayNghiSinh; }
            set { NgayNghiSinh = value; }
        }
        private DateTime NgayLamTroLai;

        public DateTime _NgayLamTroLai
        {
            get { return NgayLamTroLai; }
            set { NgayLamTroLai = value; }
        }

        private float TroCap;

        public float _TroCap
        {
            get { return TroCap; }
            set { TroCap = value; }
        }

    }
}

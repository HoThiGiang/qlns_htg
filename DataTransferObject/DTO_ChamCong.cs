using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTO_ChamCong
    {
        private int MaNV;

        public int _MaNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }

        private int Thang;

        public int _Thang
        {
            get { return Thang; }
            set { Thang = value; }
        }

        private int Nam;

        public int _Nam
        {
            get { return Nam; }
            set { Nam = value; }
        }

        private int SoNgayCong;

        public int _SoNgayCong
        {
            get { return SoNgayCong; }
            set { SoNgayCong = value; }
        }
        private int SoNgayNghi;

        public int _SoNgayNghi
        {
            get { return SoNgayNghi; }
            set { SoNgayNghi = value; }
        }




    }
}

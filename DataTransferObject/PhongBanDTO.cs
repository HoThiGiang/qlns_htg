using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataTransferObject
{
    public class PhongBanDTO
    {
        private int MaPB;

        public int _MaPB
        {
            get { return MaPB; }
            set { MaPB = value; }
        }
        private string TenPB;

        public string _TenPB
        {
            get { return TenPB; }
            set { TenPB = value; }
        }
        public PhongBanDTO()
        {
        }
        public PhongBanDTO(int MaPB, string TenPB)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
        }


    }
}

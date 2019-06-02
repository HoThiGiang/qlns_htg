using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTO_PhongBan
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


    }
}

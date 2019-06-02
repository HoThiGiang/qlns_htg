using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTO_ChucDanh
    {
        private int MaCD;

        public int _MaCD
        {
            get { return MaCD; }
            set { MaCD = value; }
        }
        private string TenCD;

        public string _TenCD
        {
            get { return TenCD; }
            set { TenCD = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataTransferObject
{
    public class LuongDTO
    {
        private int MaLuong;

        public int _MaLuong
        {
            get { return MaLuong; }
            set { MaLuong = value; }
        }
        private int MaCD;

        public int _MaCD
        {
            get { return MaCD; }
            set { MaCD = value; }
        }
        private decimal LCB;

        public decimal _LCB
        {
            get { return LCB; }
            set { LCB = value; }
        }
        private string GhiChu;

        public string _GhiChu
        {
            get { return GhiChu; }
            set { GhiChu = value; }
        }

        public int MaNV { get; private set; }
    }
}

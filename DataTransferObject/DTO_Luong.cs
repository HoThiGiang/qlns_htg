using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTO_Luong
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
        private float LBC;

        public float _LCB
        {
            get { return LBC; }
            set { LBC = value; }
        }
        private string GhiChu;

        public string _GhiChu
        {
            get { return GhiChu; }
            set { GhiChu = value; }
        }


    }
}

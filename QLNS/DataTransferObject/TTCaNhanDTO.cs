using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TTCaNhanDTO
    {
        private int MaNV;

        public int _MaNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        private string HoTen;

        public string _HoTen
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        private DateTime NgaySinh;

        public DateTime _NgaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        private string GioiTinh;

        public string _GioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }

        private string QueQuan;

        public string _QueQuan
        {
            get { return QueQuan; }
            set { QueQuan = value; }
        }
        private string TTHonNhan;

        public string _TTHonNhan
        {
            get { return TTHonNhan; }
            set { TTHonNhan = value; }
        }
        private decimal SoCMND;

        public decimal _SoCMND
        {
            get { return SoCMND; }
            set { SoCMND = value; }
        }
        private DateTime NgayCap;

        public DateTime _NgayCap
        {
            get { return NgayCap; }
            set { NgayCap = value; }
        }
        private string NoiCap;

        public string  _NoiCap
        {
            get { return NoiCap; }
            set { NoiCap = value; }
        }
        private decimal SĐT;

        public decimal _SĐT
        {
            get { return SĐT; }
            set { SĐT = value; }
        }
        private string DanToc;

        public string _DanToc
        {
            get { return DanToc; }
            set { DanToc = value; }
        }
        private string TonGiao;

        public string _TonGiao
        {
            get { return TonGiao; }
            set { TonGiao = value; }
        }
        private string HocVan;

        public string _HocVan
        {
            get { return HocVan; }
            set { HocVan = value; }
        }
        private string HocHam;

        public string _HocHam
        {
            get { return HocHam; }
            set { HocHam = value; }
        }
        private string GhiChu;

        public string _GhiChu
        {
            get { return GhiChu; }
            set { GhiChu = value; }
        }
        public TTCaNhanDTO()
        {

        }

        public TTCaNhanDTO(int MaNV, string HoTen, DateTime NgaySinh, string GioiTinh,
                                    string QueQuan, string TTHonNhan, decimal SoCMND, DateTime NgayCap, string NoiCap,
                                    decimal SĐT, string DanToc, string TonGiao, string HocVan, string HocHam, string GhiChu )
        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.QueQuan = QueQuan;
            this.TTHonNhan = TTHonNhan;
            this.SoCMND = SoCMND;
            this.NgayCap = NgayCap;
            this.NoiCap = NoiCap;
            this.SĐT = SĐT;
            this.DanToc = DanToc;
            this.SĐT = SĐT;
            this.DanToc = DanToc;
            this.TonGiao = TonGiao;
            this.HocVan = HocVan;
            this.HocHam = HocHam;
            this.GhiChu = GhiChu;
        }
        
    }
}

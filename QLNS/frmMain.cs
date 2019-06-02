using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using DataTransferObject;
using BLL2;

namespace QuanLiNhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Enable();
            vitricu();
        }
        
        // Vô hiệu hóa sau khi đăng nhập
        public int k = 1;
        //public void truyen()
        //{
        //    if (k == 4)
        //    {
        //        //Ẩn các panel không cần thiết
        //        panel_DanhMuc.Enabled = true;
        //        panel_ChucNang.Enabled = true;
        //        panel_QuanLi.Enabled = true;
        //        //panel_TaiKhoan.Enabled = false;
        //        // btn_DangNhap.Enabled = false;
        //        btn_DangNhap.Enabled = false;
        //        btn_DangKi.Enabled = true;
        //    }
        //}
        /// <summary>
        /// Đăng nhập bằng bộ phận nhân sự
        /// </summary>
        public void BoPhanNhanSu()
        {
            if (k == 2)
            {
                //Ẩn các panel không cần thiết
                panel_DanhMuc.Enabled = true;
                panel_ChucNang.Enabled = true;
                panel_QuanLi.Enabled = true;
                //panel_TaiKhoan.Enabled = false;
                // btn_DangNhap.Enabled = false;
                btn_DangNhap.Enabled = false;
                btn_DangKi.Enabled = true;
                btn_NhanVien.Enabled = true;
                btn_TTCaNhan.Enabled = true;
                buttonX11.Enabled = true;
            }
        }
        /// <summary>
        /// Đăng nhập bằng bộ phận tài chính
        /// </summary>
        public void BoPhanTaiChinh()
        {
            if (k == 3)
            {
                //Ẩn các panel không cần thiết
                panel_DanhMuc.Enabled = true;
                panel_ChucNang.Enabled = true;
                panel_QuanLi.Enabled = true;
                //panel_TaiKhoan.Enabled = false;
                // btn_DangNhap.Enabled = false;
                btn_DangNhap.Enabled = false;
                btn_DangKi.Enabled = true;
                buttonX8.Enabled = true;
                btn_CheDo.Enabled = true;
                btn_TienLuong.Enabled = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        public void vitricu()
        {
            panel_ChucNang.Hide();
            panel_DanhMuc.Hide();
            panel_QuanLi.Hide();
            panel_QuanLi.Hide();
            panel_TaiKhoan.Hide();
            cmd_taiKhoan.ForeColor = Color.Black;
            cmd_QuanLi.ForeColor = Color.Black;
            cmd_DanhMuc.ForeColor = Color.Black;
            cmd_ChucNang.ForeColor = Color.Black;
            panel_TaiKhoan.Hide();//ẩn
            panel_DanhMuc.Hide();
            panel_QuanLi.Hide();
            panel_ChucNang.Hide();
            cmd_DanhMuc.Location = new Point(28, 213);
            cmd_QuanLi.Location = new Point(28, 268);
            cmd_ChucNang.Location = new Point(28, 323);
            panel_TaiKhoan.Size = new Size(143, 166);
            panel_DanhMuc.Size = new Size(143, 166);
            panel_QuanLi.Size = new Size(143, 166);
            panel_ChucNang.Size = new Size(143, 166);
        }

        private int n;
        private void cmd_taiKhoan_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                cmd_taiKhoan.ForeColor = Color.DarkMagenta;
                cmd_DanhMuc.Location = new Point(28, 324);
                cmd_QuanLi.Location = new Point(28, 379);
                cmd_ChucNang.Location = new Point(28, 434);
                panel_TaiKhoan.Show();
                panel_TaiKhoan.Location = new Point(40, 211);
                panel_TaiKhoan.Size = new Size(143, 100);
                n = 1;
            }
            else if (n == 1)
            {

                vitricu();
                n = 0;
            }

        }
        // private void cmd_taiKhoan_MouseMove(object sender, EventArgs e)
        // {
        //     ((Button)sender).BackgroundImage = Properties.Resources._133;
        // }

        // private void cmd_taiKhoan_MouseLeave(object sender, EventArgs e)
        //{
        //     ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        // }

        private void cmd_DanhMuc_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                cmd_DanhMuc.ForeColor = Color.DarkMagenta;
                cmd_QuanLi.Location = new Point(28, 440);
                cmd_ChucNang.Location = new Point(28, 486);
                panel_DanhMuc.Show();
                panel_DanhMuc.Location = new Point(40, 250);
                panel_DanhMuc.Size = new Size(143, 190);
                n = 1;
            }
            else if (n == 1)
            {
                vitricu();
                n = 0;
            }

        }

        private void cmd_QuanLi_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                cmd_QuanLi.ForeColor = Color.DarkMagenta;
                cmd_ChucNang.Location = new Point(28, 361);
                panel_QuanLi.Show();
                panel_QuanLi.Location = new Point(40, 315);
                panel_QuanLi.Size = new Size(143, 40);
                n = 1;
            }
            else if (n == 1)
            {
                vitricu();
                n = 0;
            }

        }

        private void cmd_ChucNang_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                cmd_ChucNang.ForeColor = Color.DarkMagenta;
                panel_ChucNang.Show();
                panel_ChucNang.Location = new Point(40, 370);
                panel_ChucNang.Size = new Size(143, 100);
                n = 1;
            }
            else if (n == 1)
            {
                vitricu();
                n = 0;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap f1 = new frmDangNhap();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            frmDangKi dk = new frmDangKi();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            dk.TopLevel = false;
            dk.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(dk);
            dk.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            nv.TopLevel = false;
            nv.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(nv);
            nv.Show();
        }

        private void btn_TTCaNhan_Click(object sender, EventArgs e)
        {
            frmTTCaNhan t = new frmTTCaNhan();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            t.TopLevel = false;
            t.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(t);
            t.Show();
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            frmPhongBan pb = new frmPhongBan();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            pb.TopLevel = false;
            pb.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(pb);
            pb.Show();

        }
        private void btn_CheDo_Click(object sender, EventArgs e)
        {
            frmThaiSan ts = new frmThaiSan();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            ts.TopLevel = false;
            ts.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(ts);
            ts.Show();
        }

        private void btn_TienLuong_Click(object sender, EventArgs e)
        {
            frmTangLuong tl = new frmTangLuong();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            tl.TopLevel = false;
            tl.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(tl);
            tl.Show();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            frmChamCong cc = new frmChamCong();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            cc.TopLevel = false;
            cc.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(cc);
            cc.Show();
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            frmTimKiem tk = new frmTimKiem();
            panel_Show.Show();
            panel_Show.Controls.Clear();
            tk.TopLevel = false;
            tk.Dock = DockStyle.Fill;
            panel_Show.Controls.Add(tk);
            tk.Show();
        }


        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            frmTroGiup tg = new frmTroGiup();
            tg.ShowDialog();

        }
        public void CanBo()
        {
            this.btn_DangNhap.Enabled = true;
            this.btn_DangKi.Enabled = true;
            this.btn_NhanVien.Enabled = true;
            this.btn_Thoat.Enabled = true;
            this.btn_TienLuong.Enabled = true;

        }
        public void NhanVien()
        {
            this.btn_DangNhap.Enabled = true;
            this.btn_DangKi.Enabled = true;
            this.btn_NhanVien.Enabled = true;

        }

        frmDangNhap dangnhap = null;
        private void DangNhap()
        {
        TiepTuc:
            if (dangnhap == null || dangnhap.IsDisposed)
            {
                dangnhap = new frmDangNhap();
            }
            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                String tenDangnhap = dangnhap.richTextBox_TenDN.Text;
                String matKhau = dangnhap.richTextBox_MatKhau.Text;
                //DangNhapBLL ctrlNguoiDung = new DangNhapBLL();
                //     int ketqua = ctrlNguoiDung.DangNhap(tenDangnhap, matKhau);
                //        switch (ketqua)
                //        {
                //            case 0:
                //                MessageBox.Show("Không tồn tại người dùng trong hệ thống");
                //                goto TiepTuc;
                //            case 1:
                //                MessageBox.Show("Mật khẩu sai");
                //                goto TiepTuc;
                //            case 2:
                //                MessageBox.Show("Đăng nhập thành công");
                //                if (ctrlNguoiDung.PhanQuyen == 1)
                //                    CanBo();
                //                else
                //                    NhanVien();
                //                break;
                //        }
                //    }
                //    else this.Close();
                //}
                //private void btnDangNhap_Click(object sender, EventArgs e)
                //{
                //    DangNhap();
                //}

            }
            
        }

        
    }
}


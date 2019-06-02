using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL2;
using DataTransferObject;


namespace QuanLiNhanSu
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL dangnhapbll = new TaiKhoanBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        //Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO taikhoan = new TaiKhoanDTO();
            taikhoan._TenDN = richTextBox_TenDN.Text;
            taikhoan._MatKhau = richTextBox_MatKhau.Text;
            int check = dangnhapbll.login(taikhoan);
            int checkLoaiND = dangnhapbll.checkBoPhan(taikhoan);
            try
            {
                if (check == 0)
                {
                    MessageBox.Show("Mời nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (check == -1)
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(check == 1)
                {
                    if (checkLoaiND == 0)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        frmMain frm = new frmMain();
                        this.Hide();
                        frm.k = 2;
                        frm.BoPhanNhanSu();
                        frm.ShowDialog();
                    }
                    if (checkLoaiND == -1)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        frmMain frm = new frmMain();
                        this.Hide();
                        frm.k = 3;
                        frm.BoPhanTaiChinh();
                        frm.ShowDialog();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            richTextBox_TenDN.Text = "";
            richTextBox_MatKhau.Text = "";
        }

        //Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //private string TenDN;
        //public string LayTenNguoiDung
        //{
        //    get { return TenDN; }
        //    set { TenDN = value; }
        //}
        //private string MatKhau;
        //public string LayMatKhau
        //{
        //    get { return MatKhau; }
        //    set { MatKhau = value; }
        //}
        ////private void frmDangNhap_Load(object sender, EventArgs e)
        ////{
        ////    this.richTextBox_TenDN.Text = "";
        ////    this.richTextBox_MatKhau.Text = "";
        ////}

        //private void btnDangNhap_Click(object sender, EventArgs e)
        //{
        //    this.richTextBox_TenDN.Focus();//Focus: lệnh đặt con trỏ vào richtextbox
        //    TenDN = this.richTextBox_TenDN.Text;
        //    MatKhau = this.richTextBox_MatKhau.Text;
        //    this.DialogResult = DialogResult.OK;
        //}

        //private void frmDangNhap_Load(object sender, EventArgs e)
        //{
        //    this.richTextBox_TenDN.Text = "";
        //    this.richTextBox_MatKhau.Text = "";
        //}


    }
}

using BLL2;
using DataLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu
{
    public partial class frmDangKi : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmDangKi()
        {
            InitializeComponent();
        }
        DBConnection kn = new DBConnection();
        TaiKhoanBLL dangnhapBLL = new TaiKhoanBLL();
        TaiKhoanDAL taikhoanDAL = new TaiKhoanDAL();
        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDTO dto = new TaiKhoanDTO();
                dto._TenDN = txtTenDN.Text;
                dto._MatKhau = txtMatKhau.Text;
                if (txtTenDN.Text != "" && txtMatKhau.Text != "")
                {
                    if (!(taikhoanDAL.CheckTaiKhoan(dto._MatKhau, dto._TenDN)))
                    {
                        if (!(taikhoanDAL.CheckTenDN(dto._TenDN)))
                        {
                            string check = taikhoanDAL.InsertTaiKhoan(dto);
                            kn.thucthiketnoi(check);
                            MessageBox.Show("Thêm tài khoản thành công.");
                            this.Hide();
                            frmDangNhap dangnhap = new frmDangNhap();
                            dangnhap.ShowDialog();
                            this.Close();
                        }
                        else MessageBox.Show("Tên đăng nhập đã tồn tại.");
                    }
                    else MessageBox.Show("Bạn đã có tài khoản từ trước đó. Hãy quay lại phần đăng nhập.");
                }
                else MessageBox.Show("Bạn phải nhập đầy đủ tên đăng nhập và mật khẩu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

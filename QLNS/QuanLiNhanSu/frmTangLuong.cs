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
    public partial class frmTangLuong : Form
    {
        //TangLuongDAL tldal = new TangLuongDAL();
        TangLuongDTO tangluongdto = new TangLuongDTO();
        LuongDTO luongdto = new LuongDTO();
        DBConnection kn = new DBConnection();
        TangLuongBLL tl = new TangLuongBLL();
        LuongBLL l = new LuongBLL();
        public frmTangLuong()
        {
            InitializeComponent();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //tl.HienThi(dataGridViewTangLuog, bindingNavigator2);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //l.HienThi(dataGridViewTangLuog, bindingNavigator2);
        }


        //Button Mới

        private void buttonX6_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox3.Controls)
            {
                if ((ctr is TextBox) || (ctr is ComboBox) || (ctr == dateTimeInputNgayTang))
                {
                    ctr.Text = "";
                }
            }
        }

        //Thêm

        private void buttonX10_Click(object sender, EventArgs e)
        {
            try
            {
                //TangLuongDTO tangluong = new TangLuongDTO();
                tangluongdto._MaNV = Convert.ToInt32(txtMaNV.Text);
                tangluongdto._LCBCu = Convert.ToDecimal(txtLCBCu.Text);
                tangluongdto._LCBMoi = Convert.ToDecimal(txtLCBMoi.Text);
                tangluongdto._PCCu = Convert.ToDecimal(txtLCBCu.Text);
                tangluongdto._PCMoi = Convert.ToDecimal(txtLCBMoi.Text);
                tangluongdto._NgayTang = Convert.ToDateTime(dateTimeInputNgayTang.Text);
                if (txtMaNV.Text != "" && txtLCBCu.Text != "" && txtLCBMoi.Text != "" && txtTCCu.Text != "" && txtTCMoi.Text != "" && dateTimeInputNgayTang.Text != "")
                {
                    string check = tl.InsertTangLuong(tangluongdto);
                    kn.thucthiketnoi(check);
                    dataGridViewTangLuog.Refresh();
                    dataGridViewTangLuog.DataSource = tl.GetAllTangLuong();
                    dataGridViewTangLuog.Show();
                    MessageBox.Show("Thêm thành công");
                }
                else MessageBox.Show("Các trường không được để trống");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Sửa thông tin tăng lương

        private void buttonX9_Click(object sender, EventArgs e)
        {
            try
            {
                tangluongdto._MaNV = Convert.ToInt32(txtMaNV.Text);
                tangluongdto._LCBCu = Convert.ToDecimal(txtLCBCu.Text);
                tangluongdto._LCBMoi = Convert.ToDecimal(txtLCBMoi.Text);
                tangluongdto._PCCu = Convert.ToDecimal(txtTCCu.Text);
                tangluongdto._PCMoi = Convert.ToDecimal(txtTCMoi.Text);
                tangluongdto._NgayTang = Convert.ToDateTime(dateTimeInputNgayTang.Text);
                string update = tl.UpdateTangLuong(tangluongdto);
                kn.thucthiketnoi(update);
                dataGridViewTangLuog.Refresh();
                dataGridViewTangLuog.DataSource = tl.GetAllTangLuong();
                dataGridViewTangLuog.Show();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }
        //Xóa thông tin tăng lương

        private void buttonX7_Click(object sender, EventArgs e)
        {
            tangluongdto._MaNV = Convert.ToInt32(txtMaNV.Text);
            tangluongdto._LCBCu = Convert.ToDecimal(txtLCBCu.Text);
            tangluongdto._LCBMoi = Convert.ToDecimal(txtLCBMoi.Text);
            tangluongdto._PCCu = Convert.ToDecimal(txtLCBCu.Text);
            tangluongdto._PCMoi = Convert.ToDecimal(txtLCBMoi.Text);
            tangluongdto._NgayTang = Convert.ToDateTime(dateTimeInputNgayTang.Text);
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = tl.DeleteTangLuong(tangluongdto);
                kn.thucthiketnoi(delete);
                dataGridViewLuong.Refresh();
                dataGridViewLuong.DataSource = tl.GetAllTangLuong();
                dataGridViewLuong.Show();
                MessageBox.Show("Xóa thành công");
            }
        }
        /// <summary>
        /// TĂNG LƯƠNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //Load
        private void frmTangLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet27.TangLuong' table. You can move, or remove it, as needed.
            this.tangLuongTableAdapter2.Fill(this.quanLiNhanSu_BTLDataSet27.TangLuong);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet25.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet25.NhanVien);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet18.TangLuong' table. You can move, or remove it, as needed.
            //this.tangLuongTableAdapter1.Fill(this.quanLiNhanSu_BTLDataSet18.TangLuong);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet17.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter1.Fill(this.quanLiNhanSu_BTLDataSet17.Luong);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet16.ChucDanh' table. You can move, or remove it, as needed.
            this.chucDanhTableAdapter1.Fill(this.quanLiNhanSu_BTLDataSet16.ChucDanh);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet15.ChucDanh' table. You can move, or remove it, as needed.
            this.chucDanhTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet15.ChucDanh);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet14.TTCaNhan' table. You can move, or remove it, as needed.
            this.tTCaNhanTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet14.TTCaNhan);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet3.TangLuong' table. You can move, or remove it, as needed.
            //this.tangLuongTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet3.TangLuong);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet2.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet2.Luong);

            kn.ketnoi();
            dataGridViewLuongNV.DataSource = tl.GetLuongNhanVien();
            dataGridViewThayDoiLuong.DataSource = tl.ThongKeLuongNV();
            kn.ngatketnoi();

        }

        //Thoát
        private void buttonX8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// LƯƠNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Mới

        private void buttonX1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        //Hiển thị

        private void dataGridViewLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                MaLuong.Text = dataGridViewLuong.Rows[hang].Cells[0].Value.ToString();
                txtMaCD.Text = dataGridViewLuong.Rows[hang].Cells[1].Value.ToString();
                txtLCB.Text = dataGridViewLuong.Rows[hang].Cells[2].Value.ToString();
                txtChuThich.Text = dataGridViewLuong.Rows[hang].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        //Thêm==========KiemTra
        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                LuongDTO luong = new LuongDTO();
                luong._MaLuong = Convert.ToInt32(MaLuong.Text);
                luong._MaCD = Convert.ToInt32(txtMaCD.Text);
                luong._LCB = Convert.ToDecimal(txtLCB.Text);
                luong._GhiChu = txtChuThich.Text;
                if (MaLuong.Text != "" && txtMaCD.Text != "" && txtLCB.Text != "" && txtChuThich.Text != "")
                {
                    string check = l.InsertLuong(luong);
                    kn.thucthiketnoi(check);
                    dataGridViewLuong.Refresh();
                    dataGridViewLuong.DataSource = l.getAllLuong();
                    dataGridViewLuong.Show();
                    MessageBox.Show("Thêm thành công");
                }
                else MessageBox.Show("Các trường không được để trống");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Sửa========Kiemtra
        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                luongdto._MaLuong = Convert.ToInt32(MaLuong.Text);
                luongdto._MaCD = Convert.ToInt32(txtMaCD.Text);
                luongdto._LCB = Convert.ToDecimal(txtLCB.Text);
                luongdto._GhiChu = txtChuThich.Text;
                string update = l.UpdateLuong(luongdto);
                kn.thucthiketnoi(update);
                dataGridViewLuong.Refresh();
                dataGridViewLuong.DataSource = l.getAllLuong();
                dataGridViewLuong.Show();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        //Xóa


        private void dataGridViewTangLuog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaNV.Text = dataGridViewTangLuog.Rows[hang].Cells[0].Value.ToString();
                txtLCBCu.Text = dataGridViewTangLuog.Rows[hang].Cells[1].Value.ToString();
                txtLCBMoi.Text = dataGridViewTangLuog.Rows[hang].Cells[2].Value.ToString();
                txtTCCu.Text = dataGridViewTangLuog.Rows[hang].Cells[3].Value.ToString();
                txtTCMoi.Text = dataGridViewTangLuog.Rows[hang].Cells[4].Value.ToString();
                dateTimeInputNgayTang.Text = dataGridViewTangLuog.Rows[hang].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }


        private void tabPageLuongNhanVien_Click(object sender, EventArgs e)
        {

            // tl.HienThiLuong(dataGridViewLuong, bindingNavigatorLuongNV);

        }

        private void dataGridViewLuongNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                cbMaNV.Text = dataGridViewLuongNV.Rows[hang].Cells[0].Value.ToString();
                cbTenNV.Text = dataGridViewLuongNV.Rows[hang].Cells[1].Value.ToString();
                cbChucDanh.Text = dataGridViewLuongNV.Rows[hang].Cells[2].Value.ToString();
                cbLCB.Text = dataGridViewLuongNV.Rows[hang].Cells[3].Value.ToString();
                cbTroCap.Text = dataGridViewLuongNV.Rows[hang].Cells[4].Value.ToString();
                cbLuongCung.Text = dataGridViewLuongNV.Rows[hang].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        //private void textBox1_Click(object sender, EventArgs e)
        //{
        //    textBoxTimKiemLuongNV.Text = "";
        //}

        ///
        private void buttonX4_Click(object sender, EventArgs e)
        {
            luongdto._MaLuong = Convert.ToInt32(MaLuong.Text);
            luongdto._MaCD = Convert.ToInt32(txtMaCD.Text);
            luongdto._LCB = Convert.ToDecimal(txtLCB.Text);
            luongdto._GhiChu = txtChuThich.Text;
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = l.DeleteLuong(luongdto);
                kn.thucthiketnoi(delete);
                dataGridViewLuong.Refresh();
                dataGridViewLuong.DataSource = l.getAllLuong();
                dataGridViewLuong.Show();
                MessageBox.Show("Xóa thành công");
            }
        }

        ///click
        private void textBoxTimKiemLuongNV_Click(object sender, EventArgs e)
        {
            textBoxTimKiemLuongNV.Text = "";
        }

        ///Tìm kiếm theo tên nhân viên từ ô text
        private void textBoxTimKiemLuongNV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kn.ketnoi();
                if ((textBoxTimKiemLuongNV.Text == "") || (textBoxTimKiemLuongNV.Text == "Mời nhập tên nhân viên"))
                {
                    dataGridViewLuongNV.DataSource = tl.GetLuongNhanVien();
                }
                else
                {
                    dataGridViewLuongNV.DataSource = tl.TimKiemNVTheoTenNV(textBoxTimKiemLuongNV.Text);
                }
                kn.ngatketnoi();
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
        }

        private void dataGridViewThayDoiLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtTenNV.Text = dataGridViewThayDoiLuong.Rows[hang].Cells[0].Value.ToString();
                txtSoLan.Text = dataGridViewThayDoiLuong.Rows[hang].Cells[1].Value.ToString();
                txtLCBHienTai.Text = dataGridViewThayDoiLuong.Rows[hang].Cells[2].Value.ToString();
                txtThoiDiem.Text = dataGridViewThayDoiLuong.Rows[hang].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }
        private void textBoxTimKiemThayDoiLuong_Click(object sender, EventArgs e)
        {
            textBoxTimKiemThayDoiLuong.Text = "";
        }

        ///Tìm kiếm tên nhân viên Thay đổi lương
        private void textBoxTimKiemThayDoiLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kn.ketnoi();
                if ((textBoxTimKiemLuongNV.Text == "") || (textBoxTimKiemLuongNV.Text == "Nhập vào tên nhân viên"))
                {
                    dataGridViewThayDoiLuong.DataSource = tl.ThongKeLuongNV();
                }
                else
                {
                    dataGridViewThayDoiLuong.DataSource = tl.TimKiemThongKeLuongTheoTen(textBoxTimKiemThayDoiLuong.Text);
                }
                kn.ngatketnoi();
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
using BLL2;
using DataLayer;

namespace QuanLiNhanSu
{
    public partial class frmNhanVien : Form
    {
        NhanVienDTO nvdto = new NhanVienDTO();
        DBConnection kn = new DBConnection();
        NhanVienBLL nv = new NhanVienBLL();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        //Đưa dữ liệu ra datagridview
        //private void frmNhanVien_Load(object sender, EventArgs e)
        //{
        //    nv.HienThi(dataGridView1,bindingNavigator1);
        //}

        //close button
        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhanVien_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet22.TTCaNhan' table. You can move, or remove it, as needed.
            //this.tTCaNhanTableAdapter2.Fill(this.quanLiNhanSu_BTLDataSet22.TTCaNhan);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet10.ChucDanh' table. You can move, or remove it, as needed.
            this.chucDanhTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet10.ChucDanh);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet9.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet9.PhongBan);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet8.TTCaNhan' table. You can move, or remove it, as needed.
            this.tTCaNhanTableAdapter1.Fill(this.quanLiNhanSu_BTLDataSet8.TTCaNhan);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet.NhanVien);
            //hiển thị danh sách loại sản phẩm
            //nv.HienThi(dataGridView1, bindingNavigator1);
            //Hiển thị danh sách mã nhân viên
            //nv.HienthiComboBoxMaNhanVien(txtMaNV);
            //HIển thị danh sách mã phòng ban
            //nv.HienThiComBoBoxMaPB(txtMaPB);
            //Hiển thị danh sách mã chức danh
            //nv.HienThiComBoBoxMaCD(txtMaChucDanh);

        }
        //Hiển thị dữ liệu khi đặt con trỏ ở vị trí dữ liệu
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaNV.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                //comboBox1.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtMaPB.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtMaChucDanh.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                comboBoxLoaiHopDong.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                dateTimePickerNgayKi.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
                dateTimePickerNgayKetThuc.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }
        //Vô hiệu hóa button
        //bool themmoi;
        //public void un_locktext()
        //{
        //    //txtma.Enabled = true;
        //    //txtten.Enabled = true;
        //    //btmoi.Enabled = false;
        //    //btluu.Enabled = true;
        //    //btsua.Enabled = false;
        //    //btxoa.Enabled = false;
        //    txtMaNV.Enabled = true;
        //    txtMaPhongBan.Enabled = true;
        //    txtMaChucDanh.Enabled = true;
        //    btnMoi.Enabled = false;
        //    btnThem.Enabled = true;
        //    btnSua.Enabled = true;
        //    btnXoa.Enabled = true;
        //    btnThoat.Enabled = true;
        //}
        // set null
        //public void setnull()
        //{
        //    //txtma.Text = "";
        //    //txtten.Text = "";
        //    txtMaChucDanh.Text = "";
        //    txtMaNV.Text = "";
        //    txtMaPhongBan.Text = "";
        //    comboBoxLoaiHopDong.Text = "";
        //    dateTimePickerNgayKi.Text = "";
        //    dateTimePickerNgayKetThuc.Text = "";
        //}

        //Thêm mới nhân viên

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                nvdto._MaNV = Convert.ToInt32(txtMaNV.Text);
                nvdto._MaPB = Convert.ToInt32(txtMaPB.Text);
                nvdto._MaCD = Convert.ToInt32(txtMaChucDanh.Text);
                nvdto._LoaiHD = comboBoxLoaiHopDong.Text;
                nvdto._NgayKi = Convert.ToDateTime(dateTimePickerNgayKi.Text);
                nvdto._NgayKT = Convert.ToDateTime(dateTimePickerNgayKetThuc.Text);
                if (txtMaNV.Text != "" && txtMaPB.Text != "" && txtMaChucDanh.Text != "" && comboBoxLoaiHopDong.Text != "" && dateTimePickerNgayKi.Text != "" && dateTimePickerNgayKetThuc.Text != "")
                {
                    string check = nv.InsertNV(nvdto);
                    kn.thucthiketnoi(check);
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = nv.getAllNV();
                    dataGridView1.Show();
                    MessageBox.Show("Thêm thành công");
                }
                else MessageBox.Show("Các trường không được để trống");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        /// <summary>
        /// Sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //string update = "update TblTTNVCoBan set MaBoPhan=N'" + comboBox2.Text + "',MaPhong=N'" + comboBox3.Text + "',HoTen=N'" + textBox4.Text + "',BiDanh=N'" + textBox5.Text + "',NgaySinh='" + dateTimePicker1.Text + "',GioiTinh=N'" + comboBox1.Text + "',TTHonNhan=N'" + textBox8.Text + "',CMTND=N'" + textBox9.Text + "',NgayCap='" + dateTimePicker2.Text + "',NoiCap=N'" + textBox11.Text + "',ChucVu=N'" + textBox12.Text + "',ChucDanh=N'" + textBox13.Text + "',LoaiHD=N'" + textBox14.Text + "',ThoiGian=N'" + textBox15.Text + "',NgayKy='" + dateTimePicker3.Text + "',NgayHetHan='" + dateTimePicker4.Text + "',Anh=N'" + textBox18.Text + "',GhiChu=N'" + textBox19.Text + "' where MaNV=N'" + textBox3.Text + "'";
                //kn.thucthiketnoi(update);
                nvdto._MaNV = Convert.ToInt32(txtMaNV.Text);
                nvdto._MaPB = Convert.ToInt32(txtMaPB.Text);
                nvdto._MaCD = Convert.ToInt32(txtMaChucDanh.Text);
                nvdto._LoaiHD = comboBoxLoaiHopDong.Text;
                nvdto._NgayKi = Convert.ToDateTime(dateTimePickerNgayKi.Text);
                nvdto._NgayKT = Convert.ToDateTime(dateTimePickerNgayKetThuc.Text);
                string update = nv.UpdateNV(nvdto);
                kn.thucthiketnoi(update);
                dataGridView1.Refresh();
                dataGridView1.DataSource = nv.getAllNV();
                dataGridView1.Show();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        ///Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            nvdto._MaNV = Convert.ToInt32(txtMaNV.Text);
            nvdto._MaPB = Convert.ToInt32(txtMaPB.Text);
            nvdto._MaCD = Convert.ToInt32(txtMaChucDanh.Text);
            nvdto._LoaiHD = comboBoxLoaiHopDong.Text;
            nvdto._NgayKi = Convert.ToDateTime(dateTimePickerNgayKi.Text);
            nvdto._NgayKT = Convert.ToDateTime(dateTimePickerNgayKetThuc.Text);
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = nv.DeleteNV(nvdto);
                kn.thucthiketnoi(delete);
                dataGridView1.Refresh();
                dataGridView1.DataSource = nv.getAllNV();
                dataGridView1.Show();
                MessageBox.Show("Xóa thành công.");
            }
        }
    } 
}

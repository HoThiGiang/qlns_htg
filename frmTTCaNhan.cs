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
    public partial class frmTTCaNhan : Form
    {
        DBConnection kn = new DBConnection();
        TTCaNhanBLL tTCaNhanBLL = new TTCaNhanBLL();
        public frmTTCaNhan()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmTTCaNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet5.TTCaNhan' table. You can move, or remove it, as needed.
            this.tTCaNhanTableAdapter1.Fill(this.quanLiNhanSu_BTLDataSet5.TTCaNhan);
            // TODO: This line of code loads data into the 'quanLiNhanSuDataSet1.TTCaNhan' table. You can move, or remove it, as needed.
            this.tTCaNhanTableAdapter.Fill(this.quanLiNhanSuDataSet1.TTCaNhan);

        }

        //HIển thị dữ liệu tại vị trí đặt con trỏ
        //private void dataGridView_TTCaNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
        private void dataGridView_TTCaNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaNV.Text = dataGridView_TTCaNhan.Rows[hang].Cells[0].Value.ToString();
                txtHoTen.Text = dataGridView_TTCaNhan.Rows[hang].Cells[1].Value.ToString();
                dateTimePicker_NgaySinh.Text = dataGridView_TTCaNhan.Rows[hang].Cells[2].Value.ToString();
                comboBox_GioiTinh.Text = dataGridView_TTCaNhan.Rows[hang].Cells[3].Value.ToString();
                txtQueQuan.Text = dataGridView_TTCaNhan.Rows[hang].Cells[4].Value.ToString();
                txtTTHonNhan.Text = dataGridView_TTCaNhan.Rows[hang].Cells[5].Value.ToString();
                dateTimePicker_NgayCap.Text = dataGridView_TTCaNhan.Rows[hang].Cells[6].Value.ToString();
                txtNoiCap.Text = dataGridView_TTCaNhan.Rows[hang].Cells[7].Value.ToString();
                txtSDT.Text = dataGridView_TTCaNhan.Rows[hang].Cells[8].Value.ToString();
                txtDanToc.Text = dataGridView_TTCaNhan.Rows[hang].Cells[9].Value.ToString();
                txtTonGiao.Text = dataGridView_TTCaNhan.Rows[hang].Cells[10].Value.ToString();
                comboBoxHocVan.Text = dataGridView_TTCaNhan.Rows[hang].Cells[11].Value.ToString();
                comboBoxHocHam.Text = dataGridView_TTCaNhan.Rows[hang].Cells[12].Value.ToString();
                txtGhiChu.Text = dataGridView_TTCaNhan.Rows[hang].Cells[13].Value.ToString();
                txtCMND.Text = dataGridView_TTCaNhan.Rows[hang].Cells[14].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

        }

        //Thêm thông tin cá nhân
        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                TTCaNhanDTO ttCaNhan = new TTCaNhanDTO();
                ttCaNhan._MaNV = Convert.ToInt32(txtMaNV.Text);
                ttCaNhan._HoTen = txtHoTen.Text;
                ttCaNhan._QueQuan = txtQueQuan.Text;
                ttCaNhan._SoCMND = Convert.ToInt32(txtCMND.Text);
                ttCaNhan._SĐT = Convert.ToInt32(txtSDT.Text);
                ttCaNhan._TonGiao = txtTonGiao.Text;
                ttCaNhan._TTHonNhan = txtTTHonNhan.Text;
                ttCaNhan._NoiCap = txtNoiCap.Text;
                ttCaNhan._NgaySinh = Convert.ToDateTime(dateTimePicker_NgaySinh.Text);
                ttCaNhan._NgayCap = Convert.ToDateTime(dateTimePicker_NgayCap.Text);
                ttCaNhan._GioiTinh = comboBox_GioiTinh.Text;
                ttCaNhan._HocHam = comboBoxHocHam.Text;
                ttCaNhan._HocVan = comboBoxHocVan.Text;
                ttCaNhan._GhiChu = txtGhiChu.Text;
                ttCaNhan._DanToc = txtDanToc.Text;
                if (txtMaNV.Text!=""&& txtHoTen.Text != "" && txtQueQuan.Text != "" && txtCMND.Text != "" && txtSDT.Text != "" && txtTonGiao.Text != "" && txtTTHonNhan.Text != "" && txtNoiCap.Text != "" && dateTimePicker_NgaySinh.Text != "" && dateTimePicker_NgayCap.Text != "")
                {
                        string check = tTCaNhanBLL.InsertTTCaNhan(ttCaNhan);
                    // string check = ttCaNhan.InsertPB(phongBanDTO);
                        kn.thucthiketnoi(check);
                        dataGridView_TTCaNhan.Refresh();
                        dataGridView_TTCaNhan.DataSource = tTCaNhanBLL.getAllTTCaNhan();
                        dataGridView_TTCaNhan.Show();
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
                if ((ctr is TextBox)||(ctr is DateTimePicker)||(ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        
        //Sửa thông tin cá nhân

        private void btnSua_Click(object sender, EventArgs e)
        {
            TTCaNhanDTO ttCaNhan = new TTCaNhanDTO();
            try
            {
                ttCaNhan._MaNV = Convert.ToInt32(txtMaNV.Text);
                ttCaNhan._HoTen = txtHoTen.Text;
                ttCaNhan._GioiTinh = comboBox_GioiTinh.Text;
                ttCaNhan._HocVan = comboBoxHocVan.Text;
                ttCaNhan._HocHam = comboBoxHocHam.Text;
                ttCaNhan._GhiChu = txtGhiChu.Text;
                ttCaNhan._QueQuan = txtQueQuan.Text;
                ttCaNhan._DanToc = txtDanToc.Text;
                ttCaNhan._SoCMND = Convert.ToInt32(txtCMND.Text);
                ttCaNhan._SĐT = Convert.ToInt32(txtSDT.Text);
                ttCaNhan._TonGiao = txtTonGiao.Text;
                ttCaNhan._TTHonNhan = txtTTHonNhan.Text;
                ttCaNhan._NoiCap = txtNoiCap.Text;
                ttCaNhan._NgaySinh = Convert.ToDateTime(dateTimePicker_NgaySinh.Text);
                ttCaNhan._NgayCap = Convert.ToDateTime(dateTimePicker_NgayCap.Text);
                string update = tTCaNhanBLL.UpdateTTCaNhan(ttCaNhan);
                kn.thucthiketnoi(update);
                dataGridView_TTCaNhan.Refresh();
                dataGridView_TTCaNhan.DataSource = tTCaNhanBLL.getAllTTCaNhan();
                dataGridView_TTCaNhan.Show();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        //Xóa thông tin cá nhân
        private void btnXoa_Click(object sender, EventArgs e)
        {
            TTCaNhanDTO ttCaNhan = new TTCaNhanDTO();
            ttCaNhan._MaNV = Convert.ToInt32(txtMaNV.Text);
            ttCaNhan._HoTen = txtHoTen.Text;
            ttCaNhan._GioiTinh = comboBox_GioiTinh.Text;
            ttCaNhan._HocVan = comboBoxHocVan.Text;
            ttCaNhan._HocHam = comboBoxHocHam.Text;
            ttCaNhan._GhiChu = txtGhiChu.Text;
            ttCaNhan._QueQuan = txtQueQuan.Text;
            ttCaNhan._DanToc = txtDanToc.Text;
            ttCaNhan._SoCMND = Convert.ToInt32(txtCMND.Text);
            ttCaNhan._SĐT = Convert.ToInt32(txtSDT.Text);
            ttCaNhan._TonGiao = txtTonGiao.Text;
            ttCaNhan._TTHonNhan = txtTTHonNhan.Text;
            ttCaNhan._NoiCap = txtNoiCap.Text;
            ttCaNhan._NgaySinh = Convert.ToDateTime(dateTimePicker_NgaySinh.Text);
            ttCaNhan._NgayCap = Convert.ToDateTime(dateTimePicker_NgayCap.Text);

            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                    string delete = tTCaNhanBLL.DeleteTTCaNhan(ttCaNhan);
                    kn.thucthiketnoi(delete);
                    dataGridView_TTCaNhan.Refresh();
                    dataGridView_TTCaNhan.DataSource = tTCaNhanBLL.getAllTTCaNhan();
                    dataGridView_TTCaNhan.Show();
                    MessageBox.Show("Xóa thành công");
            }
            
        }

    }
}

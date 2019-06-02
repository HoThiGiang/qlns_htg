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
    public partial class frmThaiSan : Form
    {
        DBConnection kn = new DBConnection();
        ThaiSanBLL ts = new ThaiSanBLL();
        public frmThaiSan()
        {
            InitializeComponent();
        }
        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThaiSan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet12.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet12.NhanVien);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet11.TTCaNhan' table. You can move, or remove it, as needed.
            this.tTCaNhanTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet11.TTCaNhan);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet6.ThaiSan' table. You can move, or remove it, as needed.
            this.thaiSanTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet6.ThaiSan);
            //ts.HienThi(dataGridViewThaiSan, bindingNavigator1);
        }
        //Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ThaiSanDTO thaisan = new ThaiSanDTO();
                thaisan._MaNV = Convert.ToInt32(txtMaNV.Text);
                thaisan._NgayLamTroLai = Convert.ToDateTime(dateTimeInputNgayLamTroLai.Text);
                thaisan._NgayNghiSinh = Convert.ToDateTime(dateTimeInputNgayNghiSinh.Text);
                thaisan._TroCap = Convert.ToInt32(textBoxTroCap.Text);
                if (txtMaNV.Text != "" && dateTimeInputNgayNghiSinh.Text != "" && dateTimeInputNgayLamTroLai.Text != "" && textBoxTroCap.Text != "")
                {
                    string check = ts.InsertThaiSan(thaisan);
                    kn.thucthiketnoi(check);
                    dataGridViewThaiSan.Refresh();
                    dataGridViewThaiSan.DataSource = ts.getAllThaiSan();
                    dataGridViewThaiSan.Show();
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
                if ((ctr is TextBox) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }
        
        private void dataGridViewThaiSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaNV.Text = dataGridViewThaiSan.Rows[hang].Cells[0].Value.ToString();
                dateTimeInputNgayNghiSinh.Text = dataGridViewThaiSan.Rows[hang].Cells[1].Value.ToString();
                dateTimeInputNgayLamTroLai.Text = dataGridViewThaiSan.Rows[hang].Cells[2].Value.ToString();
                textBoxTroCap.Text = dataGridViewThaiSan.Rows[hang].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }
        //Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            ThaiSanDTO thaisan = new ThaiSanDTO();
            try
            {
                thaisan._MaNV = Convert.ToInt32(txtMaNV.Text);
                thaisan._NgayLamTroLai = Convert.ToDateTime(dateTimeInputNgayLamTroLai.Text);
                thaisan._NgayNghiSinh = Convert.ToDateTime(dateTimeInputNgayNghiSinh.Text);
                thaisan._TroCap = Convert.ToInt32(textBoxTroCap.Text);
                string update = ts.UpdateThaiSan(thaisan);
                kn.thucthiketnoi(update);
                dataGridViewThaiSan.Refresh();
                dataGridViewThaiSan.DataSource = ts.getAllThaiSan();
                dataGridViewThaiSan.Show();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }
        //Xóa

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThaiSanDTO thaisan = new ThaiSanDTO();
            thaisan._MaNV = Convert.ToInt32(txtMaNV.Text);
            thaisan._NgayLamTroLai = Convert.ToDateTime(dateTimeInputNgayLamTroLai.Text);
            thaisan._NgayNghiSinh = Convert.ToDateTime(dateTimeInputNgayNghiSinh.Text);
            thaisan._TroCap = Convert.ToInt32(textBoxTroCap.Text);
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = ts.DeleteThaiSan(thaisan);
                kn.thucthiketnoi(delete);
                dataGridViewThaiSan.Refresh();
                dataGridViewThaiSan.DataSource = ts.getAllThaiSan();
                dataGridViewThaiSan.Show();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmChamCong : Form
    {
        ChamCongDTO chamcongdto = new ChamCongDTO();
        DBConnection kn = new DBConnection();
        ChamCongBLL cc = new ChamCongBLL();
        public frmChamCong()
        {
            InitializeComponent();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //abc

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet24.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet24.NhanVien);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet7.TTCaNhan' table. You can move, or remove it, as needed.
            this.tTCaNhanTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet7.TTCaNhan);
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet4.ChamCong' table. You can move, or remove it, as needed.
            this.chamCongTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet4.ChamCong);
            //cc.HienThi(dataGridView1, bindingNavigator1);
            //cc.HienThiComBoBoxMV(txtMaNV);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaNV.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
                txtThang.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
                txtNam.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
                txtSoNgayCong.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
                txtSoNgayNghi.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                chamcongdto._MaNV = Convert.ToInt32(txtMaNV.Text);
                chamcongdto._SoNgayCong = Convert.ToInt32(txtSoNgayCong.Text);
                chamcongdto._SoNgayNgi = Convert.ToInt32(txtSoNgayNghi.Text);
                chamcongdto._Nam = Convert.ToInt32(txtNam.Text);
                chamcongdto._Thang = Convert.ToInt32(txtThang.Text);
                if (txtMaNV.Text != "" && txtSoNgayCong.Text != "" && txtSoNgayNghi.Text != "" && txtNam.Text !="" && txtThang.Text !="")
                {
                    if (!(cc.CheckID(chamcongdto._MaNV)))
                    {
                        string check = cc.InsertChamCong(chamcongdto);
                        kn.thucthiketnoi(check);
                        dataGridView1.Refresh();
                        dataGridView1.DataSource = cc.GetAllChamCong();
                        dataGridView1.Show();
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Mã phòng ban " + chamcongdto._MaNV + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Các trường không được để trống");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                chamcongdto._MaNV = Convert.ToInt32(txtMaNV.Text);
                chamcongdto._SoNgayCong = Convert.ToInt32(txtSoNgayCong.Text);
                chamcongdto._SoNgayNgi = Convert.ToInt32(txtSoNgayNghi.Text);
                chamcongdto._Nam = Convert.ToInt32(txtNam.Text);
                chamcongdto._Thang = Convert.ToInt32(txtThang.Text);
                string update = cc.UpdateChamCong(chamcongdto);
                kn.thucthiketnoi(update);
                dataGridView1.Refresh();
                dataGridView1.DataSource = cc.GetAllChamCong();
                dataGridView1.Show();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            chamcongdto._MaNV = Convert.ToInt32(txtMaNV.Text);
            chamcongdto._SoNgayCong = Convert.ToInt32(txtSoNgayCong.Text);
            chamcongdto._SoNgayNgi = Convert.ToInt32(txtSoNgayNghi.Text);
            chamcongdto._Nam = Convert.ToInt32(txtNam.Text);
            chamcongdto._Thang = Convert.ToInt32(txtThang.Text);
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = cc.DeleteChamCong(chamcongdto);
                kn.thucthiketnoi(delete);
                dataGridView1.Refresh();
                dataGridView1.DataSource = cc.GetAllChamCong();
                dataGridView1.Show();
                MessageBox.Show("Xóa thành công");
            }
        }
    }
}

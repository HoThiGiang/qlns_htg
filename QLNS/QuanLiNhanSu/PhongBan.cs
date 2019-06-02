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
using System.Data.SqlClient;

namespace QuanLiNhanSu
{
    public partial class frmPhongBan : Form
    {
        DBConnection kn = new DBConnection();
        PhongBanBLL pb = new PhongBanBLL();
        public frmPhongBan()
        {
            InitializeComponent();
        }

        //private void PhongBan_Load(object sender, EventArgs e)
        //{
        //    pb.HienThi(dataGridViewX1,bindingNavigator1);
        //}
        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //bool themmoi;
        public void setnull()
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
        }
        public void un_locktext()
        {
            txtMaPB.Enabled = true;
            txtTenPB.Enabled = true;
            btnMoi.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            //txtma.Enabled = true;
            //txtten.Enabled = true;

            //btmoi.Enabled = false;
            //btluu.Enabled = true;
            //btsua.Enabled = false;
            //btxoa.Enabled = false;
        }
        

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PhongBanDTO phongBanDTO = new PhongBanDTO();
                phongBanDTO._MaPB = Convert.ToInt32(txtMaPB.Text);
                phongBanDTO._TenPB = txtTenPB.Text;
                if (txtMaPB.Text != "" && txtTenPB.Text != "")
                {
                    if (!(pb.CheckID(phongBanDTO._MaPB)))
                    {
                        string check = pb.InsertPB(phongBanDTO);
                        kn.thucthiketnoi(check);
                        dataGridViewX1.Refresh();
                        dataGridViewX1.DataSource = pb.getAllPB();
                        dataGridViewX1.Show();
                        MessageBox.Show("Thêm thành công");
                    }
                    else MessageBox.Show("Mã phòng ban " + phongBanDTO._MaPB + " đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Các trường không được để trống");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bị lỗi ! " + ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelMaPB_Click(object sender, EventArgs e)
        {

        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet1.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet1.PhongBan);

        }
        
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;
                txtMaPB.Text = dataGridViewX1.Rows[hang].Cells[0].Value.ToString();
                txtTenPB.Text = dataGridViewX1.Rows[hang].Cells[1].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("");
            }
        }
        //Sửa phòng ban
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            PhongBanDTO phongBanDTO = new PhongBanDTO();
            try
            {
                phongBanDTO._MaPB = Convert.ToInt32(txtMaPB.Text);
                phongBanDTO._TenPB = txtTenPB.Text;
                string update = pb.UpdatePB(phongBanDTO);
                kn.thucthiketnoi(update);
                dataGridViewX1.Refresh();
                dataGridViewX1.DataSource = pb.getAllPB();
                dataGridViewX1.Show();
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }

        }

        //Xóa phòng ban

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhongBanDTO phongbanDTO = new PhongBanDTO();
            phongbanDTO._MaPB = Convert.ToInt32(txtMaPB.Text);
            phongbanDTO._TenPB = txtTenPB.Text;
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string delete = pb.DeletePB(phongbanDTO);
                kn.thucthiketnoi(delete);
                dataGridViewX1.Refresh();
                dataGridViewX1.DataSource = pb.getAllPB();
                dataGridViewX1.Show();
                MessageBox.Show("Xóa thành công");
            }
        }



    }
}

using BLL2;
using DataLayer;
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
    public partial class frmTimKiem : Form
    {
        DBConnection kn = new DBConnection();
        NhanVienDAL nvdal = new NhanVienDAL();
        //TTCaNhanDAL ttcndal = new TTCaNhanDAL();
        TTCaNhanBLL ttcnbll = new TTCaNhanBLL();
        public frmTimKiem()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSu_BTLDataSet23.TTCaNhan' table. You can move, or remove it, as needed.
            this.tTCaNhanTableAdapter.Fill(this.quanLiNhanSu_BTLDataSet23.TTCaNhan);
            
        }

        int i = 0;
        private void radioButtonMaNV_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
            textBox1.Text = "Mời nhập mã nhân viên";
        }

        private void radioButtonHoTen_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
            textBox1.Text = "Mời nhập Họ tên nhân viên";
        }

        private void radioButtonSoCMND_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
            textBox1.Text = "Mời nhập Số chứng minh nhân dân";
        }

        private void radioButtonChucDanh_CheckedChanged(object sender, EventArgs e)
        {
            i = 4;
            textBox1.Text = "Mời nhập tên chức danh";
        }

        private void radioButtonPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            i = 5;
            textBox1.Text = "Mời nhập tên phòng ban";
        }

        private void radioButtonDienNghiSinh_CheckedChanged(object sender, EventArgs e)
        {
            i = 6;
            textBox1.Text = "Mời nhập Họ tên nhân viên";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("bạn chưa nhập tù khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    kn.ketnoi();
                    if (i == 1)
                    {
                        dataGridView1.DataSource = ttcnbll.TimKiemNVTheoMa(textBox1.Text);
                    }
                    if (i == 2)
                    {
                        dataGridView1.DataSource = ttcnbll.TimKiemNVTheoHoTen(textBox1.Text);
                    }
                    if (i == 3)
                    {
                        dataGridView1.DataSource = ttcnbll.TimKiemNVTheoSoCMND(textBox1.Text);
                    }
                    if (i == 4)
                    {
                        dataGridView1.DataSource = ttcnbll.TimKiemNVTheoChucDanh(textBox1.Text);
                    }
                    if (i == 5)
                    {
                        dataGridView1.DataSource = ttcnbll.TimKiemNVTheoPhongBan(textBox1.Text);
                    }
                    if (i == 6)
                    {
                        dataGridView1.DataSource = ttcnbll.TimKiemNVTheoDienNghiSinh(textBox1.Text);
                    }
                    kn.ngatketnoi();
                }
            }
            catch
            {
                MessageBox.Show("Không tìm thấy thông tin");
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kn.ketnoi();
                if ((textBox1.Text == "") || (textBox1.Text == "Nhập vào từ khóa tìm kiếm") || (textBox1.Text == "Mời nhập mã nhân viên") || (textBox1.Text == "Mời nhập Họ tên nhân viên") || (textBox1.Text == "Mời nhập Số chứng minh nhân dân") || (textBox1.Text == "Mời nhập tên chức danh") || (textBox1.Text == "Mời nhập tên phòng ban"))
                {
                    dataGridView1.DataSource = ttcnbll.getAllTTCaNhan();
                }
                else
                {
                    if (i == 1)
                    {
                        dataGridView1.DataSource = ttcnbll.TimKiemChiTietMaNV(textBox1.Text);
                    }
                    if (i == 2)
                    {
                        dataGridView1.DataSource = ttcnbll.TimKiemChiTietNVTheoHoTen(textBox1.Text);
                    }
                    if (i == 3)
                    {
                        dataGridView1.DataSource = ttcnbll.TimKiemChiTietNVTheoSoCMND(textBox1.Text);
                    }
                }
                kn.ngatketnoi();
            }
            catch
            {
                MessageBox.Show("tìm kiếm sai");
            }
        }


        private void switchButtonNhanVien_ValueChanged(object sender, EventArgs e)
        {
            if (switchButtonNhanVien.Value == true)
            {
                radioButtonMaNV.Enabled = true;
                radioButtonHoTen.Enabled = true;
                radioButtonSoCMND.Enabled = true;
            }
            if (switchButtonNhanVien.Value == false)
            {
                radioButtonMaNV.Enabled = false;
                radioButtonHoTen.Enabled = false;
                radioButtonSoCMND.Enabled = false;
            }
        }
        
        private void switchButtonDienKhac_ValueChanged(object sender, EventArgs e)
        {
            if (switchButtonDienKhac.Value == true)
            {
                radioButtonPhongBan.Enabled = true;
                radioButtonChucDanh.Enabled = true;
                radioButtonDienNghiSinh.Enabled = true;
            }
            if (switchButtonDienKhac.Value == false)
            {
                radioButtonPhongBan.Enabled = false;
                radioButtonChucDanh.Enabled = false;
                radioButtonDienNghiSinh.Enabled = false;
            }
        }

        
    }
    
}

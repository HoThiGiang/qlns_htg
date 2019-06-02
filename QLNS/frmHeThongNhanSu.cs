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
    public partial class frmHeThongNhanSu : Form
    {
        public frmHeThongNhanSu()
        {
            InitializeComponent();
        }

       

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHeThongNhanSu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiNhanSuDataSet2.ChucDanh' table. You can move, or remove it, as needed.
            this.chucDanhTableAdapter.Fill(this.quanLiNhanSuDataSet2.ChucDanh);

        }
    }
}

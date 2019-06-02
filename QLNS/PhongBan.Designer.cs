namespace QuanLiNhanSu
{
    partial class frmPhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaPB = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupBoxPhongBan = new System.Windows.Forms.GroupBox();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnMoi = new DevComponents.DotNetBar.ButtonX();
            this.quanLiNhanSu_BTLDataSet1 = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet1();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongBanTableAdapter = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet1TableAdapters.PhongBanTableAdapter();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBoxPhongBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelMaPB);
            this.groupBox1.Controls.Add(this.txtTenPB);
            this.groupBox1.Controls.Add(this.txtMaPB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng Ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên phòng ban";
            // 
            // labelMaPB
            // 
            this.labelMaPB.AutoSize = true;
            this.labelMaPB.Location = new System.Drawing.Point(26, 26);
            this.labelMaPB.Name = "labelMaPB";
            this.labelMaPB.Size = new System.Drawing.Size(76, 13);
            this.labelMaPB.TabIndex = 5;
            this.labelMaPB.Text = "Mã phòng ban";
            this.labelMaPB.Click += new System.EventHandler(this.labelMaPB_Click);
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(289, 23);
            this.txtTenPB.Multiline = true;
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(181, 22);
            this.txtTenPB.TabIndex = 4;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(102, 21);
            this.txtMaPB.Multiline = true;
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(83, 20);
            this.txtMaPB.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(16, 21);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.SystemColors.Control;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Mã Phòng Ban";
            // 
            // groupBoxPhongBan
            // 
            this.groupBoxPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPhongBan.Controls.Add(this.btnThem);
            this.groupBoxPhongBan.Controls.Add(this.btnThoat);
            this.groupBoxPhongBan.Controls.Add(this.btnXoa);
            this.groupBoxPhongBan.Controls.Add(this.btnSua);
            this.groupBoxPhongBan.Controls.Add(this.btnMoi);
            this.groupBoxPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPhongBan.Location = new System.Drawing.Point(0, 54);
            this.groupBoxPhongBan.Name = "groupBoxPhongBan";
            this.groupBoxPhongBan.Size = new System.Drawing.Size(482, 54);
            this.groupBoxPhongBan.TabIndex = 1;
            this.groupBoxPhongBan.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLiNhanSu.Properties.Resources.add_user;
            this.btnThem.Location = new System.Drawing.Point(137, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 33);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLiNhanSu.Properties.Resources._1;
            this.btnThoat.Location = new System.Drawing.Point(327, 8);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(60, 33);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLiNhanSu.Properties.Resources.remove_user;
            this.btnXoa.Location = new System.Drawing.Point(266, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 33);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLiNhanSu.Properties.Resources.edit_user;
            this.btnSua.Location = new System.Drawing.Point(203, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 34);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMoi.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.btnMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMoi.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.Image = global::QuanLiNhanSu.Properties.Resources.upload;
            this.btnMoi.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnMoi.Location = new System.Drawing.Point(79, 9);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(53, 32);
            this.btnMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMoi.TabIndex = 0;
            this.btnMoi.Text = "Mới";
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // quanLiNhanSu_BTLDataSet1
            // 
            this.quanLiNhanSu_BTLDataSet1.DataSetName = "QuanLiNhanSu_BTLDataSet1";
            this.quanLiNhanSu_BTLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this.quanLiNhanSu_BTLDataSet1;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPBDataGridViewTextBoxColumn,
            this.tenPBDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.phongBanBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 108);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.Size = new System.Drawing.Size(482, 230);
            this.dataGridViewX1.TabIndex = 4;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "MaPB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "Mã phòng ban";
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            this.maPBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenPBDataGridViewTextBoxColumn
            // 
            this.tenPBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenPBDataGridViewTextBoxColumn.DataPropertyName = "TenPB";
            this.tenPBDataGridViewTextBoxColumn.HeaderText = "Tên phòng ban";
            this.tenPBDataGridViewTextBoxColumn.Name = "tenPBDataGridViewTextBoxColumn";
            this.tenPBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.afsadfdafdfaf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 338);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.groupBoxPhongBan);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhongBan";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPhongBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxPhongBan;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnMoi;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Label labelMaPB;
        private QuanLiNhanSu_BTLDataSet1 quanLiNhanSu_BTLDataSet1;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private QuanLiNhanSu_BTLDataSet1TableAdapters.PhongBanTableAdapter phongBanTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPBDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
    }
}
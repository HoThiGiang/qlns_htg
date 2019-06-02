namespace QuanLiNhanSu
{
    partial class frmTimKiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonMaNV = new System.Windows.Forms.RadioButton();
            this.radioButtonHoTen = new System.Windows.Forms.RadioButton();
            this.radioButtonSoCMND = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonDienNghiSinh = new System.Windows.Forms.RadioButton();
            this.radioButtonPhongBan = new System.Windows.Forms.RadioButton();
            this.radioButtonChucDanh = new System.Windows.Forms.RadioButton();
            this.switchButtonDienKhac = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.label2 = new System.Windows.Forms.Label();
            this.switchButtonNhanVien = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.quanLiNhanSu_BTLDataSet23 = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet23();
            this.tTCaNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTCaNhanTableAdapter = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet23TableAdapters.TTCaNhanTableAdapter();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTHonNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sĐTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danTocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonGiaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocVanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocHamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTCaNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.timkiem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm Kiếm ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(211, 20);
            this.textBox1.MaximumSize = new System.Drawing.Size(277, 20);
            this.textBox1.MinimumSize = new System.Drawing.Size(277, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Nhập vào từ khóa tìm kiếm";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // radioButtonMaNV
            // 
            this.radioButtonMaNV.AutoSize = true;
            this.radioButtonMaNV.Enabled = false;
            this.radioButtonMaNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMaNV.Location = new System.Drawing.Point(229, 67);
            this.radioButtonMaNV.Name = "radioButtonMaNV";
            this.radioButtonMaNV.Size = new System.Drawing.Size(99, 19);
            this.radioButtonMaNV.TabIndex = 9;
            this.radioButtonMaNV.TabStop = true;
            this.radioButtonMaNV.Text = "Mã nhân viên";
            this.radioButtonMaNV.UseVisualStyleBackColor = true;
            this.radioButtonMaNV.CheckedChanged += new System.EventHandler(this.radioButtonMaNV_CheckedChanged);
            // 
            // radioButtonHoTen
            // 
            this.radioButtonHoTen.AutoSize = true;
            this.radioButtonHoTen.Enabled = false;
            this.radioButtonHoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHoTen.Location = new System.Drawing.Point(330, 66);
            this.radioButtonHoTen.Name = "radioButtonHoTen";
            this.radioButtonHoTen.Size = new System.Drawing.Size(77, 19);
            this.radioButtonHoTen.TabIndex = 10;
            this.radioButtonHoTen.TabStop = true;
            this.radioButtonHoTen.Text = "Họ và tên";
            this.radioButtonHoTen.UseVisualStyleBackColor = true;
            this.radioButtonHoTen.CheckedChanged += new System.EventHandler(this.radioButtonHoTen_CheckedChanged);
            // 
            // radioButtonSoCMND
            // 
            this.radioButtonSoCMND.AutoSize = true;
            this.radioButtonSoCMND.Enabled = false;
            this.radioButtonSoCMND.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSoCMND.Location = new System.Drawing.Point(414, 67);
            this.radioButtonSoCMND.Name = "radioButtonSoCMND";
            this.radioButtonSoCMND.Size = new System.Drawing.Size(80, 19);
            this.radioButtonSoCMND.TabIndex = 11;
            this.radioButtonSoCMND.TabStop = true;
            this.radioButtonSoCMND.Text = "Số CMND";
            this.radioButtonSoCMND.UseVisualStyleBackColor = true;
            this.radioButtonSoCMND.CheckedChanged += new System.EventHandler(this.radioButtonSoCMND_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButtonDienNghiSinh);
            this.groupBox1.Controls.Add(this.radioButtonPhongBan);
            this.groupBox1.Controls.Add(this.radioButtonChucDanh);
            this.groupBox1.Controls.Add(this.switchButtonDienKhac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.switchButtonNhanVien);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.radioButtonSoCMND);
            this.groupBox1.Controls.Add(this.radioButtonHoTen);
            this.groupBox1.Controls.Add(this.radioButtonMaNV);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(160, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Thuộc diện";
            // 
            // radioButtonDienNghiSinh
            // 
            this.radioButtonDienNghiSinh.AutoSize = true;
            this.radioButtonDienNghiSinh.Enabled = false;
            this.radioButtonDienNghiSinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDienNghiSinh.Location = new System.Drawing.Point(414, 112);
            this.radioButtonDienNghiSinh.Name = "radioButtonDienNghiSinh";
            this.radioButtonDienNghiSinh.Size = new System.Drawing.Size(103, 19);
            this.radioButtonDienNghiSinh.TabIndex = 19;
            this.radioButtonDienNghiSinh.TabStop = true;
            this.radioButtonDienNghiSinh.Text = "Diện nghỉ sinh";
            this.radioButtonDienNghiSinh.UseVisualStyleBackColor = true;
            this.radioButtonDienNghiSinh.CheckedChanged += new System.EventHandler(this.radioButtonDienNghiSinh_CheckedChanged);
            // 
            // radioButtonPhongBan
            // 
            this.radioButtonPhongBan.AutoSize = true;
            this.radioButtonPhongBan.Enabled = false;
            this.radioButtonPhongBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPhongBan.Location = new System.Drawing.Point(327, 112);
            this.radioButtonPhongBan.Name = "radioButtonPhongBan";
            this.radioButtonPhongBan.Size = new System.Drawing.Size(83, 19);
            this.radioButtonPhongBan.TabIndex = 18;
            this.radioButtonPhongBan.TabStop = true;
            this.radioButtonPhongBan.Text = "Phòng ban";
            this.radioButtonPhongBan.UseVisualStyleBackColor = true;
            this.radioButtonPhongBan.CheckedChanged += new System.EventHandler(this.radioButtonPhongBan_CheckedChanged);
            // 
            // radioButtonChucDanh
            // 
            this.radioButtonChucDanh.AutoSize = true;
            this.radioButtonChucDanh.Enabled = false;
            this.radioButtonChucDanh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChucDanh.Location = new System.Drawing.Point(229, 113);
            this.radioButtonChucDanh.Name = "radioButtonChucDanh";
            this.radioButtonChucDanh.Size = new System.Drawing.Size(83, 19);
            this.radioButtonChucDanh.TabIndex = 17;
            this.radioButtonChucDanh.TabStop = true;
            this.radioButtonChucDanh.Text = "Chức danh";
            this.radioButtonChucDanh.UseVisualStyleBackColor = true;
            this.radioButtonChucDanh.CheckedChanged += new System.EventHandler(this.radioButtonChucDanh_CheckedChanged);
            // 
            // switchButtonDienKhac
            // 
            // 
            // 
            // 
            this.switchButtonDienKhac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButtonDienKhac.Location = new System.Drawing.Point(163, 113);
            this.switchButtonDienKhac.Name = "switchButtonDienKhac";
            this.switchButtonDienKhac.OnText = "Chọn";
            this.switchButtonDienKhac.Size = new System.Drawing.Size(50, 15);
            this.switchButtonDienKhac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButtonDienKhac.TabIndex = 16;
            this.switchButtonDienKhac.ValueChanged += new System.EventHandler(this.switchButtonDienKhac_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(158, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Thông tin lí lịch";
            // 
            // switchButtonNhanVien
            // 
            // 
            // 
            // 
            this.switchButtonNhanVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButtonNhanVien.Location = new System.Drawing.Point(162, 67);
            this.switchButtonNhanVien.Name = "switchButtonNhanVien";
            this.switchButtonNhanVien.OnText = "Chọn";
            this.switchButtonNhanVien.Size = new System.Drawing.Size(50, 15);
            this.switchButtonNhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButtonNhanVien.TabIndex = 14;
            this.switchButtonNhanVien.ValueChanged += new System.EventHandler(this.switchButtonNhanVien_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLiNhanSu.Properties.Resources.button3_Image;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(323, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::QuanLiNhanSu.Properties.Resources.tim;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(224, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Tìm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // quanLiNhanSu_BTLDataSet23
            // 
            this.quanLiNhanSu_BTLDataSet23.DataSetName = "QuanLiNhanSu_BTLDataSet23";
            this.quanLiNhanSu_BTLDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTCaNhanBindingSource
            // 
            this.tTCaNhanBindingSource.DataMember = "TTCaNhan";
            this.tTCaNhanBindingSource.DataSource = this.quanLiNhanSu_BTLDataSet23;
            // 
            // tTCaNhanTableAdapter
            // 
            this.tTCaNhanTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn,
            this.tTHonNhanDataGridViewTextBoxColumn,
            this.soCMNDDataGridViewTextBoxColumn,
            this.ngayCapDataGridViewTextBoxColumn,
            this.noiCapDataGridViewTextBoxColumn,
            this.sĐTDataGridViewTextBoxColumn,
            this.danTocDataGridViewTextBoxColumn,
            this.tonGiaoDataGridViewTextBoxColumn,
            this.hocVanDataGridViewTextBoxColumn,
            this.hocHamDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tTCaNhanBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 177);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(626, 334);
            this.dataGridView1.TabIndex = 3;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maNVDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 50;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "Quê quán";
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            // 
            // tTHonNhanDataGridViewTextBoxColumn
            // 
            this.tTHonNhanDataGridViewTextBoxColumn.DataPropertyName = "TTHonNhan";
            this.tTHonNhanDataGridViewTextBoxColumn.HeaderText = "TT hôn nhân";
            this.tTHonNhanDataGridViewTextBoxColumn.Name = "tTHonNhanDataGridViewTextBoxColumn";
            // 
            // soCMNDDataGridViewTextBoxColumn
            // 
            this.soCMNDDataGridViewTextBoxColumn.DataPropertyName = "SoCMND";
            this.soCMNDDataGridViewTextBoxColumn.HeaderText = "Số CMND";
            this.soCMNDDataGridViewTextBoxColumn.Name = "soCMNDDataGridViewTextBoxColumn";
            // 
            // ngayCapDataGridViewTextBoxColumn
            // 
            this.ngayCapDataGridViewTextBoxColumn.DataPropertyName = "NgayCap";
            this.ngayCapDataGridViewTextBoxColumn.HeaderText = "Ngày cấp";
            this.ngayCapDataGridViewTextBoxColumn.Name = "ngayCapDataGridViewTextBoxColumn";
            // 
            // noiCapDataGridViewTextBoxColumn
            // 
            this.noiCapDataGridViewTextBoxColumn.DataPropertyName = "NoiCap";
            this.noiCapDataGridViewTextBoxColumn.HeaderText = "Nơi cấp";
            this.noiCapDataGridViewTextBoxColumn.Name = "noiCapDataGridViewTextBoxColumn";
            // 
            // sĐTDataGridViewTextBoxColumn
            // 
            this.sĐTDataGridViewTextBoxColumn.DataPropertyName = "SĐT";
            this.sĐTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sĐTDataGridViewTextBoxColumn.Name = "sĐTDataGridViewTextBoxColumn";
            // 
            // danTocDataGridViewTextBoxColumn
            // 
            this.danTocDataGridViewTextBoxColumn.DataPropertyName = "DanToc";
            this.danTocDataGridViewTextBoxColumn.HeaderText = "Dân tộc";
            this.danTocDataGridViewTextBoxColumn.Name = "danTocDataGridViewTextBoxColumn";
            // 
            // tonGiaoDataGridViewTextBoxColumn
            // 
            this.tonGiaoDataGridViewTextBoxColumn.DataPropertyName = "TonGiao";
            this.tonGiaoDataGridViewTextBoxColumn.HeaderText = "Tôn giáo";
            this.tonGiaoDataGridViewTextBoxColumn.Name = "tonGiaoDataGridViewTextBoxColumn";
            // 
            // hocVanDataGridViewTextBoxColumn
            // 
            this.hocVanDataGridViewTextBoxColumn.DataPropertyName = "HocVan";
            this.hocVanDataGridViewTextBoxColumn.HeaderText = "Học vấn";
            this.hocVanDataGridViewTextBoxColumn.Name = "hocVanDataGridViewTextBoxColumn";
            // 
            // hocHamDataGridViewTextBoxColumn
            // 
            this.hocHamDataGridViewTextBoxColumn.DataPropertyName = "HocHam";
            this.hocHamDataGridViewTextBoxColumn.HeaderText = "Học hàm";
            this.hocHamDataGridViewTextBoxColumn.Name = "hocHamDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 5;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.afsadfdafdfaf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiem";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTCaNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonMaNV;
        private System.Windows.Forms.RadioButton radioButtonHoTen;
        private System.Windows.Forms.RadioButton radioButtonSoCMND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private QuanLiNhanSu_BTLDataSet23 quanLiNhanSu_BTLDataSet23;
        private System.Windows.Forms.BindingSource tTCaNhanBindingSource;
        private QuanLiNhanSu_BTLDataSet23TableAdapters.TTCaNhanTableAdapter tTCaNhanTableAdapter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTHonNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sĐTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danTocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonGiaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocVanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocHamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButtonNhanVien;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButtonDienKhac;
        private System.Windows.Forms.RadioButton radioButtonDienNghiSinh;
        private System.Windows.Forms.RadioButton radioButtonPhongBan;
        private System.Windows.Forms.RadioButton radioButtonChucDanh;
        private System.Windows.Forms.Label label3;
    }
}
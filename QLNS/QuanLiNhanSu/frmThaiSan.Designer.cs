namespace QuanLiNhanSu
{
    partial class frmThaiSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThaiSan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiNhanSu_BTLDataSet12 = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet12();
            this.textBoxTroCap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dateTimeInputNgayLamTroLai = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInputNgayNghiSinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnMoi = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewThaiSan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNghiSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLamTroLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.troCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thaiSanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiNhanSu_BTLDataSet6 = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet6();
            this.thaiSanTableAdapter = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet6TableAdapters.ThaiSanTableAdapter();
            this.quanLiNhanSu_BTLDataSet11 = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet11();
            this.tTCaNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTCaNhanTableAdapter = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet11TableAdapters.TTCaNhanTableAdapter();
            this.nhanVienTableAdapter = new QuanLiNhanSu.QuanLiNhanSu_BTLDataSet12TableAdapters.NhanVienTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputNgayLamTroLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputNgayNghiSinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThaiSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thaiSanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTCaNhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.textBoxTroCap);
            this.groupBox1.Controls.Add(this.dateTimeInputNgayLamTroLai);
            this.groupBox1.Controls.Add(this.dateTimeInputNgayNghiSinh);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thai sản";
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataSource = this.nhanVienBindingSource;
            this.txtMaNV.DisplayMember = "MaNV";
            this.txtMaNV.FormattingEnabled = true;
            this.txtMaNV.Location = new System.Drawing.Point(126, 16);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(104, 23);
            this.txtMaNV.TabIndex = 15;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLiNhanSu_BTLDataSet12;
            // 
            // quanLiNhanSu_BTLDataSet12
            // 
            this.quanLiNhanSu_BTLDataSet12.DataSetName = "QuanLiNhanSu_BTLDataSet12";
            this.quanLiNhanSu_BTLDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxTroCap
            // 
            // 
            // 
            // 
            this.textBoxTroCap.Border.Class = "TextBoxBorder";
            this.textBoxTroCap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTroCap.Location = new System.Drawing.Point(125, 109);
            this.textBoxTroCap.Name = "textBoxTroCap";
            this.textBoxTroCap.PreventEnterBeep = true;
            this.textBoxTroCap.Size = new System.Drawing.Size(134, 21);
            this.textBoxTroCap.TabIndex = 11;
            // 
            // dateTimeInputNgayLamTroLai
            // 
            // 
            // 
            // 
            this.dateTimeInputNgayLamTroLai.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputNgayLamTroLai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputNgayLamTroLai.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputNgayLamTroLai.ButtonDropDown.Visible = true;
            this.dateTimeInputNgayLamTroLai.IsPopupCalendarOpen = false;
            this.dateTimeInputNgayLamTroLai.Location = new System.Drawing.Point(127, 78);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInputNgayLamTroLai.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputNgayLamTroLai.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputNgayLamTroLai.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.DisplayMonth = new System.DateTime(2019, 3, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeInputNgayLamTroLai.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputNgayLamTroLai.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputNgayLamTroLai.Name = "dateTimeInputNgayLamTroLai";
            this.dateTimeInputNgayLamTroLai.Size = new System.Drawing.Size(133, 21);
            this.dateTimeInputNgayLamTroLai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputNgayLamTroLai.TabIndex = 9;
            // 
            // dateTimeInputNgayNghiSinh
            // 
            // 
            // 
            // 
            this.dateTimeInputNgayNghiSinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputNgayNghiSinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputNgayNghiSinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputNgayNghiSinh.ButtonDropDown.Visible = true;
            this.dateTimeInputNgayNghiSinh.IsPopupCalendarOpen = false;
            this.dateTimeInputNgayNghiSinh.Location = new System.Drawing.Point(125, 46);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimeInputNgayNghiSinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputNgayNghiSinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputNgayNghiSinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.DisplayMonth = new System.DateTime(2019, 3, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dateTimeInputNgayNghiSinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputNgayNghiSinh.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputNgayNghiSinh.Name = "dateTimeInputNgayNghiSinh";
            this.dateTimeInputNgayNghiSinh.Size = new System.Drawing.Size(134, 21);
            this.dateTimeInputNgayNghiSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInputNgayNghiSinh.TabIndex = 8;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(34, 107);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 25);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Trợ cấp";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(35, 78);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(89, 25);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Ngày làm trở lại";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(34, 48);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 25);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Ngày nghỉ sinh";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(34, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 25);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnMoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLiNhanSu.Properties.Resources._12;
            this.btnThoat.Location = new System.Drawing.Point(368, 11);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(63, 27);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLiNhanSu.Properties.Resources.remove_user;
            this.btnXoa.Location = new System.Drawing.Point(295, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 27);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLiNhanSu.Properties.Resources.edit_user;
            this.btnSua.Location = new System.Drawing.Point(222, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 27);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLiNhanSu.Properties.Resources.add_user;
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(155, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 27);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMoi.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.btnMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnMoi.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.Image = global::QuanLiNhanSu.Properties.Resources.upload;
            this.btnMoi.Location = new System.Drawing.Point(85, 11);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(63, 27);
            this.btnMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMoi.TabIndex = 0;
            this.btnMoi.Text = "Mới";
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // dataGridViewThaiSan
            // 
            this.dataGridViewThaiSan.AllowUserToAddRows = false;
            this.dataGridViewThaiSan.AutoGenerateColumns = false;
            this.dataGridViewThaiSan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewThaiSan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewThaiSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThaiSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.ngayNghiSinhDataGridViewTextBoxColumn,
            this.ngayLamTroLaiDataGridViewTextBoxColumn,
            this.troCapDataGridViewTextBoxColumn});
            this.dataGridViewThaiSan.DataSource = this.thaiSanBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewThaiSan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewThaiSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewThaiSan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewThaiSan.Location = new System.Drawing.Point(0, 184);
            this.dataGridViewThaiSan.Name = "dataGridViewThaiSan";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewThaiSan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewThaiSan.Size = new System.Drawing.Size(549, 426);
            this.dataGridViewThaiSan.TabIndex = 4;
            this.dataGridViewThaiSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThaiSan_CellClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // ngayNghiSinhDataGridViewTextBoxColumn
            // 
            this.ngayNghiSinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayNghiSinhDataGridViewTextBoxColumn.DataPropertyName = "NgayNghiSinh";
            this.ngayNghiSinhDataGridViewTextBoxColumn.HeaderText = "Ngày nghỉ sinh";
            this.ngayNghiSinhDataGridViewTextBoxColumn.Name = "ngayNghiSinhDataGridViewTextBoxColumn";
            this.ngayNghiSinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayLamTroLaiDataGridViewTextBoxColumn
            // 
            this.ngayLamTroLaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ngayLamTroLaiDataGridViewTextBoxColumn.DataPropertyName = "NgayLamTroLai";
            this.ngayLamTroLaiDataGridViewTextBoxColumn.HeaderText = "Ngày làm trở lại";
            this.ngayLamTroLaiDataGridViewTextBoxColumn.Name = "ngayLamTroLaiDataGridViewTextBoxColumn";
            this.ngayLamTroLaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // troCapDataGridViewTextBoxColumn
            // 
            this.troCapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.troCapDataGridViewTextBoxColumn.DataPropertyName = "TroCap";
            this.troCapDataGridViewTextBoxColumn.HeaderText = "Trợ cấp";
            this.troCapDataGridViewTextBoxColumn.Name = "troCapDataGridViewTextBoxColumn";
            // 
            // thaiSanBindingSource
            // 
            this.thaiSanBindingSource.DataMember = "ThaiSan";
            this.thaiSanBindingSource.DataSource = this.quanLiNhanSu_BTLDataSet6;
            // 
            // quanLiNhanSu_BTLDataSet6
            // 
            this.quanLiNhanSu_BTLDataSet6.DataSetName = "QuanLiNhanSu_BTLDataSet6";
            this.quanLiNhanSu_BTLDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thaiSanTableAdapter
            // 
            this.thaiSanTableAdapter.ClearBeforeFill = true;
            // 
            // quanLiNhanSu_BTLDataSet11
            // 
            this.quanLiNhanSu_BTLDataSet11.DataSetName = "QuanLiNhanSu_BTLDataSet11";
            this.quanLiNhanSu_BTLDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTCaNhanBindingSource
            // 
            this.tTCaNhanBindingSource.DataMember = "TTCaNhan";
            this.tTCaNhanBindingSource.DataSource = this.quanLiNhanSu_BTLDataSet11;
            // 
            // tTCaNhanTableAdapter
            // 
            this.tTCaNhanTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmThaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.afsadfdafdfaf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 610);
            this.Controls.Add(this.dataGridViewThaiSan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThaiSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThaiSan";
            this.Load += new System.EventHandler(this.frmThaiSan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputNgayLamTroLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputNgayNghiSinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThaiSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thaiSanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSu_BTLDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTCaNhanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxTroCap;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputNgayLamTroLai;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnMoi;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputNgayNghiSinh;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewThaiSan;
        private QuanLiNhanSu_BTLDataSet6 quanLiNhanSu_BTLDataSet6;
        private System.Windows.Forms.BindingSource thaiSanBindingSource;
        private QuanLiNhanSu_BTLDataSet6TableAdapters.ThaiSanTableAdapter thaiSanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNghiSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLamTroLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn troCapDataGridViewTextBoxColumn;
        private QuanLiNhanSu_BTLDataSet11 quanLiNhanSu_BTLDataSet11;
        private System.Windows.Forms.BindingSource tTCaNhanBindingSource;
        private QuanLiNhanSu_BTLDataSet11TableAdapters.TTCaNhanTableAdapter tTCaNhanTableAdapter;
        private QuanLiNhanSu_BTLDataSet12 quanLiNhanSu_BTLDataSet12;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLiNhanSu_BTLDataSet12TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.ComboBox txtMaNV;
    }
}
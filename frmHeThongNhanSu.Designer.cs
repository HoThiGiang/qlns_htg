namespace QuanLiNhanSu
{
    partial class frmHeThongNhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeThongNhanSu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenCD = new System.Windows.Forms.TextBox();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.maCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucDanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiNhanSuDataSet2 = new QuanLiNhanSu.QuanLiNhanSuDataSet2();
            this.chucDanhTableAdapter = new QuanLiNhanSu.QuanLiNhanSuDataSet2TableAdapters.ChucDanhTableAdapter();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucDanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSuDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTenCD);
            this.groupBox1.Controls.Add(this.txtMaCD);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lí nhân sự";
            // 
            // txtTenCD
            // 
            this.txtTenCD.Location = new System.Drawing.Point(186, 95);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Size = new System.Drawing.Size(142, 22);
            this.txtTenCD.TabIndex = 5;
            // 
            // txtMaCD
            // 
            this.txtMaCD.Location = new System.Drawing.Point(188, 61);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(142, 22);
            this.txtMaCD.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(188, 24);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(142, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(82, 95);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(85, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Tên chức danh";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(82, 58);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mã chức danh";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(84, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Họ tên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCDDataGridViewTextBoxColumn,
            this.tenCDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chucDanhBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 199);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(503, 316);
            this.dataGridView1.TabIndex = 4;
            // 
            // maCDDataGridViewTextBoxColumn
            // 
            this.maCDDataGridViewTextBoxColumn.DataPropertyName = "MaCD";
            this.maCDDataGridViewTextBoxColumn.HeaderText = "Mã chức danh";
            this.maCDDataGridViewTextBoxColumn.Name = "maCDDataGridViewTextBoxColumn";
            // 
            // tenCDDataGridViewTextBoxColumn
            // 
            this.tenCDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenCDDataGridViewTextBoxColumn.DataPropertyName = "TenCD";
            this.tenCDDataGridViewTextBoxColumn.HeaderText = "Tên chức danh";
            this.tenCDDataGridViewTextBoxColumn.Name = "tenCDDataGridViewTextBoxColumn";
            // 
            // chucDanhBindingSource
            // 
            this.chucDanhBindingSource.DataMember = "ChucDanh";
            this.chucDanhBindingSource.DataSource = this.quanLiNhanSuDataSet2;
            // 
            // quanLiNhanSuDataSet2
            // 
            this.quanLiNhanSuDataSet2.DataSetName = "QuanLiNhanSuDataSet2";
            this.quanLiNhanSuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chucDanhTableAdapter
            // 
            this.chucDanhTableAdapter.ClearBeforeFill = true;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonX1.BackgroundImage")));
            this.buttonX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX1.Image = global::QuanLiNhanSu.Properties.Resources.upload;
            this.buttonX1.Location = new System.Drawing.Point(85, 12);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(53, 37);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Mới";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonX2.BackgroundImage")));
            this.buttonX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX2.Image = global::QuanLiNhanSu.Properties.Resources.add_user;
            this.buttonX2.Location = new System.Drawing.Point(143, 12);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(56, 37);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "Thêm";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonX3.BackgroundImage")));
            this.buttonX3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX3.Image = global::QuanLiNhanSu.Properties.Resources.edit_user;
            this.buttonX3.Location = new System.Drawing.Point(206, 13);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(55, 35);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 2;
            this.buttonX3.Text = "Sửa";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonX4.BackgroundImage")));
            this.buttonX4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX4.Image = global::QuanLiNhanSu.Properties.Resources.remove_user;
            this.buttonX4.Location = new System.Drawing.Point(269, 13);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(55, 37);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 3;
            this.buttonX4.Text = "Xóa";
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonX5.BackgroundImage")));
            this.buttonX5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX5.Image = global::QuanLiNhanSu.Properties.Resources._11;
            this.buttonX5.Location = new System.Drawing.Point(332, 13);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(58, 37);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 4;
            this.buttonX5.Text = "Thoát";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonX5);
            this.groupBox2.Controls.Add(this.buttonX4);
            this.groupBox2.Controls.Add(this.buttonX3);
            this.groupBox2.Controls.Add(this.buttonX2);
            this.groupBox2.Controls.Add(this.buttonX1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // frmHeThongNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.afsadfdafdfaf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 515);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHeThongNhanSu";
            this.Text = "frmHeThongNhanSu";
            this.Load += new System.EventHandler(this.frmHeThongNhanSu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucDanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiNhanSuDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.TextBox txtHoTen;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private QuanLiNhanSuDataSet2 quanLiNhanSuDataSet2;
        private System.Windows.Forms.BindingSource chucDanhBindingSource;
        private QuanLiNhanSuDataSet2TableAdapters.ChucDanhTableAdapter chucDanhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtTenCD;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
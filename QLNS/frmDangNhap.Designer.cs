namespace QuanLiNhanSu
{
    public partial class frmDangNhap
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
        public void InitializeComponent()
        {
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.richTextBox_TenDN = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.richTextBox_MatKhau = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangNhap.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnDangNhap.Image = global::QuanLiNhanSu.Properties.Resources.DanToc;
            this.btnDangNhap.Location = new System.Drawing.Point(42, 237);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(84, 34);
            this.btnDangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.xanh;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnThoat.Image = global::QuanLiNhanSu.Properties.Resources.button3_Image;
            this.btnThoat.Location = new System.Drawing.Point(152, 237);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 34);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // richTextBox_TenDN
            // 
            // 
            // 
            // 
            this.richTextBox_TenDN.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBox_TenDN.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBox_TenDN.Location = new System.Drawing.Point(21, 131);
            this.richTextBox_TenDN.Name = "richTextBox_TenDN";
            this.richTextBox_TenDN.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBox_TenDN.Size = new System.Drawing.Size(230, 30);
            this.richTextBox_TenDN.TabIndex = 5;
            // 
            // richTextBox_MatKhau
            // 
            // 
            // 
            // 
            this.richTextBox_MatKhau.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBox_MatKhau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBox_MatKhau.Location = new System.Drawing.Point(22, 184);
            this.richTextBox_MatKhau.Name = "richTextBox_MatKhau";
            this.richTextBox_MatKhau.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBox_MatKhau.Size = new System.Drawing.Size(230, 30);
            this.richTextBox_MatKhau.TabIndex = 6;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.lgin_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(275, 308);
            this.Controls.Add(this.richTextBox_MatKhau);
            this.Controls.Add(this.richTextBox_TenDN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX btnDangNhap;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        public DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox_TenDN;
        public DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox_MatKhau;
    }
}
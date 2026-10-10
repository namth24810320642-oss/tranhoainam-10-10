namespace bai5._1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.CheckBox chkDieuKhoan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ErrorProvider epCheck;

    protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDe = new System.Windows.Forms.Label();
            lblTenDangNhap = new System.Windows.Forms.Label();
            lblMatKhau = new System.Windows.Forms.Label();
            lblXacNhanMatKhau = new System.Windows.Forms.Label();
            lblNgaySinh = new System.Windows.Forms.Label();
            lblGioiTinh = new System.Windows.Forms.Label();
            txtTenDangNhap = new System.Windows.Forms.TextBox();
            txtMatKhau = new System.Windows.Forms.TextBox();
            txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            rbNam = new System.Windows.Forms.RadioButton();
            rbNu = new System.Windows.Forms.RadioButton();
            chkDieuKhoan = new System.Windows.Forms.CheckBox();
            btnDangKy = new System.Windows.Forms.Button();
            btnLamMoi = new System.Windows.Forms.Button();
            epCheck = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();

            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTieuDe.ForeColor = System.Drawing.Color.DarkBlue;
            lblTieuDe.Location = new System.Drawing.Point(105, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new System.Drawing.Size(290, 30);
            lblTieuDe.Text = "ĐĂNG KÝ TÀI KHOẢN";

            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new System.Drawing.Point(35, 80);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new System.Drawing.Size(94, 15);
            lblTenDangNhap.Text = "Tên đăng nhập:";

            txtTenDangNhap.Location = new System.Drawing.Point(180, 76);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new System.Drawing.Size(250, 23);
            txtTenDangNhap.TabIndex = 0;

            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new System.Drawing.Point(35, 125);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new System.Drawing.Size(60, 15);
            lblMatKhau.Text = "Mật khẩu:";

            txtMatKhau.Location = new System.Drawing.Point(180, 121);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new System.Drawing.Size(250, 23);
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TabIndex = 1;

            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Location = new System.Drawing.Point(35, 170);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new System.Drawing.Size(116, 15);
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu:";

            txtXacNhanMatKhau.Location = new System.Drawing.Point(180, 166);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new System.Drawing.Size(250, 23);
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            txtXacNhanMatKhau.TabIndex = 2;

            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new System.Drawing.Point(35, 215);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new System.Drawing.Size(61, 15);
            lblNgaySinh.Text = "Ngày sinh:";

            dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new System.Drawing.Point(180, 211);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.MaxDate = System.DateTime.Today;
            dtpNgaySinh.Value = System.DateTime.Today.AddYears(-18);
            dtpNgaySinh.Size = new System.Drawing.Size(250, 23);
            dtpNgaySinh.TabIndex = 3;

            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new System.Drawing.Point(35, 260);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new System.Drawing.Size(53, 15);
            lblGioiTinh.Text = "Giới tính:";

            rbNam.AutoSize = true;
            rbNam.Location = new System.Drawing.Point(180, 257);
            rbNam.Name = "rbNam";
            rbNam.Size = new System.Drawing.Size(51, 19);
            rbNam.Text = "Nam";
            rbNam.Checked = true;
            rbNam.TabIndex = 4;

            rbNu.AutoSize = true;
            rbNu.Location = new System.Drawing.Point(260, 257);
            rbNu.Name = "rbNu";
            rbNu.Size = new System.Drawing.Size(41, 19);
            rbNu.Text = "Nữ";
            rbNu.TabIndex = 5;

            chkDieuKhoan.AutoSize = true;
            chkDieuKhoan.Location = new System.Drawing.Point(180, 300);
            chkDieuKhoan.Name = "chkDieuKhoan";
            chkDieuKhoan.Size = new System.Drawing.Size(219, 19);
            chkDieuKhoan.Text = "Tôi đồng ý với điều khoản dịch vụ";
            chkDieuKhoan.TabIndex = 6;

            btnDangKy.Location = new System.Drawing.Point(180, 345);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new System.Drawing.Size(110, 35);
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.TabIndex = 7;
            btnDangKy.Click += btnDangKy_Click;

            btnLamMoi.Location = new System.Drawing.Point(310, 345);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(120, 35);
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Click += btnLamMoi_Click;

            epCheck.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            epCheck.ContainerControl = this;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 410);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(lblNgaySinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(rbNam);
            Controls.Add(rbNu);
            Controls.Add(chkDieuKhoan);
            Controls.Add(btnDangKy);
            Controls.Add(btnLamMoi);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.1 - Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }


}

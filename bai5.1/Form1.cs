using System;
using System.Windows.Forms;

namespace bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    private void btnDangKy_Click(object sender, EventArgs e)
        {
            epCheck.Clear();

            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                epCheck.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                epCheck.SetError(txtMatKhau, "Mật khẩu không được để trống");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text))
            {
                epCheck.SetError(txtXacNhanMatKhau, "Vui lòng xác nhận mật khẩu");
                hopLe = false;
            }
            else if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                epCheck.SetError(txtXacNhanMatKhau, "Mật khẩu xác nhận không khớp");
                hopLe = false;
            }

            DateTime ngaySinh = dtpNgaySinh.Value;
            int tuoi = DateTime.Today.Year - ngaySinh.Year;

            if (ngaySinh.Date > DateTime.Today ||
                ngaySinh.Date > DateTime.Today.AddYears(-18))
            {
                epCheck.SetError(dtpNgaySinh, "Bạn phải đủ 18 tuổi");
                hopLe = false;
            }

            if (!chkDieuKhoan.Checked)
            {
                epCheck.SetError(chkDieuKhoan, "Bạn phải đồng ý với điều khoản dịch vụ");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra và sửa các thông tin bị lỗi.",
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string gioiTinh = rbNam.Checked ? "Nam" :
                              rbNu.Checked ? "Nữ" : "Chưa chọn";

            MessageBox.Show(
                "Đăng ký tài khoản thành công!\n\n" +
                "Tên đăng nhập: " + txtTenDangNhap.Text +
                "\nNgày sinh: " + dtpNgaySinh.Value.ToString("dd/MM/yyyy") +
                "\nGiới tính: " + gioiTinh,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            dtpNgaySinh.Value = DateTime.Today.AddYears(-18);
            rbNam.Checked = true;
            chkDieuKhoan.Checked = false;
            epCheck.Clear();
            txtTenDangNhap.Focus();
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bai5._2
{
    public partial class Form1 : Form
    {
        private class DichVu
        {
            public string Ten { get; set; }
            public string Loai { get; set; }
            public decimal DonGia { get; set; }


        public DichVu(string ten, string loai, decimal donGia)
            {
                Ten = ten;
                Loai = loai;
                DonGia = donGia;
            }

            public override string ToString()
            {
                return Ten + " - " + DonGia.ToString("N0") + " đ";
            }
        }

        private readonly List<DichVu> danhSachDichVu = new List<DichVu>
    {
        new DichVu("Khám tổng quát", "Khám bệnh", 200000),
        new DichVu("Khám chuyên khoa", "Khám bệnh", 300000),
        new DichVu("Khám sức khỏe", "Khám bệnh", 150000),
        new DichVu("Xét nghiệm máu", "Xét nghiệm", 180000),
        new DichVu("Xét nghiệm nước tiểu", "Xét nghiệm", 100000),
        new DichVu("Xét nghiệm đường huyết", "Xét nghiệm", 120000),
        new DichVu("Chụp X-Quang ngực", "Chụp X-Quang", 250000),
        new DichVu("Chụp X-Quang xương", "Chụp X-Quang", 300000),
        new DichVu("Vắc-xin cúm", "Vắc-xin", 350000),
        new DichVu("Vắc-xin viêm gan B", "Vắc-xin", 500000)
    };

        public Form1()
        {
            InitializeComponent();

            cboCategory.Items.AddRange(new object[]
            {
            "Khám bệnh",
            "Xét nghiệm",
            "Chụp X-Quang",
            "Vắc-xin"
            });

            cboCategory.SelectedIndex = 0;
            CapNhatThanhTien();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();

            if (cboCategory.SelectedItem == null)
                return;

            string loai = cboCategory.SelectedItem?.ToString() ?? "";

            foreach (DichVu dv in danhSachDichVu.Where(x => x.Loai == loai))
            {
                bool daChon = lstSelectedServices.Items
                    .Cast<DichVu>()
                    .Any(x => x.Ten == dv.Ten);

                if (!daChon)
                    lstAvailableServices.Items.Add(dv);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ChonDichVu();
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            ChonDichVu();
        }

        private void ChonDichVu()
        {
            if (lstAvailableServices.SelectedItem == null)
                return;

            DichVu dv = (DichVu)lstAvailableServices.SelectedItem;

            if (!lstSelectedServices.Items.Cast<DichVu>()
                .Any(x => x.Ten == dv.Ten))
            {
                lstSelectedServices.Items.Add(dv);
            }

            lstAvailableServices.Items.Remove(dv);
            CapNhatThanhTien();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.");
                return;
            }

            DichVu dv = (DichVu)lstSelectedServices.SelectedItem;
            lstSelectedServices.Items.Remove(dv);

            if (cboCategory.SelectedItem != null &&
                dv.Loai == cboCategory.SelectedItem.ToString())
            {
                lstAvailableServices.Items.Add(dv);
            }

            CapNhatThanhTien();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            cboCategory_SelectedIndexChanged(this, EventArgs.Empty);
            CapNhatThanhTien();
        }

        private void CapNhatThanhTien()
        {
            decimal tongTien = 0;

            foreach (DichVu dv in lstSelectedServices.Items)
            {
                tongTien += dv.DonGia;
            }

            decimal chietKhau = 0;

            if (tongTien >= 1000000)
                chietKhau = 10;
            else if (tongTien >= 500000)
                chietKhau = 5;

            decimal tienGiam = tongTien * chietKhau / 100;
            decimal thanhTien = tongTien - tienGiam;

            lblTongTien.Text = tongTien.ToString("N0") + " đ";
            lblChietKhau.Text = chietKhau.ToString("0") + "%";
            lblThanhTien.Text = thanhTien.ToString("N0") + " đ";
        }
    }


}

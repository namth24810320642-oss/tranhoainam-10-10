namespace bai5._2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblTongTienText;
        private System.Windows.Forms.Label lblChietKhauText;
        private System.Windows.Forms.Label lblThanhTienText;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblChietKhau;
        private System.Windows.Forms.Label lblThanhTien;


    protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDe = new System.Windows.Forms.Label();
            lblCategory = new System.Windows.Forms.Label();
            lblAvailable = new System.Windows.Forms.Label();
            lblSelected = new System.Windows.Forms.Label();
            cboCategory = new System.Windows.Forms.ComboBox();
            lstAvailableServices = new System.Windows.Forms.ListBox();
            lstSelectedServices = new System.Windows.Forms.ListBox();
            btnSelect = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            btnClearAll = new System.Windows.Forms.Button();
            lblTongTienText = new System.Windows.Forms.Label();
            lblChietKhauText = new System.Windows.Forms.Label();
            lblThanhTienText = new System.Windows.Forms.Label();
            lblTongTien = new System.Windows.Forms.Label();
            lblChietKhau = new System.Windows.Forms.Label();
            lblThanhTien = new System.Windows.Forms.Label();
            SuspendLayout();

            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTieuDe.ForeColor = System.Drawing.Color.DarkBlue;
            lblTieuDe.Location = new System.Drawing.Point(145, 20);
            lblTieuDe.Text = "TÍNH TIỀN DỊCH VỤ";

            lblCategory.AutoSize = true;
            lblCategory.Location = new System.Drawing.Point(30, 75);
            lblCategory.Text = "Loại dịch vụ:";

            cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCategory.Location = new System.Drawing.Point(130, 71);
            cboCategory.Size = new System.Drawing.Size(240, 23);
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;

            lblAvailable.AutoSize = true;
            lblAvailable.Location = new System.Drawing.Point(30, 115);
            lblAvailable.Text = "Dịch vụ có sẵn:";

            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.ItemHeight = 20;
            lstAvailableServices.Location = new System.Drawing.Point(30, 140);
            lstAvailableServices.Size = new System.Drawing.Size(220, 144);
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;

            btnSelect.Location = new System.Drawing.Point(270, 155);
            btnSelect.Size = new System.Drawing.Size(65, 30);
            btnSelect.Text = ">";
            btnSelect.Click += btnSelect_Click;

            btnRemove.Location = new System.Drawing.Point(270, 195);
            btnRemove.Size = new System.Drawing.Size(65, 30);
            btnRemove.Text = "<";
            btnRemove.Click += btnRemove_Click;

            btnClearAll.Location = new System.Drawing.Point(270, 235);
            btnClearAll.Size = new System.Drawing.Size(65, 30);
            btnClearAll.Text = "<<";
            btnClearAll.Click += btnClearAll_Click;

            lblSelected.AutoSize = true;
            lblSelected.Location = new System.Drawing.Point(355, 115);
            lblSelected.Text = "Dịch vụ đã chọn:";

            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.ItemHeight = 20;
            lstSelectedServices.Location = new System.Drawing.Point(355, 140);
            lstSelectedServices.Size = new System.Drawing.Size(220, 144);

            lblTongTienText.AutoSize = true;
            lblTongTienText.Location = new System.Drawing.Point(30, 315);
            lblTongTienText.Text = "Tổng tiền chưa giảm:";

            lblTongTien.AutoSize = true;
            lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTongTien.Location = new System.Drawing.Point(210, 311);
            lblTongTien.Text = "0 đ";

            lblChietKhauText.AutoSize = true;
            lblChietKhauText.Location = new System.Drawing.Point(30, 350);
            lblChietKhauText.Text = "Tỷ lệ chiết khấu:";

            lblChietKhau.AutoSize = true;
            lblChietKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblChietKhau.ForeColor = System.Drawing.Color.DarkGreen;
            lblChietKhau.Location = new System.Drawing.Point(210, 346);
            lblChietKhau.Text = "0%";

            lblThanhTienText.AutoSize = true;
            lblThanhTienText.Location = new System.Drawing.Point(30, 385);
            lblThanhTienText.Text = "Thành tiền thanh toán:";

            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblThanhTien.ForeColor = System.Drawing.Color.DarkRed;
            lblThanhTien.Location = new System.Drawing.Point(210, 380);
            lblThanhTien.Text = "0 đ";

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(610, 440);
            Controls.Add(lblTieuDe);
            Controls.Add(lblCategory);
            Controls.Add(cboCategory);
            Controls.Add(lblAvailable);
            Controls.Add(lstAvailableServices);
            Controls.Add(btnSelect);
            Controls.Add(btnRemove);
            Controls.Add(btnClearAll);
            Controls.Add(lblSelected);
            Controls.Add(lstSelectedServices);
            Controls.Add(lblTongTienText);
            Controls.Add(lblTongTien);
            Controls.Add(lblChietKhauText);
            Controls.Add(lblChietKhau);
            Controls.Add(lblThanhTienText);
            Controls.Add(lblThanhTien);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.2 - Bảng tính tiền dịch vụ";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

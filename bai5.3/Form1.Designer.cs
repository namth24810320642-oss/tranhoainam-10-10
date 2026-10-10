
#nullable enable

namespace bai5._3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.GroupBox grpProduct = null!;
        private System.Windows.Forms.GroupBox grpFunction = null!;
        private System.Windows.Forms.Label lblProductId = null!;
        private System.Windows.Forms.Label lblProductName = null!;
        private System.Windows.Forms.Label lblUnitPrice = null!;
        private System.Windows.Forms.Label lblQuantity = null!;
        private System.Windows.Forms.Label lblCategory = null!;
        private System.Windows.Forms.TextBox txtProductId = null!;
        private System.Windows.Forms.TextBox txtProductName = null!;
        private System.Windows.Forms.TextBox txtUnitPrice = null!;
        private System.Windows.Forms.TextBox txtQuantity = null!;
        private System.Windows.Forms.ComboBox cboCategory = null!;
        private System.Windows.Forms.Button btnAdd = null!;
        private System.Windows.Forms.Button btnUpdate = null!;
        private System.Windows.Forms.Button btnDelete = null!;
        private System.Windows.Forms.Button btnClear = null!;
        private System.Windows.Forms.Button btnSearch = null!;
        private System.Windows.Forms.TextBox txtSearch = null!;
        private System.Windows.Forms.DataGridView dgvProducts = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpProduct = new System.Windows.Forms.GroupBox();
            grpFunction = new System.Windows.Forms.GroupBox();
            lblProductId = new System.Windows.Forms.Label();
            lblProductName = new System.Windows.Forms.Label();
            lblUnitPrice = new System.Windows.Forms.Label();
            lblQuantity = new System.Windows.Forms.Label();
            lblCategory = new System.Windows.Forms.Label();
            txtProductId = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            cboCategory = new System.Windows.Forms.ComboBox();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            dgvProducts = new System.Windows.Forms.DataGridView();

            grpProduct.SuspendLayout();
            grpFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();

            grpProduct.Text = "Thông tin sản phẩm";
            grpProduct.Location = new System.Drawing.Point(20, 20);
            grpProduct.Size = new System.Drawing.Size(400, 260);

            lblProductId.Text = "Mã SP:";
            lblProductId.Location = new System.Drawing.Point(20, 35);
            lblProductId.AutoSize = true;
            txtProductId.Location = new System.Drawing.Point(130, 32);
            txtProductId.Size = new System.Drawing.Size(240, 27);

            lblProductName.Text = "Tên SP:";
            lblProductName.Location = new System.Drawing.Point(20, 80);
            lblProductName.AutoSize = true;
            txtProductName.Location = new System.Drawing.Point(130, 77);
            txtProductName.Size = new System.Drawing.Size(240, 27);

            lblUnitPrice.Text = "Đơn giá:";
            lblUnitPrice.Location = new System.Drawing.Point(20, 125);
            lblUnitPrice.AutoSize = true;
            txtUnitPrice.Location = new System.Drawing.Point(130, 122);
            txtUnitPrice.Size = new System.Drawing.Size(240, 27);

            lblQuantity.Text = "Số lượng:";
            lblQuantity.Location = new System.Drawing.Point(20, 170);
            lblQuantity.AutoSize = true;
            txtQuantity.Location = new System.Drawing.Point(130, 167);
            txtQuantity.Size = new System.Drawing.Size(240, 27);

            lblCategory.Text = "Danh mục:";
            lblCategory.Location = new System.Drawing.Point(20, 215);
            lblCategory.AutoSize = true;
            cboCategory.Location = new System.Drawing.Point(130, 212);
            cboCategory.Size = new System.Drawing.Size(240, 28);
            cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            grpProduct.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblProductId, txtProductId,
                lblProductName, txtProductName,
                lblUnitPrice, txtUnitPrice,
                lblQuantity, txtQuantity,
                lblCategory, cboCategory
            });

            grpFunction.Text = "Chức năng";
            grpFunction.Location = new System.Drawing.Point(440, 20);
            grpFunction.Size = new System.Drawing.Size(420, 260);

            btnAdd.Text = "Thêm";
            btnAdd.Location = new System.Drawing.Point(20, 35);
            btnAdd.Size = new System.Drawing.Size(110, 40);
            btnAdd.Click += BtnAdd_Click;

            btnUpdate.Text = "Sửa";
            btnUpdate.Location = new System.Drawing.Point(155, 35);
            btnUpdate.Size = new System.Drawing.Size(110, 40);
            btnUpdate.Click += BtnUpdate_Click;

            btnDelete.Text = "Xóa";
            btnDelete.Location = new System.Drawing.Point(285, 35);
            btnDelete.Size = new System.Drawing.Size(110, 40);
            btnDelete.Click += BtnDelete_Click;

            btnClear.Text = "Làm mới";
            btnClear.Location = new System.Drawing.Point(20, 90);
            btnClear.Size = new System.Drawing.Size(110, 40);
            btnClear.Click += BtnClear_Click;

            txtSearch.Location = new System.Drawing.Point(20, 165);
            txtSearch.Size = new System.Drawing.Size(245, 27);
            txtSearch.PlaceholderText = "Nhập tên sản phẩm cần tìm";

            btnSearch.Text = "Tìm kiếm";
            btnSearch.Location = new System.Drawing.Point(285, 160);
            btnSearch.Size = new System.Drawing.Size(110, 40);
            btnSearch.Click += BtnSearch_Click;

            grpFunction.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                btnAdd, btnUpdate, btnDelete,
                btnClear, txtSearch, btnSearch
            });

            dgvProducts.Location = new System.Drawing.Point(20, 300);
            dgvProducts.Size = new System.Drawing.Size(840, 300);
            dgvProducts.Anchor = System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left
                | System.Windows.Forms.AnchorStyles.Right;
            dgvProducts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(880, 630);
            Controls.Add(grpProduct);
            Controls.Add(grpFunction);
            Controls.Add(dgvProducts);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.3 - Quản lý danh sách sản phẩm";
            MinimumSize = new System.Drawing.Size(900, 680);

            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            grpFunction.ResumeLayout(false);
            grpFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }
    }
}

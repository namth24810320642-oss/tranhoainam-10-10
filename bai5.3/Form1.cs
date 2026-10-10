
#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bai5._3
{
    public partial class Form1 : Form
    {
        private readonly List<Product> products = new();
        private readonly BindingSource bindingSource = new();
        private Product? selectedProduct;

        public Form1()
        {
            InitializeComponent();

            cboCategory.Items.AddRange(new object[]
            {
                "Điện thoại",
                "Laptop",
                "Phụ kiện",
                "Khác"
            });

            cboCategory.SelectedIndex = 0;

            bindingSource.DataSource = products;
            dgvProducts.DataSource = bindingSource;

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.CellClick += DgvProducts_CellClick;
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string id = txtProductId.Text.Trim();

            if (products.Any(p => p.ProductId.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return;
            }

            Product product = new(
                id,
                txtProductName.Text.Trim(),
                decimal.Parse(txtUnitPrice.Text),
                int.Parse(txtQuantity.Text),
                cboCategory.Text
            );

            products.Add(product);
            RefreshGrid();
            ClearInput();

            MessageBox.Show("Thêm sản phẩm thành công!");
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            if (!ValidateInput())
                return;

            string id = txtProductId.Text.Trim();

            if (products.Any(p =>
                p != selectedProduct &&
                p.ProductId.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return;
            }

            selectedProduct.ProductId = id;
            selectedProduct.ProductName = txtProductName.Text.Trim();
            selectedProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text);
            selectedProduct.Quantity = int.Parse(txtQuantity.Text);
            selectedProduct.Category = cboCategory.Text;

            RefreshGrid();
            ClearInput();

            MessageBox.Show("Cập nhật sản phẩm thành công!");
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                products.Remove(selectedProduct);
                RefreshGrid();
                ClearInput();

                MessageBox.Show("Xóa sản phẩm thành công!");
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            var result = products
                .Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            bindingSource.DataSource = result;
            dgvProducts.DataSource = bindingSource;
        }

        private void DgvProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvProducts.Rows.Count)
                return;

            if (dgvProducts.Rows[e.RowIndex].DataBoundItem is not Product product)
                return;

            selectedProduct = product;

            txtProductId.Text = product.ProductId;
            txtProductName.Text = product.ProductName;
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtQuantity.Text = product.Quantity.ToString();
            cboCategory.Text = product.Category;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                cboCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm!");
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm!");
                return false;
            }

            return true;
        }

        private void RefreshGrid()
        {
            bindingSource.DataSource = products;
            dgvProducts.DataSource = bindingSource;
            bindingSource.ResetBindings(false);
        }

        private void ClearInput()
        {
            selectedProduct = null;

            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();

            if (cboCategory.Items.Count > 0)
                cboCategory.SelectedIndex = 0;

            dgvProducts.ClearSelection();
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            ClearInput();
        }
    }
}

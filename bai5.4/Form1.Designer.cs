namespace bai5._4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null!;

        private System.Windows.Forms.Panel pnlTop = null!;
        private System.Windows.Forms.Label lblView = null!;
        private System.Windows.Forms.ComboBox cboView = null!;
        private System.Windows.Forms.SplitContainer splitContainer1 = null!;
        private System.Windows.Forms.TreeView tvDepartments = null!;
        private System.Windows.Forms.ListView lsvEmployees = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlTop = new System.Windows.Forms.Panel();
            lblView = new System.Windows.Forms.Label();
            cboView = new System.Windows.Forms.ComboBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            tvDepartments = new System.Windows.Forms.TreeView();
            lsvEmployees = new System.Windows.Forms.ListView();

            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();

            // pnlTop
            pnlTop.Controls.Add(lblView);
            pnlTop.Controls.Add(cboView);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Height = 50;
            pnlTop.Padding = new System.Windows.Forms.Padding(10);

            // lblView
            lblView.AutoSize = true;
            lblView.Location = new System.Drawing.Point(15, 17);
            lblView.Name = "lblView";
            lblView.Size = new System.Drawing.Size(110, 20);
            lblView.Text = "Chế độ hiển thị:";

            // cboView
            cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboView.FormattingEnabled = true;
            cboView.Location = new System.Drawing.Point(135, 13);
            cboView.Name = "cboView";
            cboView.Size = new System.Drawing.Size(150, 28);
            cboView.SelectedIndexChanged += CboView_SelectedIndexChanged;

            // splitContainer1
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 50);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 1;

            // splitContainer1.Panel1
            splitContainer1.Panel1.Controls.Add(tvDepartments);

            // splitContainer1.Panel2
            splitContainer1.Panel2.Controls.Add(lsvEmployees);

            // tvDepartments
            tvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            tvDepartments.HideSelection = false;
            tvDepartments.Name = "tvDepartments";
            tvDepartments.AfterSelect += TvDepartments_AfterSelect;

            // lsvEmployees
            lsvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.HideSelection = false;
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = System.Windows.Forms.View.Details;

            lsvEmployees.Columns.Add("Mã NV", 100);
            lsvEmployees.Columns.Add("Họ Tên", 180);
            lsvEmployees.Columns.Add("Chức vụ", 160);
            lsvEmployees.Columns.Add("Ngày vào làm", 130);

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 600);
            Controls.Add(splitContainer1);
            Controls.Add(pnlTop);
            MinimumSize = new System.Drawing.Size(800, 450);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 5.4 - Trình quản lý tập tin dạng chuyên nghiệp";

            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace bai5._4
{
    public partial class Form1 : Form
    {
        private readonly List<Employee> employees = new();

        private ImageList treeImages = new();
        private ImageList smallImages = new();
        private ImageList largeImages = new();

        private class NodeFilter
        {
            public string? Department { get; set; }
            public string? Group { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            InitializeImages();
            CreateEmployees();
            BuildDepartmentTree();

            cboView.Items.AddRange(new object[]
            {
                "Details",
                "SmallIcon",
                "LargeIcon",
                "Tile"
            });

            cboView.SelectedIndex = 0;
        }

        private void InitializeImages()
        {
            treeImages.ImageSize = new Size(16, 16);
            smallImages.ImageSize = new Size(16, 16);
            largeImages.ImageSize = new Size(32, 32);

            treeImages.Images.Add(SystemIcons.Application.ToBitmap());
            treeImages.Images.Add(SystemIcons.WinLogo.ToBitmap());
            treeImages.Images.Add(SystemIcons.Information.ToBitmap());

            smallImages.Images.Add(SystemIcons.Application.ToBitmap());
            smallImages.Images.Add(SystemIcons.Information.ToBitmap());
            smallImages.Images.Add(SystemIcons.Question.ToBitmap());

            largeImages.Images.Add(SystemIcons.Application.ToBitmap());
            largeImages.Images.Add(SystemIcons.Information.ToBitmap());
            largeImages.Images.Add(SystemIcons.Question.ToBitmap());

            tvDepartments.ImageList = treeImages;
            lsvEmployees.SmallImageList = smallImages;
            lsvEmployees.LargeImageList = largeImages;
        }

        private void CreateEmployees()
        {
            employees.AddRange(new List<Employee>
            {
                new Employee
                {
                    EmployeeId = "NV001",
                    FullName = "Nguyễn Văn An",
                    Position = "Trưởng phòng",
                    StartDate = new DateTime(2020, 3, 15),
                    Department = "Công nghệ thông tin",
                    Group = "Phát triển phần mềm",
                    ImageIndex = 0
                },
                new Employee
                {
                    EmployeeId = "NV002",
                    FullName = "Trần Thị Bình",
                    Position = "Lập trình viên",
                    StartDate = new DateTime(2022, 6, 10),
                    Department = "Công nghệ thông tin",
                    Group = "Phát triển phần mềm",
                    ImageIndex = 1
                },
                new Employee
                {
                    EmployeeId = "NV003",
                    FullName = "Lê Minh Cường",
                    Position = "Kiểm thử viên",
                    StartDate = new DateTime(2023, 1, 20),
                    Department = "Công nghệ thông tin",
                    Group = "Kiểm thử",
                    ImageIndex = 2
                },
                new Employee
                {
                    EmployeeId = "NV004",
                    FullName = "Phạm Thu Hà",
                    Position = "Kế toán trưởng",
                    StartDate = new DateTime(2019, 8, 5),
                    Department = "Kế toán",
                    Group = "Kế toán tổng hợp",
                    ImageIndex = 0
                },
                new Employee
                {
                    EmployeeId = "NV005",
                    FullName = "Đỗ Quốc Huy",
                    Position = "Nhân viên kế toán",
                    StartDate = new DateTime(2021, 11, 12),
                    Department = "Kế toán",
                    Group = "Kế toán tổng hợp",
                    ImageIndex = 1
                },
                new Employee
                {
                    EmployeeId = "NV006",
                    FullName = "Hoàng Ngọc Lan",
                    Position = "Nhân viên tuyển dụng",
                    StartDate = new DateTime(2022, 4, 1),
                    Department = "Nhân sự",
                    Group = "Tuyển dụng",
                    ImageIndex = 2
                },
                new Employee
                {
                    EmployeeId = "NV007",
                    FullName = "Vũ Đức Long",
                    Position = "Chuyên viên nhân sự",
                    StartDate = new DateTime(2024, 2, 19),
                    Department = "Nhân sự",
                    Group = "Quản lý nhân sự",
                    ImageIndex = 1
                }
            });
        }

        private void BuildDepartmentTree()
        {
            tvDepartments.Nodes.Clear();

            TreeNode root = new TreeNode("Công ty")
            {
                ImageIndex = 0,
                SelectedImageIndex = 0,
                Tag = new NodeFilter()
            };

            AddDepartment(root, "Công nghệ thông tin",
                new[] { "Phát triển phần mềm", "Kiểm thử" });

            AddDepartment(root, "Kế toán",
                new[] { "Kế toán tổng hợp" });

            AddDepartment(root, "Nhân sự",
                new[] { "Tuyển dụng", "Quản lý nhân sự" });

            tvDepartments.Nodes.Add(root);
            root.Expand();

            tvDepartments.SelectedNode = root;
        }

        private void AddDepartment(
            TreeNode root,
            string department,
            string[] groups)
        {
            TreeNode departmentNode = new TreeNode(department)
            {
                ImageIndex = 1,
                SelectedImageIndex = 1,
                Tag = new NodeFilter
                {
                    Department = department
                }
            };

            foreach (string group in groups)
            {
                departmentNode.Nodes.Add(new TreeNode(group)
                {
                    ImageIndex = 2,
                    SelectedImageIndex = 2,
                    Tag = new NodeFilter
                    {
                        Department = department,
                        Group = group
                    }
                });
            }

            root.Nodes.Add(departmentNode);
        }

        private void TvDepartments_AfterSelect(
            object? sender,
            TreeViewEventArgs e)
        {
            if (e.Node?.Tag is not NodeFilter filter)
                return;

            IEnumerable<Employee> result = employees;

            if (filter.Department != null)
            {
                result = result.Where(x =>
                    x.Department == filter.Department);
            }

            if (filter.Group != null)
            {
                result = result.Where(x =>
                    x.Group == filter.Group);
            }

            DisplayEmployees(result);
        }

        private void DisplayEmployees(IEnumerable<Employee> data)
        {
            lsvEmployees.BeginUpdate();
            lsvEmployees.Items.Clear();

            foreach (Employee employee in data)
            {
                ListViewItem item = new ListViewItem(
                    employee.EmployeeId,
                    employee.ImageIndex);

                item.SubItems.Add(employee.FullName);
                item.SubItems.Add(employee.Position);
                item.SubItems.Add(
                    employee.StartDate.ToString("dd/MM/yyyy"));

                item.Tag = employee;
                lsvEmployees.Items.Add(item);
            }

            lsvEmployees.EndUpdate();
        }

        private void CboView_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            switch (cboView.SelectedItem?.ToString())
            {
                case "Details":
                    lsvEmployees.View = View.Details;
                    break;

                case "SmallIcon":
                    lsvEmployees.View = View.SmallIcon;
                    break;

                case "LargeIcon":
                    lsvEmployees.View = View.LargeIcon;
                    break;

                case "Tile":
                    lsvEmployees.View = View.Tile;
                    break;
            }
        }
    }
}
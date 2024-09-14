using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Krypton.Toolkit;
using BLL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class AddEmployee : KryptonForm
    {
        AddEmployeeBLL employeeBLL = new AddEmployeeBLL();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {            
            dgvEmployeeList.DataSource= employeeBLL.LoadEmployeeList();
            //cbxDepartment.Items.Clear();

            cbxDepartment.DataSource = employeeBLL.LoadDepartment();
            cbxDepartment.DisplayMember = "...";
            cbxDepartment.ValueMember = "DepartmentName";
        }



        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxAccountName.ReadOnly = true;
            int i;
            i = dgvEmployeeList.CurrentRow.Index;
            tbxAccountName.Text = dgvEmployeeList.Rows[i].Cells[0].Value.ToString();
            cbxPosition.Text = dgvEmployeeList.Rows[i].Cells[1].Value.ToString();
            cbxDepartment.Text = dgvEmployeeList.Rows[i].Cells[2].Value.ToString();
            tbxSalary.Text = dgvEmployeeList.Rows[i].Cells[3].Value.ToString();
            tbxEmployeeName.Text= dgvEmployeeList.Rows[i].Cells[4].Value.ToString();
            tbxAddress.Text= dgvEmployeeList.Rows[i].Cells[5].Value.ToString();
            tbxEmail.Text= dgvEmployeeList.Rows[i].Cells[6].Value.ToString();
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account acc= new Account();
            acc.AccountName=tbxAccountName.Text;
            acc.Address=tbxAddress.Text;
            acc.Email=tbxEmail.Text;
            acc.DisplayName = tbxEmployeeName.Text;
            
            string x=cbxDepartment.Text;
            acc.idDepartment = employeeBLL.getDepartmentID(x);

            if (cbxPosition.Text == "Giám Đốc")
            {
                acc.idAccess = 1;
            }
            else
            if (cbxPosition.Text == "Quản Lý")
            {
                acc.idAccess = 2;
            }
            else
            if (cbxPosition.Text == "Nhân Viên")
            {
                acc.idAccess = 3;
            }
            else acc.idAccess = 0;
            acc.Salary = float.Parse(tbxSalary.Text);
            acc.Password = "123";
            string strTest = "";
            strTest=employeeBLL.AddNhanVien(acc);
            if(strTest== "Vui lòng điền thông tin bắt buộc !")
            {
                MessageBox.Show("Vui lòng không để trống thông tin");
                return;
            }
            MessageBox.Show("Thêm nhân viên thành công","Chúc mừng",MessageBoxButtons.OK);
            dgvEmployeeList.DataSource = employeeBLL.LoadEmployeeList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.AccountName = tbxAccountName.Text;
            string strTest = "";
            strTest = employeeBLL.DeleteNhanVien(acc);
            if (strTest == "Vui lòng chọn nhân viên muốn xóa")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thành công", "Hoàn thành", MessageBoxButtons.OK);
                dgvEmployeeList.DataSource = employeeBLL.LoadEmployeeList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.AccountName = tbxAccountName.Text;
            acc.Address = tbxAddress.Text;
            acc.Email = tbxEmail.Text;
            acc.DisplayName = tbxEmployeeName.Text;

            string x = cbxDepartment.Text;
            acc.idDepartment = employeeBLL.getDepartmentID(x);

            if (cbxPosition.Text == "Giám Đốc")
            {
                acc.idAccess = 1;
            }
            else
            if (cbxPosition.Text == "Quản Lý")
            {
                acc.idAccess = 2;
            }
            else
            if (cbxPosition.Text == "Nhân Viên")
            {
                acc.idAccess = 3;
            }
            else acc.idAccess = 0;
            acc.Salary = float.Parse(tbxSalary.Text);
            acc.Password = "123";
            string strTest = "";
            strTest = employeeBLL.UpdateNhanVien(acc);
            if (strTest == "Vui lòng điền thông tin bắt buộc !")
            {
                MessageBox.Show("Vui lòng không để trống thông tin");
                return;
            }
            MessageBox.Show("Sửa nhân viên thành công", "Chúc mừng", MessageBoxButtons.OK);
            dgvEmployeeList.DataSource = employeeBLL.LoadEmployeeList();
        }
    }
}

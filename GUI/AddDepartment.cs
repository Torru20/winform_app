using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using BLL;
using DTO;
namespace GUI
{
    public partial class AddDepartment : KryptonForm
    {
        
        AddDepartmentBLL addD=new AddDepartmentBLL();
        public AddDepartment()
        {
            InitializeComponent();

        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            dgvDepartment.DataSource = addD.LoadDepartmentList();
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDepartment.CurrentRow.Index;
            tbxIdDepartment.Text = dgvDepartment.Rows[i].Cells[0].Value.ToString();
            tbxDepartmentName.Text= dgvDepartment.Rows[i].Cells[1].Value.ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.idDepartment = int.Parse(tbxIdDepartment.Text);
            department.DepartmentName = tbxDepartmentName.Text;
            string strTest = "";
            strTest= addD.AddNewDepartment(department);
            if (strTest == "Vui lòng điền đủ thông tin !")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin !");
                return;
            }
            MessageBox.Show("Thêm phòng ban thành công", "Chúc mừng", MessageBoxButtons.OK);
            dgvDepartment.DataSource = addD.LoadDepartmentList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Department dp= new Department();
            dp.idDepartment = int.Parse(tbxIdDepartment.Text);
            dp.DepartmentName = tbxDepartmentName.Text;
            string strTest = "";
            strTest = addD.UpdateDepartment(dp);
            if (strTest == "Vui lòng điền đủ thông tin !")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin !");
                return;
            }
            MessageBox.Show("Cập nhật phòng ban thành công", "Chúc mừng", MessageBoxButtons.OK);
            dgvDepartment.DataSource = addD.LoadDepartmentList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Department dp = new Department();
            dp.idDepartment = int.Parse(tbxIdDepartment.Text);
            string strTest = "";
            strTest = addD.DeleteDepartment(dp);
            if (strTest == "Vui lòng điền đủ thông tin !")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin !","Thông báo",MessageBoxButtons.OK);
                return;
            }
            else if(strTest== "Không thể xóa phòng ban do còn nhân viên")
            {
                MessageBox.Show("Không thể xóa phòng ban do còn nhân viên","Thông báo", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Xóa phòng ban thành công", "Hoàn thành", MessageBoxButtons.OK);
            dgvDepartment.DataSource = addD.LoadDepartmentList();
        }
         
    }
}

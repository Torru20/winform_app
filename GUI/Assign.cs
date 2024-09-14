using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Krypton.Toolkit;
namespace GUI
{
    public partial class Assign : KryptonForm
    {
        AssignBLL assBLL =  new AssignBLL();
        ViewTaskBLL view = new ViewTaskBLL();
        private string chucvu;
        private string AccName;
        private string _trangThai;
        public Assign()
        {
            InitializeComponent();
            LoadTask();
        }
        public Assign(string x, string accName)
        {
            InitializeComponent();
            chucvu = x;
            LoadTask();
            tbxIDTask.Enabled = false;
            if (chucvu == "Nhân Viên")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                //btnUpdate.Enabled = false;
                tbxTaskName.Enabled = false;
                cbxAccountDo.Enabled = false;
                label1.Text = "Cập nhật nhiệm vụ";
            }
            if (chucvu == "Quản Lý")
            {
                btnDelete.Enabled = false;
            }
            AccName = accName;
        }
        public void LoadTask()
        {
            dgvTaskList.DataSource = view.LoadListTask();
            cbxAccountDo.DataSource = assBLL.LoadAccountNameCb();
            cbxAccountDo.DisplayMember = "Name";
            cbxAccountDo.ValueMember = "AccountName";
            return;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            fTask t = new fTask();
            t.TaskName=tbxTaskName.Text;
            t.AccountName=cbxAccountDo.Text;
            t.TaskTimeIn = DateTime.Now;
            t.idStatus = 1;
            string test = "";
            test = assBLL.AddNewTask(t);
            switch (test)
            {
                case "Vui lòng nhập tên nhiệm vụ !":
                    MessageBox.Show("Vui lòng nhập tên nhiệm vụ !", "Thông báo", MessageBoxButtons.OK);
                    return;
                case "vui lòng nhập tên người thực hiện !":
                    MessageBox.Show("Vui lòng nhập tên người thực hiện !", "Thông báo", MessageBoxButtons.OK);
                    return;
            }
            //cbxAccountDo.DataSource = view.LoadListTask();
            MessageBox.Show("Thêm nhiệm vụ mới thành công !", "Thông báo", MessageBoxButtons.OK);
            dgvTaskList.DataSource = view.LoadListTask();
        }

        private void dgvTaskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbxTaskName.ReadOnly = true;
            int i;
            i = dgvTaskList.CurrentRow.Index;
            tbxTaskName.Text = dgvTaskList.Rows[i].Cells[1].Value.ToString();
            cbxAccountDo.Text= dgvTaskList.Rows[i].Cells[4].Value.ToString();
            tbxIDTask.Text= dgvTaskList.Rows[i].Cells[0].Value.ToString();
            cbxStatus.Text= dgvTaskList.Rows[i].Cells[5].Value.ToString();
            _trangThai = cbxStatus.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            fTask t = new fTask();
            t.idTask = int.Parse(tbxIDTask.Text);
            string test = "";
            test = assBLL.DeleteTask(t);
            switch (test)
            {
                case "Vui lòng nhập tên nhiệm vụ !":
                    MessageBox.Show("Vui lòng nhập tên nhiệm vụ !", "Thông báo", MessageBoxButtons.OK);
                    return;
                case "vui lòng nhập tên người thực hiện !":
                    MessageBox.Show("Vui lòng nhập tên người thực hiện !", "Thông báo", MessageBoxButtons.OK);
                    return;
            }
            //cbxAccountDo.DataSource = view.LoadListTask();
            MessageBox.Show("Xóa nhiệm vụ thành công !", "Thông báo", MessageBoxButtons.OK);
            dgvTaskList.DataSource = view.LoadListTask();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(AccName!=cbxAccountDo.Text && chucvu== "Nhân Viên")
            {
                MessageBox.Show("Không thể cập nhật nhiệm vụ của người khác", "thông báo", MessageBoxButtons.OK);
                return;
            }
            if(_trangThai== "Hoàn thành")
            {
                MessageBox.Show("Nhiệm vụ đã hoàn thành không thể cập nhật lại !", "thông báo", MessageBoxButtons.OK);
                return;
            }
            fTask t = new fTask();
            t.idTask = int.Parse(tbxIDTask.Text);
            t.AccountName=cbxAccountDo.Text;
            t.TaskName=tbxTaskName.Text;
            t.TaskTimeOut = DateTime.MinValue;
            if (cbxStatus.Text== "Mới giao")
            {
                t.idStatus = 1;
            }
            else if(cbxStatus.Text== "Đang thực hiện")
            {
                t.idStatus = 2;
            }
            else if(cbxStatus.Text== "Hoàn thành")
            {
                t.idStatus = 3;
                t.TaskTimeOut = DateTime.Now;
            }
            string test = "";
            test = assBLL.UpdateTask(t);
            switch (test)
            {
                case "Vui lòng nhập tên nhiệm vụ !":
                    MessageBox.Show("Vui lòng nhập tên nhiệm vụ !", "Thông báo", MessageBoxButtons.OK);
                    return;
                case "vui lòng nhập tên người thực hiện !":
                    MessageBox.Show("Vui lòng nhập tên người thực hiện !", "Thông báo", MessageBoxButtons.OK);
                    return;
            }
            //cbxAccountDo.DataSource = view.LoadListTask();
            MessageBox.Show("Cập nhật nhiệm vụ thành công !", "Thông báo", MessageBoxButtons.OK);
            dgvTaskList.DataSource = view.LoadListTask();
        }
    }
}

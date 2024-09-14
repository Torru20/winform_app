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
using Krypton.Toolkit;
namespace GUI
{
    public partial class Main_Admin : KryptonForm
    {
        private string _message;
        private string chucvu = "Giám Đốc";
        Main_AdminBLL main_AdminBLL = new Main_AdminBLL();
        public Main_Admin()
        {
            InitializeComponent();
        }
        public Main_Admin(string m)
        {
            InitializeComponent();
            _message = m;
            //MessageBox.Show(_message);
        }

        //Tai khoan
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_Info account = new Account_Info(_message);
            account.ShowDialog();
            this.Show();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //ql nhan vien
        private void thêmCậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            this.Show();
        }

        
        //ql phong ban
        private void thêmCậpNhậtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.ShowDialog();
            this.Show();
        }
        //Chuc nang
        private void nhiệmVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTask viewTask = new ViewTask(_message,chucvu);
            viewTask.ShowDialog();
            this.Show();
        }
        private void tínhLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary childform = new Salary();
            childform.ShowDialog();
            this.Show();
        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assign childform = new Assign(chucvu,_message);
            childform.ShowDialog();
            this.Show();
        }
        //nut ben ngoai
        private void btnFind_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker.Value.Date;
            dgv.DataSource = main_AdminBLL.LoadAttendanceByDate(dateTime);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = main_AdminBLL.LoadAttendance();
        }
        //load du lieu
        private void Main_Admin_Load(object sender, EventArgs e)
        {
            dgv.DataSource = main_AdminBLL.LoadAttendance();
        }
    }
}

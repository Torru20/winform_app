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
using DTO;
using BLL;
using System.Security.Cryptography;

namespace GUI
{
    public partial class Login : KryptonForm
    {
        Account acc=new Account();
        AccountBLL accountBLL = new AccountBLL();
        Account_InfoBLL Account_InfoBLL = new Account_InfoBLL();
        public Login()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //string n=Account_InfoBLL.getAccount(tbxAccountName.Text);
            acc.AccountName=tbxAccountName.Text;
            acc.Password=tbxPassword.Text;
            if(cbxChucVu.Text=="Giám Đốc")
            {
                acc.idAccess = 1;
            }else
            if (cbxChucVu.Text == "Quản Lý")
            {
                acc.idAccess = 2;
            }else
            if (cbxChucVu.Text == "Nhân Viên")
            {
                acc.idAccess = 3;
            }else acc.idAccess = 0;

            string getuser = accountBLL.CheckLogin(acc);
            switch(getuser)
            {
                case "Vui lòng không để trống tên tài khoản":
                    MessageBox.Show("Vui lòng không để trống tên tài khoản");
                    return;
                case "Vui lòng không để trống mật khẩu":
                    MessageBox.Show("Vui lòng không để trống mật khẩu");
                    return;
                case "Vui lòng không để trống chức vụ":
                    MessageBox.Show("Vui lòng không để trống chức vụ");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
            }
            
            MessageBox.Show("Đăng nhập thành công", "OK", MessageBoxButtons.OK);

            if (cbxChucVu.Text == "Giám Đốc")
            {
                this.Hide();
                Main_Admin main_Admin = new Main_Admin(tbxAccountName.Text);
                //Main_Admin main = new Main_Admin();
                main_Admin.ShowDialog();
                this.Show();
            }
            else
            if (cbxChucVu.Text == "Nhân Viên" || cbxChucVu.Text == "Quản Lý")
            {
                this.Hide();
                Main_Employee main_Employee = new Main_Employee(tbxAccountName.Text, cbxChucVu.Text);
                main_Employee.ShowDialog();
                this.Show();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            GroupInfo child = new GroupInfo();
            this.Hide();
            child.ShowDialog();

        }
    }
}

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
    public partial class Account_Info : KryptonForm
    {
        Account_InfoBLL AccInfo = new Account_InfoBLL();
        private string _message;
        public Account_Info()
        {
            InitializeComponent();
            LoadAccountInfo();
        }

        public Account_Info(string Message)
        {
            InitializeComponent();
            _message = Message;
            //MessageBox.Show(_message);
            tbxAccountName.Text = _message;
            LoadAccountInfo();
        }
        public void LoadAccountInfo()
        {
            
            DataTable dataTable = new DataTable();
            dataTable=AccInfo.LoadAccountInfo(_message);
            //dgv.DataSource = dataTable;
            tbxAccountName.Text = dataTable.Rows[0]["AccountName"].ToString();
            tbxEmployeeName.Text= dataTable.Rows[0]["DisplayName"].ToString();
            tbxPosition.Text= dataTable.Rows[0]["AccessName"].ToString();
            tbxAddress.Text= dataTable.Rows[0]["Address"].ToString();
            tbxEmail.Text= dataTable.Rows[0]["Email"].ToString();

        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.AccountName = _message;
            acc.Address = tbxAddress.Text;
            acc.Email = tbxEmail.Text;
            string strTest = "";
            strTest = AccInfo.UpdateAccountInfo(acc);
            LoadAccountInfo();
            MessageBox.Show("Sửa thông tin thành công", "Chúc mừng", MessageBoxButtons.OK);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát trang thông tin cá nhân?", "Thoát ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.AccountName = _message;
            acc.Password = tbxPassWord.Text;
            string newPass = tbxNewPassWord.Text;
            string newPass1 = tbxNewPassWord1.Text;
            
            string strTest = "";
            strTest = AccInfo.UpdateAccountPassword(acc,newPass,newPass1);
            switch (strTest)
            {
                case "Mật khẩu mới nhập lại chưa trùng khớp !":
                    MessageBox.Show("Mật khẩu mới nhập lại chưa trùng khớp !");
                    return;
                case "Mật khẩu mới trùng với mật khẩu cũ !":
                    MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ !");
                    return;
                case "Mật khẩu không chính xác":
                    MessageBox.Show("Mật khẩu không chính xác");
                    return;
            }
            LoadAccountInfo();
            MessageBox.Show("Sửa mật khẩu thành công", "Chúc mừng", MessageBoxButtons.OK);
        }
    }
}

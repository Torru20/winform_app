using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Krypton.Toolkit;

namespace GUI
{
    public partial class Salary : KryptonForm
    {
        public string SendMailTo { get; set; }
        public string SendMailSubject { get; set; }
        public string SendMailBody { get; set; }


        SalaryBLL slBLL = new SalaryBLL();
        public Salary()
        {
            InitializeComponent();
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            int monthChose=int.Parse(cbxMonth.Text);
            if (monthChose == 0)
            {
                MessageBox.Show("Chưa chọn tháng để tính lương", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            dgvSalary.DataSource= slBLL.LoadSalaryList(monthChose);
        }
        
        private void NutGui_Click(object sender, EventArgs e)
        {
             

        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            
            int monthChose = DateTime.Now.Month - 1;
            dgvSalary.DataSource = slBLL.LoadSalaryList(monthChose);
            int check=DateTime.Now.Day;
            if (check != 5)
            {
                MessageBox.Show("Chưa đến ngày gửi bảng lương","Thông báo",MessageBoxButtons.OK);
                return;
            }
            String SendMailFrom = "kitkitty020202@gmail.com";
            DataTable dt = slBLL.LoadSalaryList(monthChose);
            
         
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var si = dt.Rows[i];
                string val = si.ItemArray[4].ToString();
                SendMailTo = val;
                SendMailSubject = "Lương tháng " + (DateTime.Now.Month-1).ToString();
                SendMailBody = "Tổng lương: " + si.ItemArray[3].ToString();
                if (SendMailTo == ""||SendMailTo==null)
                {
                    //MessageBox.Show("Vui lòng nhập người gửi");
                    continue;
                }
                else
                {
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    MailMessage email = new MailMessage();
                    // START
                    email.From = new MailAddress(SendMailFrom);
                    email.To.Add(SendMailTo);
                    email.CC.Add(SendMailFrom);
                    email.Subject = SendMailSubject;
                    email.Body = SendMailBody;
                    //END
                    SmtpServer.Timeout = 50000;
                    SmtpServer.EnableSsl = true;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new NetworkCredential(SendMailFrom, "cudm qmrb xcbs xcpe");
                    SmtpServer.Send(email);
                    
                }
            }
            MessageBox.Show("Gửi Email thành công", "Thông báo", MessageBoxButtons.OK);
        }
    }
}

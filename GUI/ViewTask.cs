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
    public partial class ViewTask : KryptonForm
    {
        ViewTaskBLL view=new ViewTaskBLL();
        DataTable tableAll=new DataTable();
        private string ten = "";
        private string chucvu = "";
        public ViewTask()
        {
            InitializeComponent();

        }
        public ViewTask(string a, string b)
        {
            InitializeComponent();
            ten=a; chucvu=b;


        }
        private void ViewTask_Load(object sender, EventArgs e)
        {
            dgvTaskView.DataSource = view.LoadListTask();
            tableAll= view.LoadListTask();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvTaskView.DataSource = view.LoadListTask();
            view.LoadListTask();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date=dtpk.Value.Date;
            string st = cbxStatus.Text;
            dgvTaskView.DataSource = view.LoadListTaskbyInfo(date,st);
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assign f=new Assign(chucvu,ten);
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

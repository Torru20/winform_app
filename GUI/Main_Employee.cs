using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Krypton.Toolkit;
namespace GUI
{
    public partial class Main_Employee : KryptonForm
    {
        Main_EmployeeBLL mainEBLL=new Main_EmployeeBLL();
        private string _message;
        private string chucvu;
        #region Peoperties
        private List<List<Button>> matrix;
        public bool check = false;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public Main_Employee()
        {
            InitializeComponent();
            LoadMatrix();
        }
        public Main_Employee(string x,string y)
        {
            InitializeComponent();
            _message = x;
            chucvu = y;
            LoadMatrix();  
        }
        //Load du lieu cho calendar
        public DataTable LoadDataAttendanceByAccName(string k)
        {
            DataTable dt = new DataTable();
            dt = mainEBLL.LoadDataAttendanceByAccName(k);
            return dt;
        }
        /*nut nhan*/
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
        //Chuc nang
        private void nhiệmVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTask viewTask = new ViewTask(_message, chucvu);
            viewTask.ShowDialog();
            this.Show();
        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assign assign = new Assign(chucvu,_message);
            assign.ShowDialog();
            this.Show();
        }



        //matrix diem danh

        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);

                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }

            SetDefaultDate();
            AddNumberIntoMatrixByDate(dtpkDate.Value);
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }

        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            DataTable dt = LoadDataAttendanceByAccName(_message);
            //DateTime dt = comboBox1.Items[1];
            int line = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                bool f = false;
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                for(int h = 0; h < dt.Rows.Count; h++)
                {
                    var si = dt.Rows[h];
                    string val = si.ItemArray[0].ToString();
                    if (useDate.ToString() == val)
                    {
                        btn.BackColor = Color.LightGreen;
                        f = true;
                        break;
                    }
                }
                
                if (isEqualDate(useDate, DateTime.Now) && f == false)
                {
                    btn.BackColor = Color.Yellow;
                }
                else
                if (isEqualDate(useDate, date)&&f==false)
                {
                    btn.BackColor = Color.Aqua;
                }
                else if (isEqualDate(useDate, DateTime.Now) && f == true)
                {
                    btn.BackColor = Color.LightGreen;
                }
                if (column >= 6)
                    line++;

                f = false;
                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.AliceBlue;
                }
            }
        }

        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
            //LoadMatrix();
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
            //LoadMatrix();
        }

        private void btnToDay_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
            //LoadMatrix();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            DateTime diemdanh= DateTime.Now.Date;
            string test = "";
            DataTable dt = LoadDataAttendanceByAccName(_message);
            for (int h = 0; h < dt.Rows.Count; h++)
            {
                var si = dt.Rows[h];
                string val = si.ItemArray[0].ToString();
                if (DateTime.Now.Date.ToString() == val)
                {
                    test = "Bạn đã điểm danh";
                    break;
                }
            }
            if (test == "")
            {
                test = mainEBLL.AttendanceByDate(_message, diemdanh);
                //LoadMatrix();
                AddNumberIntoMatrixByDate(dtpkDate.Value);
                MessageBox.Show("Điểm danh thành công", "Thông báo", MessageBoxButtons.OK);
            }
            if(test == "Bạn đã điểm danh")
            {
                MessageBox.Show("Bạn đã điểm danh", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupInfo child= new GroupInfo();
            this.Hide();
            child.ShowDialog();
            
            this.Show();
        }

        //diem danh
    }
}

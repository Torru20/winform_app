using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Net.NetworkInformation;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            return con;
        }
    }
    public class Database
    {
        public static string CheckLoginDTO(Account acc)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();

            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_login");
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", acc.AccountName);
            cmd.Parameters.AddWithValue("@password", acc.Password);
            //phan quyen
            cmd.Parameters.AddWithValue("@access", acc.idAccess);
            cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    user = dr.GetString(0);
                    return user;
                }
                dr.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác";
            }

            return user;
        }  

        public static DataTable LoadEmployeeListDTO()
        {
            /*DataSet ds = new DataSet();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_loademployeelist");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adt= new SqlDataAdapter();
            adt.SelectCommand = cmd;
            adt.Fill(ds);

            conn.Close();
            */
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            
                SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            //cmd = new SqlCommand("proc_DepartmentList", conn);
            cmd = new SqlCommand("proc_loademployeelist",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);
            //dataGridView1.DataSource = dt;
            conn.Close();
            

            return dt;
        }
        public static DataTable LoadDepartmentCB()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = new SqlCommand("proc_DepartmentList", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            conn.Close();
            return dt;
        }
        public static int getDepartmentIDDTO(string x)
        {
            
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = SqlConnectionData.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_getDepartmentID",conn);
            
            cmd.Parameters.AddWithValue("@departmentname", x);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            //int help = int.Parse(ds.Tables[0].Rows[0]["Age"].ToString());
            //int i = int.Parse(ds.Tables[0].Rows[0]["idDepartment"].ToString());
            int help = 0;
            if (dt.Rows.Count > 0)
                int.TryParse(dt.Rows[0]["idDepartment"].ToString(), out help);
            return help;
        }
        public static string AddNhanVienDTO(Account acc)
        {
            string user = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd=conn.CreateCommand();
            cmd = new SqlCommand("proc_AddNewEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accountname", acc.AccountName);
            cmd.Parameters.AddWithValue("@password", acc.Password);
            cmd.Parameters.AddWithValue("@displayname", acc.DisplayName);
            cmd.Parameters.AddWithValue("@idaccess", acc.idAccess);
            cmd.Parameters.AddWithValue("@iddepartment", acc.idDepartment);
            cmd.Parameters.AddWithValue("@salary", acc.Salary);
            cmd.Parameters.AddWithValue("@address", acc.Address);
            cmd.Parameters.AddWithValue("@email", acc.Email);
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }

        public static string DeleteNhanVienDTO(Account acc)
        {
            string user = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd = new SqlCommand("proc_deleteEmployee", conn);
            cmd.Parameters.AddWithValue("@accountname", acc.AccountName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }
        public static string UpdateNhanVienDTO(Account acc)
        {
            string user = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd = new SqlCommand("proc_updateEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accountname", acc.AccountName);
            cmd.Parameters.AddWithValue("@password", acc.Password);
            cmd.Parameters.AddWithValue("@displayname", acc.DisplayName);
            cmd.Parameters.AddWithValue("@idaccess", acc.idAccess);
            cmd.Parameters.AddWithValue("@iddepartment", acc.idDepartment);
            cmd.Parameters.AddWithValue("@salary", acc.Salary);
            cmd.Parameters.AddWithValue("@address", acc.Address);
            cmd.Parameters.AddWithValue("@email", acc.Email);
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }

        //AddDepartment
        public static DataTable LoadDepartmentListDTO()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = new SqlCommand("proc_loadDepartmentList", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            conn.Close();
            return dt;
        }

        public static string AddNewDepartmentDTO(Department dp)
        {
            string user = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd = new SqlCommand("proc_AddNewDepartment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iddepartment", dp.idDepartment);
            cmd.Parameters.AddWithValue("@departmentname", dp.DepartmentName);
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }
        public static string UpdateDepartmentDTO(Department dp)
        {
            string user = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd = new SqlCommand("proc_UpdateDepartment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@iddepartment", dp.idDepartment);
            cmd.Parameters.AddWithValue("@departmentname", dp.DepartmentName);
            cmd.ExecuteNonQuery();
            conn.Close();
            return user;
        }
        public static string DeleteDepartmentDTO(Department dp)
        {
            string user = null;



            //check nhan vien
            SqlCommand cmd1 = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlConnection conn1 = SqlConnectionData.Connect();
            conn1.Open();
            cmd1 = new SqlCommand("proc_CheckAccountDepartment", conn1);
            cmd1.Parameters.AddWithValue("@iddepartment", dp.idDepartment);
            cmd1.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd1;
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            conn1.Close();
            var si = dt.Rows[0];
            string val = si.ItemArray[0].ToString();
            if (val!="0")
            {
                user = "Không thể xóa phòng ban do còn nhân viên";
                return user;
            }
            //delete
            else
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection conn = SqlConnectionData.Connect();
                conn.Open();
                cmd = conn.CreateCommand();
                cmd = new SqlCommand("proc_DeleteDepartment", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddepartment", dp.idDepartment);
                cmd.ExecuteNonQuery();
                conn.Close();
                return user;
            }
            
        }
        //Account_info
        public static DataTable LoadAccountInfoDTO(string x)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = SqlConnectionData.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_LoadAccountInfo", conn);

            cmd.Parameters.AddWithValue("@accountname", x);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            
            return dt;
        }
        public static string UpdateAccountInfoDTO(Account acc)
        {
            string info="";
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_UpdateAccountInfo", conn);
            cmd.Parameters.AddWithValue("@accountname", acc.AccountName);
            cmd.Parameters.AddWithValue("@address", acc.Address);
            cmd.Parameters.AddWithValue("@email", acc.Email);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            conn.Close();
            return info;
        }
        public static string UpdateAccountPasswordDTO(Account acc,string a)
        {
            string info="";
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_CheckOldPassword");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accountname", acc.AccountName);
            cmd.Parameters.AddWithValue("@password", acc.Password);
            //cmd.Parameters.AddWithValue("@newpassword", a);
            cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                
                dr.Close();
                SqlCommand cmd1 = new SqlCommand("proc_UpdateAccountPassword", conn);
                cmd1.Parameters.AddWithValue("@accountname", acc.AccountName);
                cmd1.Parameters.AddWithValue("@password", acc.Password);
                cmd1.Parameters.AddWithValue("@newpassword", a);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                return "Mật khẩu không chính xác";
            }

            return info;
        }

        //main admin
        public static DataTable LoadAttendanceDTO()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = SqlConnectionData.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_LoadAttendance", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable LoadAttendanceByDateDTO(DateTime date)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = SqlConnectionData.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_LoadAttendanceByDate", conn);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        //viewTask

        public static DataTable LoadListTaskDTO()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = SqlConnectionData.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_ViewTask", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        
        public static DataTable LoadListTaskbyInfoDTO(DateTime date)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = SqlConnectionData.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_ViewTaskByDate", conn);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable LoadListTaskbyInfoDTO1(DateTime date,string st)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = SqlConnectionData.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_ViewTaskByInfo", conn);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@status", st);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        //Salary
        public static DataTable LoadSalaryListDTO(int m)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection conn = SqlConnectionData.Connect();
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_SalaryList", conn);
            cmd.Parameters.AddWithValue("@month", m);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable LoadAccountNameCbDTO()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = new SqlCommand("proc_GetAccountName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            conn.Close();
            return dt;
        }

        public static string AddNewTaskDTO(fTask t)
        {
            string test = "";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd = new SqlCommand("proc_AddNewTask", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@taskname", t.TaskName);
            cmd.Parameters.AddWithValue("@tasktimein", t.TaskTimeIn);
            cmd.Parameters.AddWithValue("@accountname", t.AccountName);
            cmd.Parameters.AddWithValue("@idstatus", t.idStatus);
            cmd.ExecuteNonQuery();
            conn.Close();
            return test;
        }
        public static string DeleteTaskDTO(fTask t)
        {
            string test = "";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd = new SqlCommand("proc_DeleteTask", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idtask", t.idTask);
            cmd.ExecuteNonQuery();
            conn.Close();
            return test;
        }
        public static string UpdateTaskDTO(fTask t)
        {
            string test = "";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd = new SqlCommand("proc_UpdateTask", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idtask", t.idTask);
            cmd.Parameters.AddWithValue("@taskname", t.TaskName);
            cmd.Parameters.AddWithValue("@accountname", t.AccountName);
            cmd.Parameters.AddWithValue("@idstatus", t.idStatus);
            cmd.ExecuteNonQuery();
            conn.Close();
            return test;
        }
        public static string UpdateTaskDoneDTO(fTask t)
        {
            string test = "";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd = new SqlCommand("proc_UpdateTaskDone", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idtask", t.idTask);
            cmd.Parameters.AddWithValue("@taskname", t.TaskName);
            cmd.Parameters.AddWithValue("@accountname", t.AccountName);
            cmd.Parameters.AddWithValue("@idstatus", t.idStatus);
            cmd.Parameters.AddWithValue("@tasktimeout", t.TaskTimeOut);
            cmd.ExecuteNonQuery();
            conn.Close();
            return test;
        }
        //main employee
        public static DataTable LoadDataAttendanceByAccNameDTO(string x)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = new SqlCommand("proc_AttendanceDateByAccName", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accountname", x);
            da.SelectCommand = cmd;
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            conn.Close();
            return dt;
        }
        public static string AttendanceByDateDTO(string k,DateTime date)
        {
            string test = "";
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd = new SqlCommand("proc_AttendanceByDate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accountname", k);
            cmd.Parameters.AddWithValue("@attendancedate", date);
            cmd.ExecuteNonQuery();
            conn.Close();
            return test;
        }
    }
}




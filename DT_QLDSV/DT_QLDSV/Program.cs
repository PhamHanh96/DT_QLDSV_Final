using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace DT_QLDSV
{
    static class Program
    {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            public static SqlCommand sqlcmd = new SqlCommand();
            public static SqlConnection conn = new SqlConnection();//bo noi voi SP va View
            public static String connstr;
            public static SqlDataReader myReader;
            public static String servername="";
            public static String svPresent = "";
            public static String username = "";
            public static String mlogin = "";
            public static String password = "";
            public static String database = "DT_QLDSV";
            public static String remotelogin = "SUPPORT_CONNECT";
            public static String remotepassword = "123456";
            public static String mloginDN = "";
            public static String passwordDN = "";
            public static String mGroup = "";
            public static String mHoten = "";
            public static int mChinhanh = 0;
            public static Form1 frmChinh;
            public static BindingSource bds_dspm = new BindingSource();

            public static int KetNoi()
            {
                if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                    Program.conn.Close();
                try
                {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database+ ";User ID=" +
                          Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;//truoc khi mo ket noi phai kiem tra chuoi ket noi
                    Program.conn.Open();
                    return 1;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                    return 0;
                }
            }
            
            public static SqlDataReader ExecSqlDataReader(String strLenh)
            {//Reader truy vẫn nhanh nhưng k cho phép sửa, thêm...chỉ dùng trong ngữ cảnh lấy ra để xài hoặc in báo cáo
                SqlDataReader myreader;
                SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
                sqlcmd.CommandType = CommandType.Text;
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                try
                {
                    myreader = sqlcmd.ExecuteReader();
                    return myreader;
                }
                catch (SqlException ex)
                {
                    Program.conn.Close();
                    MessageBox.Show(ex.Message);//chỉ lỗi hệ thống
                    return null;
                }
            
            }

            public static DataTable ExecSqlDataTable(String cmd)
            {//cho phép cập nhật, thêm, xóa, sửa
                DataTable dt = new DataTable();
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
                    da.Fill(dt);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
                return dt;
            }

            public static int ExecSqlNonQuery(String strlenh, String connstr)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connstr;
                conn.Open();
                SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
                Sqlcmd.CommandType = CommandType.Text;
                Sqlcmd.CommandTimeout = 600;// 10 phut 
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    Sqlcmd.ExecuteNonQuery(); conn.Close();
                    return 0;
                }
                catch (SqlException ex)
                {
                   
                    MessageBox.Show(ex.Message);
                    conn.Close();
                    return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
                }
            }
            
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new Form1();
            Application.Run(frmChinh);
            BonusSkins.Register();
        }


    }
}

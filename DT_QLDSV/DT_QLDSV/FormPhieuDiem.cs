using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DT_QLDSV
{
    public partial class FormPhieuDiem : DevExpress.XtraEditors.XtraForm
    {
        public FormPhieuDiem()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String masv = txtMSV.Text.Trim();
            if(masv.Length==0)
            {
                MessageBox.Show("MÃ SINH VIÊN KHÔNG ĐƯỢC ĐỂ TRỐNG, MỜI BẠN KIỂM TRA LẠI!!!");
                return;
            } else if(masv.Length > 8)
            {
                MessageBox.Show("MÃ SINH VIÊN KHÔNG ĐƯỢC QUÁ 8 KÍ TỰ, MỜI BẠN KIỂM TRA LẠI!!!");
                return;
            }
            
            String strLenh = "dbo.sp_TIMSV";

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = masv;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "0")
            {
                MessageBox.Show("MÃ SINH VIÊN NÀY KHÔNG TỒN TẠI, MỜI BẠN KIỂM TRA LẠI!!!", "", MessageBoxButtons.OK);
                txtMSV.Focus();
                Program.conn.Close();
                return;
            }
           
            SqlDataReader myReader;
            strLenh = "SELECT HO+' '+TEN AS HOTEN, TENLOP FROM SINHVIEN, LOP WHERE MASV='" + masv + "' and SINHVIEN.MALOP = LOP.MALOP ";

            myReader = Program.ExecSqlDataReader(strLenh);
            myReader.Read();
            String hoten = myReader.GetString(0);
            String lop = myReader.GetString(1);
            myReader.Close();
            rptPhieuDiemCaNhan obj = new rptPhieuDiemCaNhan();
            strLenh = "exec dbo.sp_InPhieuDiemCaNhan '" + masv + "'";
            DataTable table;
            table = Program.ExecSqlDataTable(strLenh);
            if (table.Rows.Count==0)
            {
                MessageBox.Show("KHÔNG CÓ KẾT QUẢ PHÙ HỢP, MỜI BẠN KIỂM TRA LẠI !!!");
                return;
            }
            obj.SetDataSource(table);
            obj.SetParameterValue("MSSV", masv);
            obj.SetParameterValue("LOP", lop);
            obj.SetParameterValue("HOTEN", hoten);
            crptView.ReportSource = obj;
            crptView.Visible = true;
        }

        private void FormPhieuDiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.enabledButton(true);
        }

        private void FormPhieuDiem_Load(object sender, EventArgs e)
        {
            Program.frmChinh.enabledButton2(false);
        }
    }
}
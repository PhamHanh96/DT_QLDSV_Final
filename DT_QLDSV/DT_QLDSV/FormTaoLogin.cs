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
    public partial class FormTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if(txtLoginName.Text.Trim().Length==0|| txtPass.Text.Trim().Length == 0|| txtUsername.Text.Trim().Length==0)
            {
                MessageBox.Show("BẠN KHÔNG ĐƯỢC BỎ TRỐNG THÔNG TIN NÀO, MỜI BẠN KIỂM TRA LẠI!!!", "", MessageBoxButtons.OK);
                return;
            }

            String strLenh = "dbo.SP_TAOLOGIN";
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@LGNAME", SqlDbType.VarChar).Value = txtLoginName.Text.Trim();
            Program.sqlcmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = txtPass.Text.Trim();
            Program.sqlcmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = txtUsername.Text.Trim();
            Program.sqlcmd.Parameters.Add("@ROLE", SqlDbType.VarChar).Value = cboNhom.Text.Trim();
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            try
            {
                Program.sqlcmd.ExecuteNonQuery();
            }catch(SqlException ex)
            {
                
            }
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "1")
            {
                MessageBox.Show("LOGIN NAME BỊ TRÙNG, MỜI BẠN KIỂM TRA LẠI!!!", "", MessageBoxButtons.OK);
                Program.conn.Close();
            }
            else if(Ret == "2")
            {
                MessageBox.Show("USER NAME BỊ TRÙNG, MỜI BẠN KIỂM TRA LẠI!!!", "", MessageBoxButtons.OK);
                Program.conn.Close();
            }
            else
            {
                MessageBox.Show("TẠO TÀI KHOẢN THÀNH CÔNG!!!", "", MessageBoxButtons.OK);
                Program.conn.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtLoginName.Text = "";
            txtPass.Text = "";
            txtUsername.Text = "";
            cboNhom.SelectedIndex = 0;
        }
    }
}
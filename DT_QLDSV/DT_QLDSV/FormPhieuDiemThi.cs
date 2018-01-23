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

namespace DT_QLDSV
{
    public partial class FormPhieuDiemThi : DevExpress.XtraEditors.XtraForm
    {
        String connStrForm = Program.connstr;
        public FormPhieuDiemThi()
        {
            InitializeComponent();
        }

       private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormPhieuDiemThi_Load(object sender, EventArgs e)
        {
            cboKhoa.DataSource = Program.bds_dspm;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";
            cboKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV") cboKhoa.Enabled = true;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            Program.frmChinh.enabledButton2(false);
            cboMaLop.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboLanThi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            rptPhieuDiemThi obj = new rptPhieuDiemThi();
            String strLenh;
            String maMH, maLop, hocKi, lanThi, date;
            maMH = cboMonHoc.SelectedValue.ToString().Trim();
            maLop = cboMaLop.Text.Trim();
            hocKi = txtHK.Text.Trim();
            lanThi = cboLanThi.Text.Trim();
          
            date = cboNgayThi.Text;
            int hk = Convert.ToInt32(hocKi);
            if(hk <= 0)
            {
                MessageBox.Show("HỌC KÌ PHẢI LÀ SỐ DƯƠNG, MỜI BẠN NHẬP LẠI!!!");
                return;
            }
            strLenh = "dbo.sp_wasThi";
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.NChar).Value = cboMaLop.Text.Trim();
            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = (String) cboMonHoc.SelectedValue;
            Program.sqlcmd.Parameters.Add("@LANTHI", SqlDbType.Int).Value = cboLanThi.Text.Trim();
            Program.sqlcmd.Parameters.Add("@HOCKI", SqlDbType.Int).Value = txtHK.Text.Trim();
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "1")
            {
                MessageBox.Show("KẾT QUẢ BẠN TÌM ĐÃ ĐƯỢC THI RỒI, MỜI BẠN KIỂM TRA LẠI!!!", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }

            strLenh = "exec sp_INPhieuDiem '" + maLop + "','" + maMH + "'";
            DataTable table;
            table = Program.ExecSqlDataTable(strLenh);
            if(table.Rows.Count==0)
            {
                MessageBox.Show("KHÔNG CÓ KẾT QUẢ PHÙ HỢP, MỜI BẠN KIỂM TRA LẠI !!!");
                return;
            }
            obj.SetDataSource(table);
            obj.SetParameterValue("LOP", txtTenLop.Text);
            obj.SetParameterValue("MONHOC", cboMonHoc.Text.Trim());
            obj.SetParameterValue("NGAYTHI", date);
            crptView.ReportSource = obj;
            crptView.Visible = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĐANG TIẾN HÀNH IN BÁO CÁO, NHẤN OK ĐỂ XÁC NHẬN!!!");
            //crptView.PrintReport();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.DataSource == null || cboKhoa.ValueMember.ToString().Equals("")) return;
            String servername = cboKhoa.SelectedValue.ToString();

            if (servername == null)
            {
                this.Validate();
                this.lOPTableAdapter.Connection.ConnectionString = connStrForm = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
            else if (servername.Equals(Program.svPresent))
            {
                this.lOPTableAdapter.Connection.ConnectionString = connStrForm = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
            else
            {
                String connstr = "Data Source=" + servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                          Program.remotelogin + ";password=" + Program.remotepassword;
                this.lOPTableAdapter.Connection.ConnectionString = connStrForm = connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
        }

        private void FormPhieuDiemThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.enabledButton(true);
        }
    }
}
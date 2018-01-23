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
    public partial class FormBDMH : DevExpress.XtraEditors.XtraForm
    {
        public FormBDMH()
        {
            InitializeComponent();
        }

        String connStrForm = Program.connstr;

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormBDMH_Load(object sender, EventArgs e)
        {
            cboKhoa.DataSource = Program.bds_dspm;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";
            cboKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV") cboKhoa.Enabled = true;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            cboLanThi.SelectedIndex = 0;
            Program.frmChinh.enabledButton2(false);
           /* cboTenLop.SelectedIndex = -1;
            cboTenLop.SelectedIndex = 0;
            cbotenMH.SelectedIndex = -1;
            cbotenMH.SelectedIndex = 0;*/

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbotenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            rptInDiemTheoMon obj = new rptInDiemTheoMon();
            String strLenh;
            String maMH, maLop, hocKi, lanThi;
            maMH = cbotenMH.SelectedValue.ToString().Trim();
            maLop = cboTenLop.SelectedValue.ToString().Trim();
            hocKi = txtHOCKI.Text;
            if(hocKi.Equals(""))
            {
                MessageBox.Show("HỌC KÌ KHÔNG ĐƯỢC ĐỂ TRỐNG, MỜI BẠN NHẬP LẠI!!!");
                return;
            }
            lanThi = cboLanThi.Text.Trim();
            int hk = Convert.ToInt32(hocKi);
            if(hk <=0)
            {
                MessageBox.Show("HỌC KI PHẢI LÀ SỐ DƯƠNG, MỜI BẠN NHẬP LAI!!!");
                return;
            }
            strLenh = "exec sp_InDiemTheoMonHoc '" + maMH+"','"+maLop+"',"+lanThi+","+hocKi;
            DataTable table;
            table = Program.ExecSqlDataTable(strLenh);
            obj.SetDataSource(table);
            if(table.Rows.Count==0)
            {
                MessageBox.Show("KHỐNG TÌM THẤY KẾT QUẢ PHÙ HƠP, MỜI BẠN KIỂM TRA LẠI!!!");
                return;
            }
            obj.SetParameterValue("TENLOP", cboTenLop.Text);
            obj.SetParameterValue("TENMH", cbotenMH.Text.Trim());
            obj.SetParameterValue("LANTHI", cboLanThi.Text);
            obj.SetParameterValue("HOCKI", txtHOCKI.Text);
            crptView.ReportSource = obj;
            crptView.Visible = true;

        }

        private void cboTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnMayIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĐANG TIẾN HÀNH IN BÁO CÁO, MỜI BẠN XÁC NHÂN!!!");
           // crptView.PrintReport();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.DataSource == null || cboKhoa.ValueMember.ToString().Equals("")) return;
            String servername = cboKhoa.SelectedValue.ToString();

            if (servername == null)
            {
                this.Validate();
                this.lOPTableAdapter.Connection.ConnectionString = connStrForm =  Program.connstr;
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

        private void FormBDMH_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.enabledButton(true);
        }
    }
}
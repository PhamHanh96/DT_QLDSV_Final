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
    public partial class FormInDSSV : DevExpress.XtraEditors.XtraForm
    {
        public FormInDSSV()
        {
            InitializeComponent();
        }
        String connStrForm = Program.connstr;// lưu lại câu truy vẫn nếu có chuyển server
        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void FormInDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            cboKhoa.DataSource = Program.bds_dspm;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";
            cboKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV") cboKhoa.Enabled = true;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            cboMALOP.SelectedIndex = 0;
            cboMALOP.SelectedIndex = 1;
            Program.frmChinh.enabledButton2(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            rptInDSSV obj = new rptInDSSV();
            String strLenh;
            strLenh = "exec dbo.sp_InDSSV '" + cboMALOP.Text.Trim()+"'";
            DataTable table;
            table = Program.ExecSqlDataTable(strLenh);
            if (table.Rows.Count==0)
            {
                MessageBox.Show("KHÔNG CÓ KẾT QUẢ PHÙ HỢP, MỜI BẠN KIỂM TRA LẠI !!!");
                return;
            }
            obj.SetDataSource(table);
            obj.SetParameterValue("TENLOP", txtTenLop.Text);
            crptView.ReportSource = obj;
            crptView.Visible = true;

        }

        private void crptView_Load(object sender, EventArgs e)
        {

        }

        private void btnMayIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĐANG TIẾN HÀNH IN BÁO CÁO, NHẤN OK ĐỂ XÁC NHẬN !!!");
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
                this.lOPTableAdapter.Connection.ConnectionString = connStrForm =  Program.connstr;
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

        private void FormInDSSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.enabledButton(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cboMALOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

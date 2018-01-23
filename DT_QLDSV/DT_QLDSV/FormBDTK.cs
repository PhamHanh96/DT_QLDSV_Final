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
    public partial class FormBDTK : DevExpress.XtraEditors.XtraForm
    {
        public FormBDTK()
        {
            InitializeComponent();
        }

        private void FormBDTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

        }

        private void cboLOP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
           /* crptView.Visible = true;
            rptBDTK obj = new rptBDTK();
            String strLenh;
            String malop = cboMaLop.SelectedValue.ToString().Trim();
            strLenh = "exec dbo.sp_InBangDiemTongKet '" + malop + "'";
            DataTable table;
            table = Program.ExecSqlDataTable(strLenh, Program.connstr);
            obj.SetDataSource(table);
            crptView.ReportSource = obj;*/
        }
    }
}
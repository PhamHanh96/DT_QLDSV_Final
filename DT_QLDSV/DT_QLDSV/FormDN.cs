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
    public partial class FormDN : DevExpress.XtraEditors.XtraForm
    {
       
        public FormDN()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dT_QLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dT_QLDSVDataSet.V_DS_PHANMANH);
            cboKhoa.SelectedIndex = 1;// = 1 tương đương với chọn dòng số 2
            cboKhoa.SelectedIndex = 0;// = 0 tương đương với chọn dòng số 1
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedValue == null) return;
            Program.servername = cboKhoa.SelectedValue.ToString();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vDSPHANMANHBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")//nếu login rỗng
            {
                MessageBox.Show("Không dc để trống ");
                MessageBox.Show("Tài khoản đăng nhập không được rỗng.", "Báo lỗi đăng nhập.", MessageBoxButtons.OK);//cửa sổ có 1 nút thông báo, nhấn vô OK
                txtUsername.Focus();//nháy nhảy về đâu dùng lệnh focus
                return;//kết thúc không cho chạy nữa
            }
            //nếu login khác rỗng, ta phải kết nối
            Program.mlogin = txtUsername.Text;
            Program.password = txtPassword.Text;
            Program.servername = (String) cboKhoa.SelectedValue;
            Program.svPresent = Program.servername;
            if (Program.KetNoi() == 0)
                return; // kết thúc không truyền nữa
            else  MessageBox.Show("Tài khoản đăng nhập thành công","", MessageBoxButtons.OK);
            SqlDataReader myReader;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();//trả về 1 dòng. Nếu sp trả về nhiều dòng, sử dụng vòng lặp while(true)//đọc đúng trả về true, kết thúc trả về false

            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MAGV.Text = "Mã giảng viên: " + Program.username;
            Program.frmChinh.HOTEN.Text ="Họ tên: " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
            Program.mChinhanh = cboKhoa.SelectedIndex;
            Program.bds_dspm = bdsPM;
            Program.frmChinh.enabledButton(true);
            Close();
        }
    }
}
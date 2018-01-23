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
    public partial class FormDiem : DevExpress.XtraEditors.XtraForm
    {
        List<DIEMSV> listDIEM = new List<DIEMSV>();
        List<int> listCN = new List<int>();//1 = insert, 0 = update
        List<String> listLenh = new List<String>();
        public FormDiem()
        {
            InitializeComponent();
        }

        /*private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }*/

        private void FormDiem_Load(object sender, EventArgs e)
        {
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            cboMaLop.SelectedIndex = 1;
            cboMaLop.SelectedIndex = 0;
            cboTenMH.SelectedIndex = 1;
            cboTenMH.SelectedIndex = 0;
            Program.frmChinh.enabledButton2(false);
            enabled(true);
        }

        public void enabled(Boolean b)
        {
            cboMaLop.Enabled = cboTenMH.Enabled = cboLanThi.Enabled = txtHK.Enabled = btnBatDau.Enabled = b;
            btnLuu.Enabled = btnHuy.Enabled =  gridControl1.Visible = !b;
        }

        //btnBatDau
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String hocki = txtHK.Text.Trim();
            if(hocki.Equals(""))
            {
                MessageBox.Show("BẠN KHÔNG ĐƯỢC ĐỂ TRỐNG HỌC KÌ< MỜI BẠN NHẬP LAI!");
                return;
            }
            int hk = Convert.ToInt32(hocki);
            if (hk <= 0)
            {
                MessageBox.Show("HỌC KÌ PHẢI LÀ SỐ DƯƠNG, MỜI BẠN NHẬP LẠI!!!");
                return;
            }
            enabled(false);
            
            int lan = Convert.ToInt32(cboLanThi.Text.Trim()); 
            String mamh = cboTenMH.SelectedValue.ToString().Trim();
            String strLenh;
            strLenh = "Exec sp_DsDiemSV '" + cboMaLop.Text.Trim() + "','" + mamh + "'," + lan + "," + hocki;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                MessageBox.Show("LỚP NÀY HIỆN KHÔNG CÓ SINH VIÊN NÀO NÊN BẠN KHÔNG THỂ NHẠP ĐIỂM ĐƯỢC, MỜI BẠN KIỂM TRA LẠI!!!");
                return;
            }
            else
            {
                while (Program.myReader.Read())
                {
                    DIEMSV diem = new DIEMSV();
                    diem.MASV = Program.myReader.GetString(0);
                    diem.HOTEN = Program.myReader.GetString(1);
                    double temp = Program.myReader.GetDouble(2);
                    if (temp == -1)
                    {
                        diem.DIEM = -1;
                        listCN.Add(1);
                    }
                    else
                    {
                        diem.DIEM = Program.myReader.GetDouble(2);
                        listCN.Add(0);
                    }
                    diem.HOCKI = hk;
                    diem.LAN = lan;
                    diem.MAMH = mamh;
                    listDIEM.Add(diem);              
                }
            }
            /*strLenh = "Select MASV, HO + ' ' + TEN as HOTEN from SINHVIEN where MALOP = '" + cboMaLop.Text.Trim() + "'";
            
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                MessageBox.Show("LỚP NÀY HIỆN KHÔNG CÓ SINH VIÊN NÀO NÊN BẠN KHÔNG THỂ NHẠP ĐIỂM ĐƯỢC, MỜI BẠN KIỂM TRA LẠI!!!");
                return;
            }
            while(Program.myReader.Read())
            {
                DIEMSV diem = new DIEMSV();
                diem.MASV = Program.myReader.GetString(0);
                diem.HOTEN = Program.myReader.GetString(1);
                diem.HOCKI = hk;
                diem.LAN = lan;
                diem.MAMH = mamh;
                listDIEM.Add(diem);
            }*/
            Program.myReader.Close();
            gridControl1.DataSource = listDIEM;
            gridView1.SelectRow(0);
        }        

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenLop.Text = (String) cboMaLop.SelectedValue;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            int dong = gridView1.FocusedRowHandle;
            DIEMSV diem = gridView1.GetRow(dong) as DIEMSV;
            listDIEM[dong].DIEM = diem.DIEM;
            if(diem.DIEM<0||diem.DIEM>10)
            {
                MessageBox.Show("ĐIỂM PHẢI LÊN HƠN 0 VÀ BÉ HƠN 10, MỜI BẠN NHẬP LAI!!!");
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gridControl1.RefreshDataSource();
            listDIEM.Clear();
            listCN.Clear();
            enabled(true);
        }
        // 1 = insert ; 0 = update
        private void btnLuu_Click(object sender, EventArgs e)
        {
            String strLenh;
            try
            {
                for (int i = 0; i < listDIEM.Count; i++)
                {
                    if(listDIEM[i].DIEM != -1)
                    {
                        if (listCN[i] == 1)
                        {
                            strLenh = "Insert into DIEM(MASV,MAMH,LAN,DIEM,HOCKI) values('" + listDIEM[i].MASV + "','"
                            + listDIEM[i].MAMH.Trim() + "'," + listDIEM[i].LAN + "," + listDIEM[i].DIEM + "," + listDIEM[i].HOCKI + ")";
                            listLenh.Add(strLenh);
                        }
                        else
                        {
                            strLenh = "Update DIEM set DIEM = " + listDIEM[i].DIEM + " where MASV = '" + listDIEM[i].MASV +
                                "' and LAN = " + listDIEM[i].LAN + " and HOCKI = " + listDIEM[i].HOCKI;
                            listLenh.Add(strLenh);
                        }
                    }
                }
                strLenh = "SET XACT_ABORT ON   BEGIN DISTRIBUTED TRANSACTION";

                foreach (String lenh in listLenh)
                {
                    strLenh += "   " + lenh;
                }
                strLenh += "     COMMIT TRANSACTION";
                if (Program.ExecSqlNonQuery(strLenh, Program.connstr) != 0)
                {
                    MessageBox.Show("Xảy ra lỗi");
                    return;
                }
                MessageBox.Show("LƯU THÀNH CÔNG!!!");
                btnLuu.Enabled = false;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void FormDiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listCN.Count > 0 && DialogResult.Yes == MessageBox.Show("BẠN CHƯA LƯU, MỌI THAO TÁC SẼ BỊ HỦY, BẠN CÓ MUỐN LƯU LẠI KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                btnLuu.PerformClick();
            Program.frmChinh.enabledButton(true);
        }
    }
}
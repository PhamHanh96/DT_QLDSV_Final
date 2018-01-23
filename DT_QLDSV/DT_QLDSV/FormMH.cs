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
    public partial class FormMH : DevExpress.XtraEditors.XtraForm
    {

        int chucNang = 0;
        MonHoc monHocXOA = new MonHoc();
        MonHoc monHocSUA = new MonHoc();
        int vitriPre = 0;
        List<String> listLenh = new List<String>();
        
        public FormMH()
        {
            InitializeComponent();
        }

        public void enabled(Boolean b)
        {
            bbtnThem.Enabled = bbtnXoa.Enabled = bbtnSua.Enabled = mONHOCGridControl.Enabled = bbtnPhucHoi.Enabled = bbtnGhi.Enabled = b;
            pnNHAP.Enabled = bbtnKiemTra.Enabled = bbtnHuy.Enabled = !b;
        }

     /*   private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }*/

        private void FormMH_Load(object sender, EventArgs e)
        {
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            Program.frmChinh.enabledButton2(false);
            enabled(true);
            
        }

        private void bbtnTHoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void bbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucNang = 1;
            enabled(false);
            mONHOCBindingSource.AddNew();
        }

        private void bbtnXOa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strLenh = "dbo.sp_isSVhoc";
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMaMH.Text.Trim();
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "1")
            {
                MessageBox.Show("MÔN HỌC NÀY ĐÃ CÓ SINH VIÊN NÊN KHỐNG THỂ XÓA, MỜI BẠN KIỂM TRA LẠI!!!", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                chucNang = 2;
                monHocXOA.maMH = txtMaMH.Text.Trim();
                monHocXOA.tenMH = txtTenMH.Text.Trim();
                this.mONHOCBindingSource.RemoveCurrent();
                String lenh = taoCauTruyVan(chucNang, monHocXOA);
                listLenh.Add(lenh);
            }
        }

        private void bbtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enabled(false);
            chucNang = 3;
            txtMaMH.Enabled = false;
            monHocSUA.maMH = txtMaMH.Text.Trim();
            monHocSUA.tenMH = txtTenMH.Text.Trim();
        }

        private void bbtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chucNang == 0)//ko có
            {
                MessageBox.Show("BẠN CHỈ CÓ THỂ QUAY LUI 1 BƯỚC HOẶC VẪN CHƯA CÓ THAO TÁC NÀO ĐƯỢC THỰC HIỆN!!!");
                return;
            }
            if (chucNang == 1)//thêm->Xóa
            {
                gridView1.SelectRow(vitriPre);
                mONHOCBindingSource.RemoveAt(vitriPre);
            }
            if (chucNang == 2)//Xóa->Thêm
            {
                mONHOCBindingSource.AddNew();
                txtMaMH.Text = monHocXOA.maMH;
                txtTenMH.Text = monHocXOA.tenMH;
            }
            if (chucNang == 3)// sửa -> sửa lai sv trước đó
            {
                if(gridView1.FocusedRowHandle!=vitriPre)
                {
                    MessageBox.Show("VUI LÒNG CHỌN DÒNG " + (vitriPre+1) + " ĐỂ CÓ THỂ PHỤC HỒI!!!");
                    return;
                }
                gridView1.SelectRow(vitriPre);
                txtTenMH.Text = monHocSUA.tenMH;
            }
            listLenh.RemoveAt(listLenh.Count - 1);
            chucNang = 0;
        }

        private void bbtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strLenh = "SET XACT_ABORT ON   BEGIN DISTRIBUTED TRANSACTION";

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
            listLenh.Clear();
            MessageBox.Show("GHI THÀNH CÔNG!!!");
        }

        public Boolean kiemTraNhap()
        {
            if (txtMaMH.Text.Trim().Length == 0 || txtTenMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("BẠN KHÔNG ĐƯỢC BỎ TRỐNG THÔNG TIN NÀO, MỜI BẠN KIỂM TRA LẠI !!!");
                return false;
            }
            if (txtMaMH.Text.Trim().Length > 8)
            {
                MessageBox.Show("MÃ MÔN HỌC KHÔNG ĐƯỢC QUÁ 8 KÍ TỰ, MỜI BẠN KIỂM TRA LẠI !!!");
                return false;
            }
            if (chucNang != 3 && (txtMaMH.Text.Equals(monHocXOA.maMH) == false))
            {
                String strLenh = "dbo.sp_TIMMONHOC";
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txtMaMH.Text.Trim();
                Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.NChar).Value = txtTenMH.Text.Trim();
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret == "1")
                {
                    MessageBox.Show("MÃ MÔN HỌC NÀY ĐÃ TỒN TẠI, MỜI BẠN KIỂM TRA LẠI!!!", "", MessageBoxButtons.OK);
                    Program.conn.Close();
                    return false;
                }
                else if(Ret == "2")
                {
                    MessageBox.Show("TÊN MÔN HỌC NÀY ĐÃ TỒN TẠI, MỜI BẠN KIỂM TRA LẠI!!!", "", MessageBoxButtons.OK);
                    Program.conn.Close();
                    return false;
                }
            }
            return true;
        }

        private void bbtnKiemTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MonHoc monhoc = new MonHoc();
            monhoc.maMH = txtMaMH.Text.Trim().ToUpper();
            monhoc.tenMH = txtTenMH.Text.Trim();
            
            if (kiemTraNhap())
            {
                if (DialogResult.Yes == MessageBox.Show("KHÔNG PHÁT HIỆN LỖI NÀO , BẠN CÓ MUỐN LƯU LẠI KHÔNG!!!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    String lenh = taoCauTruyVan(chucNang, monhoc);
                    listLenh.Add(lenh);
                    if (chucNang == 1) vitriPre = mONHOCBindingSource.Count-1;
                    else vitriPre = gridView1.FocusedRowHandle;
                    if (chucNang == 3) txtMaMH.Enabled = true;
                }
                else
                {
                    enabled(false);
                    return;
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("BẠN CÓ MUỐN CHÍNH SỬA HAY KHÔNG ? NẾU KHÔNG THAO TÁC SẼ BỊ HỦY!!!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    enabled(false);
                    return;
                }
                else
                {
                    mONHOCBindingSource.CancelEdit();
                }
            }
            enabled(true);
            gridView1.Focus();
        }

        private void bbtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mONHOCBindingSource.CancelEdit();
            if (chucNang == 3) txtMaMH.Enabled = true;
            enabled(true);
        }

        public String taoCauTruyVan(int CN, MonHoc monhoc)
        {
            String strLenh = "";
            if (CN == 1)
            {
                strLenh = "insert into MONHOC(MAMH,TENMH) values('"+monhoc.maMH+"',N'"+monhoc.tenMH+"')";
            }
            else if (CN == 2)
            {
                strLenh = "delete from MONHOC where MAMH = '"+monhoc.maMH+"'";
            }
            else
            {
                strLenh = "update MONHOC set TENMH=N'"+monhoc.maMH+"'";
            }
            return strLenh;
        }

        private void FormMH_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listLenh.Count != 0 && DialogResult.Yes == MessageBox.Show("BẠN CẦN GHI TRƯỚC KHI TẮT FORM ,NẾU KHÔNG CÁC THAO TÁC SẼ KHÔNG ĐƯỢC LƯU, BẠN CÓ ĐỒNG Ý KHÔNG???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bbtnGhi.PerformClick();
            }
            Program.conn.Close();
            Program.frmChinh.enabledButton(true);
        }
    }

    public class MonHoc
    {
        public String maMH { get; set; }
        public String tenMH { get; set; }
    }
}
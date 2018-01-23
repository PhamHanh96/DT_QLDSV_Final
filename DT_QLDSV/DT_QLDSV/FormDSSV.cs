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
    public partial class FormDSSV : DevExpress.XtraEditors.XtraForm
    {
        List<String> listLenh = new List<String>();
        int chucNang = 0;// 1:Thêm||2:Xóa||3:Sửa
        String connStrForm = Program.connstr;// lưu lại câu truy vẫn nếu có chuyển server
  //      SinhVien svTHEM = new SinhVien();
        SinhVien svXOA = new SinhVien();
        SinhVien svSUA = new SinhVien();
        int vitriPre = 0;
        public FormDSSV()
        {
            InitializeComponent();
        }

        private void bbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            chucNang = 1;
            enabled(false);
            sINHVIENBindingSource.AddNew();
        }

        //bbtnXoa
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa???", "THÔNG BÁO", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                chucNang = 2;
                
                svXOA.maSV = txtMASV.Text.Trim();
                svXOA.ho = txtHo.Text.Trim();
                svXOA.ten = txtTen.Text.Trim();
                svXOA.noiSinh = txtNoiSinh.Text.Trim();
                svXOA.diaChi = txtDiaChi.Text.Trim();
                svXOA.maLop = cboMaLop.Text.Trim();
                if (checkPhai.CheckState == CheckState.Checked) svXOA.phai = true;
                else svXOA.phai = false;
                if (checkNghi.CheckState == CheckState.Unchecked) svXOA.nghiHoc = true;
                else svXOA.nghiHoc = false;
                this.sINHVIENBindingSource.RemoveCurrent();
                String lenh = taoCauTruyVan(chucNang, svXOA);
                listLenh.Add(lenh);
            }
        }
        //bbtnHieuChinh
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enabled(false);
            chucNang = 3;
            txtMASV.Enabled = false;
            svSUA.maSV = txtMASV.Text.Trim();
            svSUA.ho = txtHo.Text.Trim();
            svSUA.noiSinh = txtNoiSinh.Text.Trim();
            svSUA.diaChi = txtDiaChi.Text.Trim();
            svSUA.maLop = cboMaLop.Text.Trim();
            svSUA.ten = txtTen.Text.Trim();
            if (checkPhai.CheckState == CheckState.Checked) svSUA.phai = true;
            else svSUA.phai = false;
            if (checkNghi.CheckState == CheckState.Unchecked) svSUA.nghiHoc = true;
            else svSUA.nghiHoc = false;
            svSUA.ngaySinh = Convert.ToDateTime(nGAYSINHDateEdit.Text);
        }

        /*private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }*/

        public void enabled(Boolean b)
        {
            bbtnThem.Enabled = bbtnXoa.Enabled = bbtnSua.Enabled = sINHVIENGridControl.Enabled = bbtnPhucHoi.Enabled = bbtnGhi.Enabled = bbtnThoat.Enabled = b;
            pnNHAP.Enabled = bbtnKT.Enabled = bbtnHuy.Enabled = !b;
        }

        

        private void FormDSSV_Load(object sender, EventArgs e)
        {
            cboKhoa.DataSource = Program.bds_dspm;
            cboKhoa.DisplayMember = "TENCN";
            cboKhoa.ValueMember = "TENSERVER";
            cboKhoa.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "PGV") cboKhoa.Enabled = true;
            this.sINHVIENTableAdapter.Connection.ConnectionString = connStrForm = Program.connstr;
            this.lOPTableAdapter.Connection.ConnectionString = connStrForm = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.lOPTableAdapter.Fill(this.dS.LOP);
            Program.frmChinh.enabledButton2(false);
            enabled(true);
        }
   
        private Boolean kiemTraNhap()
        {
            if (txtMASV.Text.Trim().Length == 0 || txtHo.Text.Trim().Length == 0 || txtTen.Text.Trim().Length == 0 ||
                 nGAYSINHDateEdit.Text.Trim().Length == 0 || txtNoiSinh.Text.Trim().Length == 0 || txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("BẠN KHÔNG ĐƯỢC BỎ TRỐNG THÔNG TIN NÀO, MỜI BẠN KIỂM TRA LẠI !!!");
                return false;
            }
            if (txtMASV.Text.Trim().Length >8)
            {
                MessageBox.Show("MÃ SINH VIÊN KHÔNG ĐƯỢC QUÁ 8 KÍ TỰ, MỜI BẠN KIỂM TRA LẠI!!!");
                return false;
            }
            if(checkPhai.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("BẠN VẪN CHƯA ĐÁNH DẤU GIỚI TÍNH, MỜI BẠN KIỂM TRA LẠI!!!");
                return false;
            }
            if(checkNghi.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("BẠN VẪN CHƯA XÁC NHẬN VỀ THÔNG TIN NGHỈ HỌC,MỜI BẠN KIỂM TRA LẠI!!!");
                return false;
            }

            if (chucNang != 3 && txtMASV.Text.Equals(svXOA.maSV) == false)
            {
                String strLenh = "dbo.sp_TIMSV";
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = txtMASV.Text.Trim();
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret == "1")
                {
                    MessageBox.Show("MÃ SINH VIÊN NÀY ĐÃ TỒN TẠI, MỜI BẠN KIỂM TRA LẠI!!!", "", MessageBoxButtons.OK);
                    Program.conn.Close();
                    return false;
                }
            }
            return true;
        }

        

        private void bbtnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(chucNang == 0)//ko có
            {
                MessageBox.Show("BẠN CHỈ CÓ THỂ QUAY LUI 1 BƯỚC HOẶC VẪN CHƯA CÓ THAO TÁC NÀO ĐƯỢC THỰC HIỆN!!!");
                return;
            }
            if(chucNang == 1)//thêm->Xóa
            {
                gridView1.SelectRow(vitriPre);
                sINHVIENBindingSource.RemoveAt(vitriPre);
            }
            if(chucNang == 2)//Xóa->Thêm
            {
                sINHVIENBindingSource.AddNew();
                txtMASV.Text = svXOA.maSV;
                txtHo.Text = svXOA.ho;
                txtTen.Text = svXOA.ten;
                txtDiaChi.Text = svXOA.diaChi;
                txtNoiSinh.Text = svXOA.noiSinh;
                if(svXOA.phai == true)
                {
                    checkPhai.CheckState = CheckState.Checked;
                }
                else
                {
                    checkPhai.CheckState = CheckState.Unchecked;
                }
                if(svXOA.nghiHoc == true)
                {
                    checkNghi.CheckState = CheckState.Checked;
                }
                else
                {
                    checkNghi.CheckState = CheckState.Unchecked;
                }
                nGAYSINHDateEdit.DateTime = svXOA.ngaySinh;
            }
            if(chucNang == 3)// sửa -> sửa lai sv trước đó
            {
                gridView1.SelectRow(vitriPre);
                if (gridView1.FocusedRowHandle != vitriPre)
                {
                    MessageBox.Show("VUI LÒNG CHỌN DÒNG " + (vitriPre + 1) + " ĐỂ CÓ THỂ PHỤC HỒI!!!");
                    return;
                }
                txtHo.Text = svSUA.ho;
                txtTen.Text = svSUA.ten;
                txtDiaChi.Text = svSUA.diaChi;
                txtNoiSinh.Text = svSUA.noiSinh;
                if (svSUA.phai == true)
                {
                    checkPhai.CheckState = CheckState.Checked;
                }
                else
                {
                    checkPhai.CheckState = CheckState.Unchecked;
                }
                if (svSUA.nghiHoc == true)
                {
                    checkNghi.CheckState = CheckState.Checked;
                }
                else
                {
                    checkNghi.CheckState = CheckState.Unchecked;
                }
                nGAYSINHDateEdit.DateTime = svSUA.ngaySinh;
            }
            listLenh.RemoveAt(listLenh.Count - 1);
            chucNang = 0;
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listLenh.Count != 0)
            {
                if(DialogResult.Yes == MessageBox.Show("BẠN CẦN GHI TRƯỚC KHI CHUYỂN KHOA,NẾU KHÔNG CÁC THAO TÁC SẼ KHÔNG ĐƯỢC LƯU, BẠN CÓ ĐỒNG Ý KHÔNG???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bbtnGhi.PerformClick();
                }
                listLenh.Clear();
            }
            if (cboKhoa.DataSource == null || cboKhoa.ValueMember.ToString().Equals("")) return;
            String servername = cboKhoa.SelectedValue.ToString();

            if(servername==null)
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString = connStrForm = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            }
            else  if (servername.Equals(Program.svPresent))
            {
                this.sINHVIENTableAdapter.Connection.ConnectionString  = connStrForm =  Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            }
            else
            {
                String connstr = "Data Source=" + servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                          Program.remotelogin + ";password=" + Program.remotepassword;
                this.sINHVIENTableAdapter.Connection.ConnectionString = connStrForm = connstr;
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            }
        }

        private void bbtnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strLenh = "SET XACT_ABORT ON   BEGIN DISTRIBUTED TRANSACTION";

            foreach (String lenh in listLenh)
            {
                strLenh += "   " + lenh;
            }
            strLenh += "     COMMIT TRANSACTION";
            if (Program.ExecSqlNonQuery(strLenh, connStrForm) != 0)
            {
                MessageBox.Show("Xảy ra lỗi");
                return;
            }
            listLenh.Clear();
            MessageBox.Show("GHI THÀNH CÔNG!!!");
        }
        //btnGHI

        public String taoCauTruyVan(int CN, SinhVien sv)
        {
            String strLenh = "";
            if(CN == 1)
            {
                strLenh = "EXEC sp_DanhSachSinhVienTheoLop_Insert '"
                    +sv.maSV + "',N'" + sv.ho + "',N'" + sv.ten + "','"
                    + sv.maLop + "','" + sv.phai + "','"+sv.ngaySinh+"',N'"
                    +sv.noiSinh+"',N'"+sv.diaChi+"','"+sv.nghiHoc+"'";
                
            }
            else if(CN == 2)
            {
                strLenh = "EXEC sp_DanhSachSinhVienTheoLop_Delete '"+sv.maSV+"'";
                
            }
            else
            {
                strLenh = "EXEC sp_DanhSachSinhVienTheoLop_Update '"
                    + sv.maSV + "',N'" + sv.ho + "',N'" + sv.ten + "','"
                    + sv.phai + "','" + sv.ngaySinh + "',N'"
                    + sv.noiSinh + "',N'" + sv.diaChi + "','" + sv.nghiHoc + "'";
                
            }
            return strLenh;
        } 
        //bbtnKIEMTRA
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.maSV = txtMASV.Text.Trim().ToUpper();
            sv.ho = txtHo.Text.Trim();
            sv.ten = txtTen.Text.Trim();
            sv.noiSinh = txtNoiSinh.Text.Trim();
            sv.diaChi = txtDiaChi.Text.Trim();
            sv.maLop = cboMaLop.Text.Trim();
            if (checkPhai.CheckState == CheckState.Checked) sv.phai = true;
            else sv.phai = false;
            if (checkNghi.CheckState == CheckState.Unchecked) sv.nghiHoc = true;
            else sv.nghiHoc = false;
            sv.ngaySinh = Convert.ToDateTime(nGAYSINHDateEdit.Text);
            if (kiemTraNhap())
                {
                    if (DialogResult.Yes == MessageBox.Show("KHÔNG PHÁT HIỆN LỖI NÀO , BẠN CÓ MUỐN LƯU LẠI KHÔNG!!!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        String lenh = taoCauTruyVan(chucNang, sv);
                        listLenh.Add(lenh);
                        if (chucNang == 1) vitriPre = sINHVIENBindingSource.Count-1;
                        else vitriPre = gridView1.FocusedRowHandle;
                        if (chucNang==3)txtMASV.Enabled = true;
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
                        sINHVIENBindingSource.CancelEdit();
                    }
                }
            
            enabled(true);
            gridView1.Focus();
        }

        private void bbtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sINHVIENBindingSource.CancelEdit();
            if (chucNang == 3) txtMASV.Enabled = true;
            enabled(true);
        }

        private void FormDSSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listLenh.Count != 0 && DialogResult.Yes == MessageBox.Show("BẠN CẦN GHI TRƯỚC KHI CHUYỂN KHOA,NẾU KHÔNG CÁC THAO TÁC SẼ KHÔNG ĐƯỢC LƯU, BẠN CÓ ĐỒNG Ý KHÔNG???", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                bbtnGhi.PerformClick();
            }
            Program.conn.Close();
            Program.frmChinh.enabledButton(true);
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class SinhVien
    {
        public String maSV { get; set; }
        public String ho { get; set; }
        public String ten { get; set; }
        public String maLop { get; set; }
        public Boolean phai { get; set; }
        public DateTime ngaySinh { get; set; }
        public String noiSinh { get; set; }
        public String diaChi { get; set; }
        public Boolean nghiHoc { get; set; }
    }
}
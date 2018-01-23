using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DT_QLDSV
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            enabledButton(false);
            btnLogin.PerformClick();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void bbtnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDN));
            if (frm != null) frm.Activate();
            else
            {
                FormDN fmDN = new FormDN();
                fmDN.MdiParent = this;
                fmDN.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void KHOA_Click(object sender, EventArgs e)
        {

        }

        public void enabledButton(Boolean b)
        {
            bbtnLop.Enabled = bbtnDSSV.Enabled = bbtnMonHoc.Enabled = bbtnDiem.Enabled = bbtnBDMH.Enabled = bbtnBDTK.Enabled 
            = bbtnPD.Enabled = bbtnSinhVien.Enabled = bbtnPDT.Enabled = bbtnLogout.Enabled = bbtnTaoLogin.Enabled =b;
            btnLogin.Enabled = !b;
        }

        public void enabledButton2(Boolean b)
        {
            enabledButton(b);
            btnLogin.Enabled = b;
        }

        private void bbtnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLop));
            if (frm != null) frm.Activate();
            else
            {
                FormLop fmLop = new FormLop();
                fmLop.MdiParent = this;
                fmLop.Show();
            }
        }

        private void bbtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.username = "";
            Program.mHoten = "";
            Program.mGroup = "";
            Program.mlogin = "";
            Program.password = "";
            Program.servername = "";
            Program.frmChinh.MAGV.Text = "Mã giảng viên: " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên: " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
            Program.mChinhanh = 0;
            enabledButton(false);
        }

        private void bbtnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDSSV));
            if (frm != null) frm.Activate();
            else
            {
                FormDSSV fmDSSV = new FormDSSV();
                fmDSSV.MdiParent = this;
                fmDSSV.Show();
            }
        }

        private void bbtnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMH));
            if (frm != null) frm.Activate();
            else
            {
                FormMH fmMH= new FormMH();
                fmMH.MdiParent = this;
                fmMH.Show();
            }
        }

        private void bbtnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormDiem fmDiem = new FormDiem();
                fmDiem.MdiParent = this.MdiParent;
                fmDiem.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormInDSSV));
            if (frm != null) frm.Activate();
            else
            {
                FormInDSSV fmInDSSV = new FormInDSSV();
                fmInDSSV.MdiParent = this.MdiParent;
                fmInDSSV.Show();
            }
        }

        private void bbtnPDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPhieuDiemThi));
            if (frm != null) frm.Activate();
            else
            {
                FormPhieuDiemThi fmPDT = new FormPhieuDiemThi();
                fmPDT.MdiParent = this.MdiParent;
                fmPDT.Show();
            }
        }

        private void bbtnBDMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBDMH));
            if (frm != null) frm.Activate();
            else
            {
                FormBDMH fmBDMH = new FormBDMH();
                fmBDMH.MdiParent = this.MdiParent;
                fmBDMH.Show();
            }
        }

        private void bbtnPD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormPhieuDiem fmPD= new FormPhieuDiem();
                fmPD.MdiParent = this.MdiParent;
                fmPD.Show();
            }
        }

        private void bbtnBDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBDTK));
            if (frm != null) frm.Activate();
            else
            {
                FormBDTK fmBDTK = new FormBDTK();
                fmBDTK.MdiParent = this.MdiParent;
                fmBDTK.Show();
            }
        }

        private void bbtnTaoLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.mGroup.Equals("PGV") ==false)
            {
                MessageBox.Show("CHỈ CÓ PHÒNG GIÁO VỤ MỚI ĐƯỢC TẠO LOGIN, XIN LỖI BẠN KHÔNG THỂ TRUY CẬP !!!");
                return;
            }
            Form frm = this.CheckExists(typeof(FormTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoLogin fmBDTK = new FormTaoLogin();
                fmBDTK.MdiParent = this.MdiParent;
                fmBDTK.Show();
            }
        }
    }
}

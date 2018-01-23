namespace DT_QLDSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLop = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDiem = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnTaoLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPDT = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPD = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnBDMH = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnBDTK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogin,
            this.bbtnLogout,
            this.bbtnLop,
            this.bbtnSinhVien,
            this.bbtnMonHoc,
            this.bbtnDiem,
            this.bbtnTaoLogin,
            this.barButtonItem1,
            this.barButtonItem2,
            this.bbtnDSSV,
            this.bbtnPDT,
            this.bbtnPD,
            this.bbtnBDMH,
            this.bbtnBDTK});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1360, 143);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng Nhập";
            this.btnLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogin.Glyph")));
            this.btnLogin.Id = 1;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnLogin_ItemClick);
            // 
            // bbtnLogout
            // 
            this.bbtnLogout.Caption = "Đăng Xuất";
            this.bbtnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnLogout.Glyph")));
            this.bbtnLogout.Id = 2;
            this.bbtnLogout.Name = "bbtnLogout";
            this.bbtnLogout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnLogout_ItemClick);
            // 
            // bbtnLop
            // 
            this.bbtnLop.Caption = "Lớp";
            this.bbtnLop.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnLop.Glyph")));
            this.bbtnLop.Id = 3;
            this.bbtnLop.Name = "bbtnLop";
            this.bbtnLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnLop_ItemClick);
            // 
            // bbtnSinhVien
            // 
            this.bbtnSinhVien.Caption = "Sinh Viên";
            this.bbtnSinhVien.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnSinhVien.Glyph")));
            this.bbtnSinhVien.Id = 4;
            this.bbtnSinhVien.Name = "bbtnSinhVien";
            this.bbtnSinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSinhVien_ItemClick);
            // 
            // bbtnMonHoc
            // 
            this.bbtnMonHoc.Caption = "Môn Học";
            this.bbtnMonHoc.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnMonHoc.Glyph")));
            this.bbtnMonHoc.Id = 5;
            this.bbtnMonHoc.Name = "bbtnMonHoc";
            this.bbtnMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnMonHoc_ItemClick);
            // 
            // bbtnDiem
            // 
            this.bbtnDiem.Caption = "Điểm";
            this.bbtnDiem.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnDiem.Glyph")));
            this.bbtnDiem.Id = 6;
            this.bbtnDiem.Name = "bbtnDiem";
            this.bbtnDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDiem_ItemClick);
            // 
            // bbtnTaoLogin
            // 
            this.bbtnTaoLogin.Caption = "Tạo Login";
            this.bbtnTaoLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnTaoLogin.Glyph")));
            this.bbtnTaoLogin.Id = 7;
            this.bbtnTaoLogin.Name = "bbtnTaoLogin";
            this.bbtnTaoLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnTaoLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnTaoLogin_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "DSSV";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bbtnDSSV
            // 
            this.bbtnDSSV.Caption = "Danh Sách Sinh Viên";
            this.bbtnDSSV.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnDSSV.Glyph")));
            this.bbtnDSSV.Id = 10;
            this.bbtnDSSV.Name = "bbtnDSSV";
            this.bbtnDSSV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // bbtnPDT
            // 
            this.bbtnPDT.Caption = "Phiểu Điểm Thi";
            this.bbtnPDT.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnPDT.Glyph")));
            this.bbtnPDT.Id = 11;
            this.bbtnPDT.Name = "bbtnPDT";
            this.bbtnPDT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnPDT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPDT_ItemClick);
            // 
            // bbtnPD
            // 
            this.bbtnPD.Caption = "Phiếu Điểm";
            this.bbtnPD.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnPD.Glyph")));
            this.bbtnPD.Id = 12;
            this.bbtnPD.Name = "bbtnPD";
            this.bbtnPD.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnPD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPD_ItemClick);
            // 
            // bbtnBDMH
            // 
            this.bbtnBDMH.Caption = "Bảng Điểm Môn Học";
            this.bbtnBDMH.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnBDMH.Glyph")));
            this.bbtnBDMH.Id = 13;
            this.bbtnBDMH.Name = "bbtnBDMH";
            this.bbtnBDMH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnBDMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnBDMH_ItemClick);
            // 
            // bbtnBDTK
            // 
            this.bbtnBDTK.Caption = "Bảng Điểm Tổng Kết";
            this.bbtnBDTK.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnBDTK.Glyph")));
            this.bbtnBDTK.Id = 14;
            this.bbtnBDTK.Name = "bbtnBDTK";
            this.bbtnBDTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnBDTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnBDTK_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnTaoLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức Năng";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh Mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnLop);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Lớp";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnSinhVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Sinh Viên";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnMonHoc);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Môn Học";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.bbtnDiem);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Điểm";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "In Ấn";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bbtnDSSV);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Danh Sách";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.bbtnPDT);
            this.ribbonPageGroup7.ItemLinks.Add(this.bbtnPD);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Phiểu Điểm";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.bbtnBDMH);
            this.ribbonPageGroup8.ItemLinks.Add(this.bbtnBDTK);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Bảng Điểm";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 745);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1360, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MAGV
            // 
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(83, 17);
            this.MAGV.Text = "Mã Giáo Viên: ";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(82, 17);
            this.HOTEN.Text = "Tên Giáo Viên:";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(47, 17);
            this.NHOM.Text = "Nhóm: ";
            this.NHOM.Click += new System.EventHandler(this.KHOA_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 767);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem bbtnLogout;
        private DevExpress.XtraBars.BarButtonItem bbtnLop;
        private DevExpress.XtraBars.BarButtonItem bbtnSinhVien;
        private DevExpress.XtraBars.BarButtonItem bbtnMonHoc;
        private DevExpress.XtraBars.BarButtonItem bbtnDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem bbtnTaoLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MAGV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem bbtnDSSV;
        private DevExpress.XtraBars.BarButtonItem bbtnPDT;
        private DevExpress.XtraBars.BarButtonItem bbtnPD;
        private DevExpress.XtraBars.BarButtonItem bbtnBDMH;
        private DevExpress.XtraBars.BarButtonItem bbtnBDTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
    }
}


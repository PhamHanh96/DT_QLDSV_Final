namespace DT_QLDSV
{
    partial class FormBDMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBDMH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.crptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbotenMH = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DT_QLDSV.DS();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cboLanThi = new System.Windows.Forms.ComboBox();
            this.btnMayIn = new DevExpress.XtraEditors.SimpleButton();
            this.txtHOCKI = new System.Windows.Forms.TextBox();
            this.btnManHinh = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTenLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mONHOCTableAdapter = new DT_QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new DT_QLDSV.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new DT_QLDSV.DSTableAdapters.LOPTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 436);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.crptView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 164);
            this.panel3.TabIndex = 17;
            // 
            // crptView
            // 
            this.crptView.ActiveViewIndex = -1;
            this.crptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptView.DisplayStatusBar = false;
            this.crptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptView.Location = new System.Drawing.Point(0, 0);
            this.crptView.Name = "crptView";
            this.crptView.Size = new System.Drawing.Size(740, 164);
            this.crptView.TabIndex = 0;
            this.crptView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crptView.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboKhoa);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbotenMH);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.cboLanThi);
            this.panel2.Controls.Add(this.btnMayIn);
            this.panel2.Controls.Add(this.txtHOCKI);
            this.panel2.Controls.Add(this.btnManHinh);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboTenLop);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 272);
            this.panel2.TabIndex = 16;
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(145, 78);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(289, 26);
            this.cboKhoa.TabIndex = 18;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.Location = new System.Drawing.Point(27, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Khoa : ";
            // 
            // cbotenMH
            // 
            this.cbotenMH.DataSource = this.mONHOCBindingSource;
            this.cbotenMH.DisplayMember = "TENMH";
            this.cbotenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotenMH.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbotenMH.FormattingEnabled = true;
            this.cbotenMH.Location = new System.Drawing.Point(145, 151);
            this.cbotenMH.Name = "cbotenMH";
            this.cbotenMH.Size = new System.Drawing.Size(289, 26);
            this.cbotenMH.TabIndex = 16;
            this.cbotenMH.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(195, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỂM MÔN HỌC";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(478, 212);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 38);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboLanThi
            // 
            this.cboLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanThi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboLanThi.FormattingEnabled = true;
            this.cboLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboLanThi.Location = new System.Drawing.Point(526, 151);
            this.cboLanThi.Name = "cboLanThi";
            this.cboLanThi.Size = new System.Drawing.Size(101, 26);
            this.cboLanThi.TabIndex = 11;
            this.cboLanThi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnMayIn
            // 
            this.btnMayIn.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMayIn.Appearance.Options.UseFont = true;
            this.btnMayIn.Image = ((System.Drawing.Image)(resources.GetObject("btnMayIn.Image")));
            this.btnMayIn.Location = new System.Drawing.Point(288, 212);
            this.btnMayIn.Name = "btnMayIn";
            this.btnMayIn.Size = new System.Drawing.Size(117, 38);
            this.btnMayIn.TabIndex = 9;
            this.btnMayIn.Text = "Máy In";
            this.btnMayIn.Click += new System.EventHandler(this.btnMayIn_Click);
            // 
            // txtHOCKI
            // 
            this.txtHOCKI.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtHOCKI.Location = new System.Drawing.Point(526, 109);
            this.txtHOCKI.Name = "txtHOCKI";
            this.txtHOCKI.Size = new System.Drawing.Size(100, 25);
            this.txtHOCKI.TabIndex = 15;
            // 
            // btnManHinh
            // 
            this.btnManHinh.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnManHinh.Appearance.Options.UseFont = true;
            this.btnManHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnManHinh.Image")));
            this.btnManHinh.Location = new System.Drawing.Point(109, 212);
            this.btnManHinh.Name = "btnManHinh";
            this.btnManHinh.Size = new System.Drawing.Size(114, 38);
            this.btnManHinh.TabIndex = 8;
            this.btnManHinh.Text = "Màn Hình";
            this.btnManHinh.Click += new System.EventHandler(this.btnManHinh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Lớp :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(448, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Học Kì : ";
            // 
            // cboTenLop
            // 
            this.cboTenLop.DataSource = this.lOPBindingSource;
            this.cboTenLop.DisplayMember = "TENLOP";
            this.cboTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenLop.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboTenLop.FormattingEnabled = true;
            this.cboTenLop.Location = new System.Drawing.Point(145, 114);
            this.cboTenLop.Name = "cboTenLop";
            this.cboTenLop.Size = new System.Drawing.Size(289, 26);
            this.cboTenLop.TabIndex = 13;
            this.cboTenLop.ValueMember = "MALOP";
            this.cboTenLop.SelectedIndexChanged += new System.EventHandler(this.cboTenLop_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(448, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lần Thi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Môn Học : ";
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DT_QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // FormBDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 436);
            this.Controls.Add(this.panel1);
            this.Name = "FormBDMH";
            this.Text = "Bảng ĐiểmTổng Kết";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBDMH_FormClosed);
            this.Load += new System.EventHandler(this.FormBDMH_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnMayIn;
        private DevExpress.XtraEditors.SimpleButton btnManHinh;
        private System.Windows.Forms.ComboBox cboLanThi;
        private System.Windows.Forms.ComboBox cboTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.TextBox txtHOCKI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbotenMH;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label6;
    }
}
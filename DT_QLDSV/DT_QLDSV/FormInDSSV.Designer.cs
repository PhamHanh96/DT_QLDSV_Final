namespace DT_QLDSV
{
    partial class FormInDSSV
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInDSSV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new DT_QLDSV.DS();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cboMALOP = new System.Windows.Forms.ComboBox();
            this.btnMayIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnManHinh = new DevExpress.XtraEditors.SimpleButton();
            this.lOPTableAdapter = new DT_QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new DT_QLDSV.DSTableAdapters.TableAdapterManager();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Tahoma", 11F);
            tENLOPLabel.Location = new System.Drawing.Point(22, 142);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(77, 18);
            tENLOPLabel.TabIndex = 1;
            tENLOPLabel.Text = "Tên Lớp : ";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Tahoma", 11F);
            mALOPLabel.Location = new System.Drawing.Point(374, 142);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(71, 18);
            mALOPLabel.TabIndex = 3;
            mALOPLabel.Text = "Mã Lớp : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crptView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 455);
            this.panel1.TabIndex = 0;
            // 
            // crptView
            // 
            this.crptView.ActiveViewIndex = -1;
            this.crptView.AutoScroll = true;
            this.crptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptView.Location = new System.Drawing.Point(0, 275);
            this.crptView.Name = "crptView";
            this.crptView.Size = new System.Drawing.Size(897, 180);
            this.crptView.TabIndex = 9;
            this.crptView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crptView.Visible = false;
            this.crptView.Load += new System.EventHandler(this.crptView_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenLop);
            this.panel2.Controls.Add(this.cboKhoa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(tENLOPLabel);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.cboMALOP);
            this.panel2.Controls.Add(this.btnMayIn);
            this.panel2.Controls.Add(this.btnManHinh);
            this.panel2.Controls.Add(mALOPLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 275);
            this.panel2.TabIndex = 10;
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.Enabled = false;
            this.cboKhoa.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(105, 86);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(243, 26);
            this.cboKhoa.TabIndex = 10;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "KHOA : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.Location = new System.Drawing.Point(177, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "IN DANH SÁCH SINH VIÊN";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(407, 194);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboMALOP
            // 
            this.cboMALOP.DataSource = this.lOPBindingSource;
            this.cboMALOP.DisplayMember = "MALOP";
            this.cboMALOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMALOP.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cboMALOP.FormattingEnabled = true;
            this.cboMALOP.Location = new System.Drawing.Point(461, 134);
            this.cboMALOP.Name = "cboMALOP";
            this.cboMALOP.Size = new System.Drawing.Size(121, 26);
            this.cboMALOP.TabIndex = 8;
            this.cboMALOP.ValueMember = "TENLOP";
            this.cboMALOP.SelectedIndexChanged += new System.EventHandler(this.cboMALOP_SelectedIndexChanged);
            // 
            // btnMayIn
            // 
            this.btnMayIn.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMayIn.Appearance.Options.UseFont = true;
            this.btnMayIn.Image = ((System.Drawing.Image)(resources.GetObject("btnMayIn.Image")));
            this.btnMayIn.Location = new System.Drawing.Point(252, 194);
            this.btnMayIn.Name = "btnMayIn";
            this.btnMayIn.Size = new System.Drawing.Size(96, 41);
            this.btnMayIn.TabIndex = 6;
            this.btnMayIn.Text = "Máy In";
            this.btnMayIn.Click += new System.EventHandler(this.btnMayIn_Click);
            // 
            // btnManHinh
            // 
            this.btnManHinh.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnManHinh.Appearance.Options.UseFont = true;
            this.btnManHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnManHinh.Image")));
            this.btnManHinh.Location = new System.Drawing.Point(66, 194);
            this.btnManHinh.Name = "btnManHinh";
            this.btnManHinh.Size = new System.Drawing.Size(125, 40);
            this.btnManHinh.TabIndex = 5;
            this.btnManHinh.Text = "Màn Hình";
            this.btnManHinh.Click += new System.EventHandler(this.btnManHinh_Click);
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DT_QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(105, 134);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.ReadOnly = true;
            this.txtTenLop.Size = new System.Drawing.Size(243, 25);
            this.txtTenLop.TabIndex = 11;
            this.txtTenLop.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormInDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 455);
            this.Controls.Add(this.panel1);
            this.Name = "FormInDSSV";
            this.Text = "In Danh Sách Sinh Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInDSSV_FormClosed);
            this.Load += new System.EventHandler(this.FormInDSSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnMayIn;
        private DevExpress.XtraEditors.SimpleButton btnManHinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMALOP;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLop;
    }
}
namespace CRUD_Student
{
    partial class frmMain
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
            this.lblMaMonHoc = new System.Windows.Forms.Label();
            this.lblTenMonHoc = new System.Windows.Forms.Label();
            this.lblSotinChi = new System.Windows.Forms.Label();
            this.lblMaMHCanTim = new System.Windows.Forms.Label();
            this.lblNhapTuKhoa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboMaMonHoc = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTimMHTheoMa = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.dtgvMonHoc = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaMonHoc
            // 
            this.lblMaMonHoc.AutoSize = true;
            this.lblMaMonHoc.Location = new System.Drawing.Point(69, 51);
            this.lblMaMonHoc.Name = "lblMaMonHoc";
            this.lblMaMonHoc.Size = new System.Drawing.Size(96, 20);
            this.lblMaMonHoc.TabIndex = 0;
            this.lblMaMonHoc.Text = "Mã môn học";
            // 
            // lblTenMonHoc
            // 
            this.lblTenMonHoc.AutoSize = true;
            this.lblTenMonHoc.Location = new System.Drawing.Point(69, 92);
            this.lblTenMonHoc.Name = "lblTenMonHoc";
            this.lblTenMonHoc.Size = new System.Drawing.Size(101, 20);
            this.lblTenMonHoc.TabIndex = 1;
            this.lblTenMonHoc.Text = "Tên môn học";
            // 
            // lblSotinChi
            // 
            this.lblSotinChi.AutoSize = true;
            this.lblSotinChi.Location = new System.Drawing.Point(69, 133);
            this.lblSotinChi.Name = "lblSotinChi";
            this.lblSotinChi.Size = new System.Drawing.Size(74, 20);
            this.lblSotinChi.TabIndex = 2;
            this.lblSotinChi.Text = "Số tín chỉ";
            this.lblSotinChi.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMaMHCanTim
            // 
            this.lblMaMHCanTim.AutoSize = true;
            this.lblMaMHCanTim.Location = new System.Drawing.Point(518, 51);
            this.lblMaMHCanTim.Name = "lblMaMHCanTim";
            this.lblMaMHCanTim.Size = new System.Drawing.Size(193, 20);
            this.lblMaMHCanTim.TabIndex = 3;
            this.lblMaMHCanTim.Text = "Chọn mã môn học cần tìm";
            // 
            // lblNhapTuKhoa
            // 
            this.lblNhapTuKhoa.AutoSize = true;
            this.lblNhapTuKhoa.Location = new System.Drawing.Point(841, 51);
            this.lblNhapTuKhoa.Name = "lblNhapTuKhoa";
            this.lblNhapTuKhoa.Size = new System.Drawing.Size(104, 20);
            this.lblNhapTuKhoa.TabIndex = 4;
            this.lblNhapTuKhoa.Text = "Nhập từ khóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(996, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tìm kiếm thông tin";
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(205, 51);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(261, 26);
            this.txtMaMonHoc.TabIndex = 6;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(205, 92);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(261, 26);
            this.txtTenMonHoc.TabIndex = 7;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(205, 133);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(261, 26);
            this.txtSoTinChi.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(982, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 26);
            this.txtSearch.TabIndex = 9;
            // 
            // cboMaMonHoc
            // 
            this.cboMaMonHoc.FormattingEnabled = true;
            this.cboMaMonHoc.Location = new System.Drawing.Point(522, 90);
            this.cboMaMonHoc.Name = "cboMaMonHoc";
            this.cboMaMonHoc.Size = new System.Drawing.Size(189, 28);
            this.cboMaMonHoc.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(982, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 26);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnTimMHTheoMa
            // 
            this.btnTimMHTheoMa.Location = new System.Drawing.Point(522, 133);
            this.btnTimMHTheoMa.Name = "btnTimMHTheoMa";
            this.btnTimMHTheoMa.Size = new System.Drawing.Size(131, 26);
            this.btnTimMHTheoMa.TabIndex = 11;
            this.btnTimMHTheoMa.Text = "Tìm kiếm";
            this.btnTimMHTheoMa.UseVisualStyleBackColor = true;
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHienThi.Location = new System.Drawing.Point(73, 190);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(212, 28);
            this.btnHienThi.TabIndex = 13;
            this.btnHienThi.Text = "Hiển thị tất cả";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dtgvMonHoc
            // 
            this.dtgvMonHoc.AllowUserToAddRows = false;
            this.dtgvMonHoc.AllowUserToDeleteRows = false;
            this.dtgvMonHoc.AllowUserToResizeColumns = false;
            this.dtgvMonHoc.AllowUserToResizeRows = false;
            this.dtgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonHoc.Location = new System.Drawing.Point(73, 247);
            this.dtgvMonHoc.Name = "dtgvMonHoc";
            this.dtgvMonHoc.ReadOnly = true;
            this.dtgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMonHoc.Size = new System.Drawing.Size(1115, 220);
            this.dtgvMonHoc.TabIndex = 14;
            this.dtgvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(73, 504);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(97, 31);
            this.btnThemMoi.TabIndex = 15;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(216, 504);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 31);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(359, 504);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 31);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(502, 504);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 31);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(645, 504);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 31);
            this.button8.TabIndex = 19;
            this.button8.Text = "DSSV";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(788, 504);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 31);
            this.button9.TabIndex = 20;
            this.button9.Text = "DSMH";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.dtgvMonHoc);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnTimMHTheoMa);
            this.Controls.Add(this.cboMaMonHoc);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.txtTenMonHoc);
            this.Controls.Add(this.txtMaMonHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNhapTuKhoa);
            this.Controls.Add(this.lblMaMHCanTim);
            this.Controls.Add(this.lblSotinChi);
            this.Controls.Add(this.lblTenMonHoc);
            this.Controls.Add(this.lblMaMonHoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaMonHoc;
        private System.Windows.Forms.Label lblTenMonHoc;
        private System.Windows.Forms.Label lblSotinChi;
        private System.Windows.Forms.Label lblMaMHCanTim;
        private System.Windows.Forms.Label lblNhapTuKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboMaMonHoc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTimMHTheoMa;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.DataGridView dtgvMonHoc;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}
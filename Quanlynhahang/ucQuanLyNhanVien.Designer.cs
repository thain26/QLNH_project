namespace Quanlynhahang
{
    partial class ucQuanLyNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTim = new System.Windows.Forms.GroupBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbCCCD = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTim.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTim
            // 
            this.gbTim.Controls.Add(this.btSua);
            this.gbTim.Controls.Add(this.btXoa);
            this.gbTim.Controls.Add(this.btThem);
            this.gbTim.Controls.Add(this.label7);
            this.gbTim.Controls.Add(this.dtpNgaySinh);
            this.gbTim.Controls.Add(this.cbGioiTinh);
            this.gbTim.Controls.Add(this.tbSDT);
            this.gbTim.Controls.Add(this.label6);
            this.gbTim.Controls.Add(this.label5);
            this.gbTim.Controls.Add(this.label3);
            this.gbTim.Controls.Add(this.tbHoTen);
            this.gbTim.Controls.Add(this.tbCCCD);
            this.gbTim.Controls.Add(this.tbMa);
            this.gbTim.Controls.Add(this.label2);
            this.gbTim.Controls.Add(this.label1);
            this.gbTim.Controls.Add(this.btTim);
            this.gbTim.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTim.Location = new System.Drawing.Point(3, 3);
            this.gbTim.Name = "gbTim";
            this.gbTim.Size = new System.Drawing.Size(715, 169);
            this.gbTim.TabIndex = 1;
            this.gbTim.TabStop = false;
            this.gbTim.Text = "Thông tin nhân viên";
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(570, 132);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(125, 35);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = false;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btXoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(570, 92);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(125, 35);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btThem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(570, 52);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(125, 35);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "Thêm";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(109, 119);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 27);
            this.dtpNgaySinh.TabIndex = 14;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(334, 53);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(170, 27);
            this.cbGioiTinh.TabIndex = 13;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(109, 86);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(150, 27);
            this.tbSDT.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(265, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "CCCD:";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(334, 20);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(170, 27);
            this.tbHoTen.TabIndex = 0;
            this.tbHoTen.TextChanged += new System.EventHandler(this.tbHoTen_TextChanged);
            // 
            // tbCCCD
            // 
            this.tbCCCD.Location = new System.Drawing.Point(109, 53);
            this.tbCCCD.Name = "tbCCCD";
            this.tbCCCD.Size = new System.Drawing.Size(150, 27);
            this.tbCCCD.TabIndex = 1;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(109, 20);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(150, 27);
            this.tbMa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(265, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btTim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTim.Image = global::Quanlynhahang.Properties.Resources.up;
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim.Location = new System.Drawing.Point(570, 12);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(125, 35);
            this.btTim.TabIndex = 0;
            this.btTim.Text = "Tìm kiếm";
            this.btTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Location = new System.Drawing.Point(3, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 325);
            this.panel1.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clHoTen,
            this.clNgaySinh,
            this.clGioiTinh,
            this.clCCCD,
            this.clSDT});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(715, 325);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // clMa
            // 
            this.clMa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMa.HeaderText = "Mã";
            this.clMa.MinimumWidth = 6;
            this.clMa.Name = "clMa";
            this.clMa.ReadOnly = true;
            // 
            // clHoTen
            // 
            this.clHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHoTen.HeaderText = "Họ tên";
            this.clHoTen.MinimumWidth = 6;
            this.clHoTen.Name = "clHoTen";
            this.clHoTen.ReadOnly = true;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNgaySinh.HeaderText = "Ngày Sinh";
            this.clNgaySinh.MinimumWidth = 6;
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.ReadOnly = true;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clGioiTinh.HeaderText = "Giới Tính";
            this.clGioiTinh.MinimumWidth = 6;
            this.clGioiTinh.Name = "clGioiTinh";
            // 
            // clCCCD
            // 
            this.clCCCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clCCCD.HeaderText = "CCCD";
            this.clCCCD.MinimumWidth = 6;
            this.clCCCD.Name = "clCCCD";
            this.clCCCD.ReadOnly = true;
            // 
            // clSDT
            // 
            this.clSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSDT.HeaderText = "SĐT";
            this.clSDT.MinimumWidth = 6;
            this.clSDT.Name = "clSDT";
            this.clSDT.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(267, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách nhân viên";
            // 
            // ucQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTim);
            this.Name = "ucQuanLyNhanVien";
            this.Size = new System.Drawing.Size(721, 529);
            this.Load += new System.EventHandler(this.ucQuanLyNhanVien_Load);
            this.gbTim.ResumeLayout(false);
            this.gbTim.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTim;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCCCD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
    }
}

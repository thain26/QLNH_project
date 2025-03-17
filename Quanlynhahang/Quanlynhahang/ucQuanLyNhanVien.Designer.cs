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
            this.btKhoiTao = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTim.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTim
            // 
            this.gbTim.Controls.Add(this.btKhoiTao);
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
            this.gbTim.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbTim.Location = new System.Drawing.Point(3, 3);
            this.gbTim.Name = "gbTim";
            this.gbTim.Size = new System.Drawing.Size(715, 169);
            this.gbTim.TabIndex = 1;
            this.gbTim.TabStop = false;
            this.gbTim.Text = "Thông tin nhân viên";
            this.gbTim.Enter += new System.EventHandler(this.gbTim_Enter);
            // 
            // btKhoiTao
            // 
            this.btKhoiTao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btKhoiTao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btKhoiTao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btKhoiTao.Location = new System.Drawing.Point(574, 12);
            this.btKhoiTao.Name = "btKhoiTao";
            this.btKhoiTao.Size = new System.Drawing.Size(125, 35);
            this.btKhoiTao.TabIndex = 19;
            this.btKhoiTao.Text = "Khởi tạo";
            this.btKhoiTao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btKhoiTao.UseVisualStyleBackColor = false;
            this.btKhoiTao.Click += new System.EventHandler(this.btKhoiTao_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(574, 133);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(125, 35);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btXoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(574, 93);
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
            this.btThem.Location = new System.Drawing.Point(574, 53);
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
            this.dtpNgaySinh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(109, 119);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 25);
            this.dtpNgaySinh.TabIndex = 14;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(334, 53);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(170, 25);
            this.cbGioiTinh.TabIndex = 13;
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSDT.Location = new System.Drawing.Point(109, 86);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(150, 25);
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
            this.tbHoTen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbHoTen.Location = new System.Drawing.Point(334, 20);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(170, 25);
            this.tbHoTen.TabIndex = 0;
            // 
            // tbCCCD
            // 
            this.tbCCCD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbCCCD.Location = new System.Drawing.Point(109, 53);
            this.tbCCCD.Name = "tbCCCD";
            this.tbCCCD.Size = new System.Drawing.Size(150, 25);
            this.tbCCCD.TabIndex = 1;
            // 
            // tbMa
            // 
            this.tbMa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMa.Location = new System.Drawing.Point(109, 20);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(150, 25);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(3, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 325);
            this.panel1.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(715, 325);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
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
        private System.Windows.Forms.Button btKhoiTao;
    }
}

namespace Quanlynhahang
{
    partial class fGioHang
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
            this.lvThongTinHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbTienMat = new System.Windows.Forms.RadioButton();
            this.rbInternetBanking = new System.Windows.Forms.RadioButton();
            this.rbTheTinDung = new System.Windows.Forms.RadioButton();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThemMon = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lvThongTinHoaDon
            // 
            this.lvThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvThongTinHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvThongTinHoaDon.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvThongTinHoaDon.HideSelection = false;
            this.lvThongTinHoaDon.Location = new System.Drawing.Point(3, 23);
            this.lvThongTinHoaDon.Name = "lvThongTinHoaDon";
            this.lvThongTinHoaDon.Size = new System.Drawing.Size(404, 477);
            this.lvThongTinHoaDon.TabIndex = 0;
            this.lvThongTinHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvThongTinHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvThongTinHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(460, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 503);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // btThanhToan
            // 
            this.btThanhToan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThanhToan.Location = new System.Drawing.Point(13, 465);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(439, 50);
            this.btThanhToan.TabIndex = 2;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(10, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phương thức thanh toán:";
            // 
            // rbTienMat
            // 
            this.rbTienMat.AutoSize = true;
            this.rbTienMat.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbTienMat.Location = new System.Drawing.Point(13, 439);
            this.rbTienMat.Name = "rbTienMat";
            this.rbTienMat.Size = new System.Drawing.Size(78, 20);
            this.rbTienMat.TabIndex = 4;
            this.rbTienMat.TabStop = true;
            this.rbTienMat.Text = "Tiền mặt";
            this.rbTienMat.UseVisualStyleBackColor = true;
            // 
            // rbInternetBanking
            // 
            this.rbInternetBanking.AutoSize = true;
            this.rbInternetBanking.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbInternetBanking.Location = new System.Drawing.Point(167, 439);
            this.rbInternetBanking.Name = "rbInternetBanking";
            this.rbInternetBanking.Size = new System.Drawing.Size(122, 20);
            this.rbInternetBanking.TabIndex = 5;
            this.rbInternetBanking.TabStop = true;
            this.rbInternetBanking.Text = "Internet Banking";
            this.rbInternetBanking.UseVisualStyleBackColor = true;
            // 
            // rbTheTinDung
            // 
            this.rbTheTinDung.AutoSize = true;
            this.rbTheTinDung.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbTheTinDung.Location = new System.Drawing.Point(337, 439);
            this.rbTheTinDung.Name = "rbTheTinDung";
            this.rbTheTinDung.Size = new System.Drawing.Size(99, 20);
            this.rbTheTinDung.TabIndex = 6;
            this.rbTheTinDung.TabStop = true;
            this.rbTheTinDung.Text = "Thẻ tín dụng";
            this.rbTheTinDung.UseVisualStyleBackColor = true;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTien.Location = new System.Drawing.Point(665, 522);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(81, 19);
            this.lbTongTien.TabIndex = 7;
            this.lbTongTien.Text = "Tổng tiền:";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTongTien.Location = new System.Drawing.Point(752, 514);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(115, 27);
            this.tbTongTien.TabIndex = 8;
            this.tbTongTien.Text = "0";
            this.tbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(6, 62);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(433, 25);
            this.cbDanhMuc.TabIndex = 9;
            this.cbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbDanhMuc_SelectedIndexChanged);
            // 
            // cbMonAn
            // 
            this.cbMonAn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(7, 130);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(432, 25);
            this.cbMonAn.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Danh mục:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Món ăn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThemMon);
            this.groupBox2.Controls.Add(this.nudSoLuong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbDanhMuc);
            this.groupBox2.Controls.Add(this.cbMonAn);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 248);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn món ăn";
            // 
            // btThemMon
            // 
            this.btThemMon.AutoSize = true;
            this.btThemMon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThemMon.Location = new System.Drawing.Point(330, 185);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(100, 50);
            this.btThemMon.TabIndex = 15;
            this.btThemMon.Text = "Thêm món";
            this.btThemMon.UseVisualStyleBackColor = true;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoLuong.Location = new System.Drawing.Point(86, 185);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(49, 27);
            this.nudSoLuong.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(7, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số lượng:";
            // 
            // fGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbTienMat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rbInternetBanking);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.rbTheTinDung);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.groupBox1);
            this.Name = "fGioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ hàng";
            this.Load += new System.EventHandler(this.fGioHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvThongTinHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTienMat;
        private System.Windows.Forms.RadioButton rbInternetBanking;
        private System.Windows.Forms.RadioButton rbTheTinDung;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label4;
    }
}
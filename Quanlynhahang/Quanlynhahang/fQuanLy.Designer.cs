namespace Quanlynhahang
{
    partial class fQuanLy
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
            this.btQuanLyBan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMonAn = new System.Windows.Forms.Button();
            this.btDoanhThu = new System.Windows.Forms.Button();
            this.btQuanLyNhanVien = new System.Windows.Forms.Button();
            this.pnShow = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btQuanLyBan
            // 
            this.btQuanLyBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btQuanLyBan.Location = new System.Drawing.Point(5, 3);
            this.btQuanLyBan.Name = "btQuanLyBan";
            this.btQuanLyBan.Size = new System.Drawing.Size(121, 102);
            this.btQuanLyBan.TabIndex = 2;
            this.btQuanLyBan.Text = "Quản lý bàn";
            this.btQuanLyBan.UseVisualStyleBackColor = false;
            this.btQuanLyBan.Click += new System.EventHandler(this.btQuanLyBan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btMonAn);
            this.panel1.Controls.Add(this.btDoanhThu);
            this.panel1.Controls.Add(this.btQuanLyNhanVien);
            this.panel1.Controls.Add(this.btQuanLyBan);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 529);
            this.panel1.TabIndex = 3;
            // 
            // btMonAn
            // 
            this.btMonAn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btMonAn.Location = new System.Drawing.Point(5, 219);
            this.btMonAn.Name = "btMonAn";
            this.btMonAn.Size = new System.Drawing.Size(121, 102);
            this.btMonAn.TabIndex = 6;
            this.btMonAn.Text = "Món ăn";
            this.btMonAn.UseVisualStyleBackColor = false;
            this.btMonAn.Click += new System.EventHandler(this.btMonAn_Click);
            // 
            // btDoanhThu
            // 
            this.btDoanhThu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDoanhThu.Location = new System.Drawing.Point(5, 327);
            this.btDoanhThu.Name = "btDoanhThu";
            this.btDoanhThu.Size = new System.Drawing.Size(121, 102);
            this.btDoanhThu.TabIndex = 4;
            this.btDoanhThu.Text = "Thống kê";
            this.btDoanhThu.UseVisualStyleBackColor = false;
            this.btDoanhThu.Click += new System.EventHandler(this.btDoanhThu_Click);
            // 
            // btQuanLyNhanVien
            // 
            this.btQuanLyNhanVien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btQuanLyNhanVien.Location = new System.Drawing.Point(5, 111);
            this.btQuanLyNhanVien.Name = "btQuanLyNhanVien";
            this.btQuanLyNhanVien.Size = new System.Drawing.Size(121, 102);
            this.btQuanLyNhanVien.TabIndex = 5;
            this.btQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btQuanLyNhanVien.Click += new System.EventHandler(this.btQuanLyNhanVien_Click);
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnShow.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnShow.Location = new System.Drawing.Point(149, 12);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(721, 529);
            this.pnShow.TabIndex = 6;
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "fQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btQuanLyBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDoanhThu;
        private System.Windows.Forms.Button btQuanLyNhanVien;
        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Button btMonAn;
    }
}
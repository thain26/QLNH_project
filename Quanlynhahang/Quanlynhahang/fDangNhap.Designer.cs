namespace Quanlynhahang
{
    partial class fDangNhap
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
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbQuanLy = new System.Windows.Forms.RadioButton();
            this.rbNhanVien = new System.Windows.Forms.RadioButton();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTaiKhoan = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbTaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTaiKhoan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbTaiKhoan.Location = new System.Drawing.Point(183, 120);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(189, 30);
            this.tbTaiKhoan.TabIndex = 0;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMatKhau.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbMatKhau.Location = new System.Drawing.Point(183, 167);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(189, 30);
            this.tbMatKhau.TabIndex = 0;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà Hàng";
            // 
            // rbQuanLy
            // 
            this.rbQuanLy.AutoSize = true;
            this.rbQuanLy.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbQuanLy.Location = new System.Drawing.Point(131, 213);
            this.rbQuanLy.Name = "rbQuanLy";
            this.rbQuanLy.Size = new System.Drawing.Size(81, 20);
            this.rbQuanLy.TabIndex = 1;
            this.rbQuanLy.TabStop = true;
            this.rbQuanLy.Text = "Quản lý ";
            this.rbQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.AutoSize = true;
            this.rbNhanVien.Font = new System.Drawing.Font("Arial", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNhanVien.Location = new System.Drawing.Point(267, 213);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Size = new System.Drawing.Size(92, 20);
            this.rbNhanVien.TabIndex = 1;
            this.rbNhanVien.TabStop = true;
            this.rbNhanVien.Text = "Nhân viên";
            this.rbNhanVien.UseVisualStyleBackColor = true;
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.btDangNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDangNhap.Location = new System.Drawing.Point(195, 258);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(106, 40);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 402);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 47);
            this.label4.TabIndex = 5;
            this.label4.Text = "4 Con Sâu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lbTaiKhoan);
            this.panel2.Controls.Add(this.lbMatKhau);
            this.panel2.Controls.Add(this.tbTaiKhoan);
            this.panel2.Controls.Add(this.tbMatKhau);
            this.panel2.Controls.Add(this.rbQuanLy);
            this.panel2.Controls.Add(this.btDangNhap);
            this.panel2.Controls.Add(this.rbNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(318, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 402);
            this.panel2.TabIndex = 12;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTaiKhoan.Location = new System.Drawing.Point(65, 120);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(91, 19);
            this.lbTaiKhoan.TabIndex = 10;
            this.lbTaiKhoan.Text = "Tài khoản:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMatKhau.Location = new System.Drawing.Point(66, 167);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(86, 19);
            this.lbMatKhau.TabIndex = 11;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // fDangNhap
            // 
            this.AcceptButton = this.btDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(786, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaximizeBox = false;
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbQuanLy;
        private System.Windows.Forms.RadioButton rbNhanVien;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTaiKhoan;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Panel panel2;
    }
}


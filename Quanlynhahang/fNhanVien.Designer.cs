namespace Quanlynhahang
{
    partial class fNhanVien
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
            this.pnShow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThongKe = new System.Windows.Forms.Button();
            this.btQuanLyBan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnShow.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnShow.Location = new System.Drawing.Point(147, 12);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(721, 529);
            this.pnShow.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btThongKe);
            this.panel1.Controls.Add(this.btQuanLyBan);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 529);
            this.panel1.TabIndex = 7;
            // 
            // btThongKe
            // 
            this.btThongKe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btThongKe.Location = new System.Drawing.Point(3, 111);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(121, 102);
            this.btThongKe.TabIndex = 4;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = false;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // btQuanLyBan
            // 
            this.btQuanLyBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btQuanLyBan.Location = new System.Drawing.Point(3, 3);
            this.btQuanLyBan.Name = "btQuanLyBan";
            this.btQuanLyBan.Size = new System.Drawing.Size(121, 102);
            this.btQuanLyBan.TabIndex = 2;
            this.btQuanLyBan.Text = "Quản lý bàn";
            this.btQuanLyBan.UseVisualStyleBackColor = false;
            this.btQuanLyBan.Click += new System.EventHandler(this.btQuanLyBan_Click);
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "fNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.Button btQuanLyBan;
    }
}
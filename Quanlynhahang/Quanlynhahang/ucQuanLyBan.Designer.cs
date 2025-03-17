namespace Quanlynhahang
{
    partial class ucQuanLyBan
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
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btTrong = new System.Windows.Forms.Button();
            this.btDangPhucVu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flpBan.Location = new System.Drawing.Point(3, 3);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(609, 523);
            this.flpBan.TabIndex = 3;
            // 
            // btTrong
            // 
            this.btTrong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btTrong.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTrong.Location = new System.Drawing.Point(618, 3);
            this.btTrong.Name = "btTrong";
            this.btTrong.Size = new System.Drawing.Size(100, 60);
            this.btTrong.TabIndex = 4;
            this.btTrong.Text = "Trống";
            this.btTrong.UseVisualStyleBackColor = false;
            this.btTrong.Click += new System.EventHandler(this.btTrong_Click);
            // 
            // btDangPhucVu
            // 
            this.btDangPhucVu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDangPhucVu.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDangPhucVu.Location = new System.Drawing.Point(618, 69);
            this.btDangPhucVu.Name = "btDangPhucVu";
            this.btDangPhucVu.Size = new System.Drawing.Size(100, 60);
            this.btDangPhucVu.TabIndex = 5;
            this.btDangPhucVu.Text = "Đang phục vụ";
            this.btDangPhucVu.UseVisualStyleBackColor = false;
            this.btDangPhucVu.Click += new System.EventHandler(this.btDangPhucVu_Click);
            // 
            // ucQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btDangPhucVu);
            this.Controls.Add(this.btTrong);
            this.Controls.Add(this.flpBan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ucQuanLyBan";
            this.Size = new System.Drawing.Size(721, 529);
            this.Load += new System.EventHandler(this.ucQuanLyBan_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Button btTrong;
        private System.Windows.Forms.Button btDangPhucVu;
    }
}

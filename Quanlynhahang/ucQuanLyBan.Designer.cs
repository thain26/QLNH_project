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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuanLyBan));
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btTrong = new System.Windows.Forms.Button();
            this.btDangPhucVu = new System.Windows.Forms.Button();
            this.btChuyenBan = new System.Windows.Forms.Button();
            this.btGhepBan = new System.Windows.Forms.Button();
            this.cmsCaiDat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbCaiDat = new System.Windows.Forms.PictureBox();
            this.cmsCaiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaiDat)).BeginInit();
            this.SuspendLayout();
            // 
            // flpBan
            // 
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
            // 
            // btChuyenBan
            // 
            this.btChuyenBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btChuyenBan.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btChuyenBan.Location = new System.Drawing.Point(618, 364);
            this.btChuyenBan.Name = "btChuyenBan";
            this.btChuyenBan.Size = new System.Drawing.Size(100, 60);
            this.btChuyenBan.TabIndex = 6;
            this.btChuyenBan.Text = "Chuyển bàn";
            this.btChuyenBan.UseVisualStyleBackColor = false;
            // 
            // btGhepBan
            // 
            this.btGhepBan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btGhepBan.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btGhepBan.Location = new System.Drawing.Point(618, 430);
            this.btGhepBan.Name = "btGhepBan";
            this.btGhepBan.Size = new System.Drawing.Size(100, 60);
            this.btGhepBan.TabIndex = 7;
            this.btGhepBan.Text = "Ghép Bàn";
            this.btGhepBan.UseVisualStyleBackColor = false;
            // 
            // cmsCaiDat
            // 
            this.cmsCaiDat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsCaiDat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCaiDat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBànToolStripMenuItem,
            this.xóaBànToolStripMenuItem});
            this.cmsCaiDat.Name = "cmsCaiDat";
            this.cmsCaiDat.Size = new System.Drawing.Size(158, 60);
            // 
            // thêmBànToolStripMenuItem
            // 
            this.thêmBànToolStripMenuItem.Name = "thêmBànToolStripMenuItem";
            this.thêmBànToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.thêmBànToolStripMenuItem.Text = "Thêm bàn";
            // 
            // xóaBànToolStripMenuItem
            // 
            this.xóaBànToolStripMenuItem.Name = "xóaBànToolStripMenuItem";
            this.xóaBànToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.xóaBànToolStripMenuItem.Text = "Xóa bàn";
            // 
            // pbCaiDat
            // 
            this.pbCaiDat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbCaiDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("pbCaiDat.Image")));
            this.pbCaiDat.InitialImage = null;
            this.pbCaiDat.Location = new System.Drawing.Point(688, 496);
            this.pbCaiDat.Name = "pbCaiDat";
            this.pbCaiDat.Size = new System.Drawing.Size(30, 30);
            this.pbCaiDat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaiDat.TabIndex = 11;
            this.pbCaiDat.TabStop = false;
            this.pbCaiDat.Click += new System.EventHandler(this.pbCaiDat_Click);
            // 
            // ucQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.pbCaiDat);
            this.Controls.Add(this.btGhepBan);
            this.Controls.Add(this.btChuyenBan);
            this.Controls.Add(this.btDangPhucVu);
            this.Controls.Add(this.btTrong);
            this.Controls.Add(this.flpBan);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ucQuanLyBan";
            this.Size = new System.Drawing.Size(721, 529);
            this.cmsCaiDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCaiDat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Button btTrong;
        private System.Windows.Forms.Button btDangPhucVu;
        private System.Windows.Forms.Button btChuyenBan;
        private System.Windows.Forms.Button btGhepBan;
        private System.Windows.Forms.ContextMenuStrip cmsCaiDat;
        private System.Windows.Forms.ToolStripMenuItem thêmBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaBànToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbCaiDat;
    }
}

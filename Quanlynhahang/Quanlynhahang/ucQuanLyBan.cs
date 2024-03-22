using Quanlynhahang.DAL;
using Quanlynhahang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhahang
{
    public partial class ucQuanLyBan : UserControl
    {
        public ucQuanLyBan()
        {
            InitializeComponent();
        }

        void LoadTable(string state = null)
        {

            flpBan.Controls.Clear();
            List<Ban> dsBan = BanDAL.Instance.LoadTableList();

            foreach (Ban ban in dsBan)
            {
                Button bt = new Button() { Width = BanDAL.Width, Height = BanDAL.Height };
                bt.Text = ban.Name + "\n" + ban.Status;
                bt.Click += bt_Click;
                bt.Tag = ban;

                switch (ban.Status)
                {
                    case "Đang phục vụ":
                        bt.BackColor = Color.MistyRose;
                        break;
                        
                    default:
                        bt.BackColor = Color.Lavender;
                        break;
                }
                if (state == null)
                    flpBan.Controls.Add(bt);
                else if (state == ban.Status)
                    flpBan.Controls.Add(bt);
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            int idBan = ((sender as Button).Tag as Ban).Id;
            fGioHang f = new fGioHang(idBan);
            f.ShowDialog();
            LoadTable();
        }
        
        private void btTrong_Click(object sender, EventArgs e)
        {
            flpBan.Controls.Clear();
            LoadTable("Trống");
        }
        private void btDangPhucVu_Click(object sender, EventArgs e)
        {
            flpBan.Controls.Clear();
            LoadTable("Đang phục vụ");
        }
        private void pbCaiDat_Click(object sender, EventArgs e)
        {
            ucMonAn ucMonAn = new ucMonAn();
            cmsCaiDat.Show(930, 560);
        }

        private void thêmBànToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btMangVe_Click(object sender, EventArgs e)
        {
            fGioHang f = new fGioHang();
            f.ShowDialog();
        }

        private void ucQuanLyBan_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}

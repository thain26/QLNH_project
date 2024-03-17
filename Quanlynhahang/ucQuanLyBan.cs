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

            LoadTable();
        }

        void LoadTable()
        {
            List<Ban> dsBan = BanDAL.Instance.LoadTableList();

            foreach (Ban ban in dsBan)
            {
                Button bt = new Button() { Width = BanDAL.Width, Height = BanDAL.Height };
                bt.Text = ban.Name + "\n" + ban.Status;
                flpBan.Controls.Add(bt);
            }
        }

        private void btTrong_Click(object sender, EventArgs e)
        {

        }

        private void pbCaiDat_Click(object sender, EventArgs e)
        {
            cmsCaiDat.Show(this, this.PointToClient(MousePosition));
        }


    }
}

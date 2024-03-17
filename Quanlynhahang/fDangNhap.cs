using Quanlynhahang.DAL;
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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        bool dangNhap(string tk, string mk, int loai )
        {
            return TaiKhoanDAL.Instance.dangNhap(tk, mk, loai);
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = tbTaiKhoan.Text, matKhau = tbMatKhau.Text;
            int loai = -1;

            if (rbQuanLy.Checked == true)
            {
                loai = 1;
                if (dangNhap(taiKhoan, matKhau, loai))
                {
                    this.Hide();
                    fQuanLy f = new fQuanLy();
                    f.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }

            else if (rbNhanVien.Checked == true)
            {
                loai = 0;
                if (dangNhap(taiKhoan, matKhau, loai))
                {
                    this.Hide();
                    fNhanVien f = new fNhanVien();
                    f.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }

            else MessageBox.Show("Chọn chức vụ!");
        }

    }
}

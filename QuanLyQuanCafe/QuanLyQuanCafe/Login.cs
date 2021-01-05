using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            txt_dangnhap.Select();
            txt_dangnhap.Text = "hung810";
            txt_matkhau.Text = "tuanhung123";
        }
 
        QuanLyQuanCafeEntities ef = new QuanLyQuanCafeEntities();

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (login())
            {
                
                FormTableManager f = new FormTableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
                txt_matkhau.Text = "";
                txt_dangnhap.Text = "";
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác.", "Lỗi");
                txt_dangnhap.Select();
            }

        }


        private bool login()
        {
            return ef.Accounts.Any(x => x.UserName == txt_dangnhap.Text && x.Password == txt_matkhau.Text);
        }
    }
}

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
    public partial class FormTableManager : Form
    {
        public FormTableManager()
        {
            InitializeComponent();
        }

        QuanLyQuanCafeEntities ef = new QuanLyQuanCafeEntities();

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountProfile f = new FormAccountProfile();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin f1 = new FormAdmin();
            this.Hide();
            f1.ShowDialog();
            this.Show();

        }
    }
}

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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            LoadFDsList();
        }

        QuanLyQuanCafeEntities ef = new QuanLyQuanCafeEntities();

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.LoadFDsList();
            this.AddFDBinding();
        }

        private void LoadFDsList()
        {
            this.dtgv_FD.DataSource = ef.FDs.ToList();
            this.dtgv_FD.Columns["id"].Visible = false;
            this.dtgv_FD.Columns["idCategory"].Visible = false;
            this.dtgv_FD.Columns["Category"].Visible = false;
            this.dtgv_FD.Columns["BillInfoes"].Visible = false;
            this.dtgv_FD.Columns[1].HeaderText = "Tên món";
            this.dtgv_FD.Columns[3].HeaderText = "Giá";
        }

        void AddFDBinding()
        {
            txt_id.DataBindings.Add(new Binding("Text", dtgv_FD.DataSource, "id"));
            txt_nameFD.DataBindings.Add(new Binding("Text", dtgv_FD.DataSource, "name"));
            txt_Price.DataBindings.Add(new Binding("Text", dtgv_FD.DataSource, "price"));
            textBox1.DataBindings.Add(new Binding("Text", dtgv_FD.DataSource, "idCategory"));

            int index;
            Int32.TryParse(textBox1.Text, out index);

            cb_Category.DataSource = ef.Categories.ToList();
            cb_Category.DisplayMember = "name";

            cb_Category.SelectedIndex = (index - 1);





        }
    }
}

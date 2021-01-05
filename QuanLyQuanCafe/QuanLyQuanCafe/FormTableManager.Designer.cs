namespace QuanLyQuanCafe
{
    partial class FormTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_Bill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nr_SwitchTable = new System.Windows.Forms.NumericUpDown();
            this.btn_SwitchTable = new System.Windows.Forms.Button();
            this.btn_Discount = new System.Windows.Forms.Button();
            this.nr_Discount = new System.Windows.Forms.NumericUpDown();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nr_nbFD = new System.Windows.Forms.NumericUpDown();
            this.btn_AddFD = new System.Windows.Forms.Button();
            this.cb_FD = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_SwitchTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_Discount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_nbFD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 24);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 468);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lv_Bill);
            this.panel2.Location = new System.Drawing.Point(481, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 304);
            this.panel2.TabIndex = 2;
            // 
            // lv_Bill
            // 
            this.lv_Bill.HideSelection = false;
            this.lv_Bill.Location = new System.Drawing.Point(3, 3);
            this.lv_Bill.Name = "lv_Bill";
            this.lv_Bill.Size = new System.Drawing.Size(293, 298);
            this.lv_Bill.TabIndex = 0;
            this.lv_Bill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nr_SwitchTable);
            this.panel3.Controls.Add(this.btn_SwitchTable);
            this.panel3.Controls.Add(this.btn_Discount);
            this.panel3.Controls.Add(this.nr_Discount);
            this.panel3.Controls.Add(this.btn_Pay);
            this.panel3.Location = new System.Drawing.Point(481, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 69);
            this.panel3.TabIndex = 3;
            // 
            // nr_SwitchTable
            // 
            this.nr_SwitchTable.Location = new System.Drawing.Point(3, 44);
            this.nr_SwitchTable.Name = "nr_SwitchTable";
            this.nr_SwitchTable.Size = new System.Drawing.Size(53, 22);
            this.nr_SwitchTable.TabIndex = 6;
            // 
            // btn_SwitchTable
            // 
            this.btn_SwitchTable.Location = new System.Drawing.Point(3, 3);
            this.btn_SwitchTable.Name = "btn_SwitchTable";
            this.btn_SwitchTable.Size = new System.Drawing.Size(99, 35);
            this.btn_SwitchTable.TabIndex = 5;
            this.btn_SwitchTable.Text = "Chuyển bàn";
            this.btn_SwitchTable.UseVisualStyleBackColor = true;
            // 
            // btn_Discount
            // 
            this.btn_Discount.Location = new System.Drawing.Point(108, 3);
            this.btn_Discount.Name = "btn_Discount";
            this.btn_Discount.Size = new System.Drawing.Size(75, 35);
            this.btn_Discount.TabIndex = 4;
            this.btn_Discount.Text = "Giảm giá";
            this.btn_Discount.UseVisualStyleBackColor = true;
            // 
            // nr_Discount
            // 
            this.nr_Discount.Location = new System.Drawing.Point(108, 44);
            this.nr_Discount.Name = "nr_Discount";
            this.nr_Discount.Size = new System.Drawing.Size(75, 22);
            this.nr_Discount.TabIndex = 4;
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(189, 3);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(107, 63);
            this.btn_Pay.TabIndex = 3;
            this.btn_Pay.Text = "Thanh toán";
            this.btn_Pay.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nr_nbFD);
            this.panel4.Controls.Add(this.btn_AddFD);
            this.panel4.Controls.Add(this.cb_FD);
            this.panel4.Controls.Add(this.cb_Category);
            this.panel4.Location = new System.Drawing.Point(481, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 83);
            this.panel4.TabIndex = 3;
            // 
            // nr_nbFD
            // 
            this.nr_nbFD.Location = new System.Drawing.Point(249, 30);
            this.nr_nbFD.Name = "nr_nbFD";
            this.nr_nbFD.Size = new System.Drawing.Size(46, 22);
            this.nr_nbFD.TabIndex = 3;
            this.nr_nbFD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_AddFD
            // 
            this.btn_AddFD.Location = new System.Drawing.Point(156, 13);
            this.btn_AddFD.Name = "btn_AddFD";
            this.btn_AddFD.Size = new System.Drawing.Size(87, 54);
            this.btn_AddFD.TabIndex = 2;
            this.btn_AddFD.Text = "Thêm";
            this.btn_AddFD.UseVisualStyleBackColor = true;
            // 
            // cb_FD
            // 
            this.cb_FD.FormattingEnabled = true;
            this.cb_FD.Location = new System.Drawing.Point(0, 43);
            this.cb_FD.Name = "cb_FD";
            this.cb_FD.Size = new System.Drawing.Size(150, 24);
            this.cb_FD.TabIndex = 1;
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(0, 13);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(150, 24);
            this.cb_Category.TabIndex = 0;
            // 
            // FormTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 511);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quản Cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nr_SwitchTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_Discount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nr_nbFD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lv_Bill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nr_nbFD;
        private System.Windows.Forms.Button btn_AddFD;
        private System.Windows.Forms.ComboBox cb_FD;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.NumericUpDown nr_Discount;
        private System.Windows.Forms.Button btn_Discount;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.NumericUpDown nr_SwitchTable;
        private System.Windows.Forms.Button btn_SwitchTable;
    }
}
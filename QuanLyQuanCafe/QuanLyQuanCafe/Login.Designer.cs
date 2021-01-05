namespace QuanLyQuanCafe
{
    partial class FormDangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_dangnhap = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_tendangnhap = new System.Windows.Forms.Label();
            this.lb_Login = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_matkhau);
            this.panel1.Controls.Add(this.txt_dangnhap);
            this.panel1.Controls.Add(this.btn_dangnhap);
            this.panel1.Controls.Add(this.lb_password);
            this.panel1.Controls.Add(this.lb_tendangnhap);
            this.panel1.Controls.Add(this.lb_Login);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 247);
            this.panel1.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(165, 122);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(223, 22);
            this.txt_matkhau.TabIndex = 8;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // txt_dangnhap
            // 
            this.txt_dangnhap.Location = new System.Drawing.Point(165, 69);
            this.txt_dangnhap.Name = "txt_dangnhap";
            this.txt_dangnhap.Size = new System.Drawing.Size(223, 22);
            this.txt_dangnhap.TabIndex = 7;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.Location = new System.Drawing.Point(165, 176);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(133, 38);
            this.btn_dangnhap.TabIndex = 6;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(18, 122);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(77, 20);
            this.lb_password.TabIndex = 5;
            this.lb_password.Text = "Mật khẩu";
            // 
            // lb_tendangnhap
            // 
            this.lb_tendangnhap.AutoSize = true;
            this.lb_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tendangnhap.Location = new System.Drawing.Point(18, 69);
            this.lb_tendangnhap.Name = "lb_tendangnhap";
            this.lb_tendangnhap.Size = new System.Drawing.Size(119, 20);
            this.lb_tendangnhap.TabIndex = 4;
            this.lb_tendangnhap.Text = "Tên đăng nhập";
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.Location = new System.Drawing.Point(144, 10);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(138, 29);
            this.lb_Login.TabIndex = 3;
            this.lb_Login.Text = "Đăng nhập";
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.btn_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 271);
            this.Controls.Add(this.panel1);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Quán Cafe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_dangnhap;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_tendangnhap;
        private System.Windows.Forms.Label lb_Login;
    }
}


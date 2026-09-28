namespace C5_Cau1_GiaoDoAn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            txtXacNhanMK = new TextBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký tài khoản mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(214, 20);
            label2.TabIndex = 1;
            label2.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 102);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 148);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 194);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 252);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 304);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 6;
            label7.Text = "Xác thực mật khẩu";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = SystemColors.Highlight;
            btnDangKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = SystemColors.ActiveCaptionText;
            btnDangKy.Location = new Point(308, 350);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 36);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click_1;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ControlDark;
            btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(421, 350);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 36);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click_1;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(267, 297);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(431, 27);
            txtXacNhanMK.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(267, 245);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(431, 27);
            txtMatKhau.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(267, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(431, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(267, 141);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(431, 27);
            txtSDT.TabIndex = 16;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(267, 95);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(431, 27);
            txtHoTen.TabIndex = 17;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtHoTen);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtMatKhau);
            Controls.Add(txtXacNhanMK);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đăng ký tài khoản";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDangKy;
        private Button btnHuy;
        private TextBox txtXacNhanMK;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private ErrorProvider errorProvider1;
    }
}

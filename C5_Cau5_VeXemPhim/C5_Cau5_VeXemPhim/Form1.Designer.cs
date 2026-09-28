namespace C5_Cau5_VeXemPhim
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            txtTenKhach = new TextBox();
            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();
            txtGheDaChon = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 22);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 88);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 167);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Xuất chiếu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 252);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "Ghế đã chọn";
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(144, 378);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(94, 29);
            btnChonGhe.TabIndex = 4;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(287, 378);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(94, 29);
            btnDatVe.TabIndex = 5;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(427, 378);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(64, 45);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(457, 27);
            txtTenKhach.TabIndex = 7;
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Items.AddRange(new object[] { "Avengers", "Doraemon", "Conan" });
            cboPhim.Location = new Point(64, 121);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(457, 28);
            cboPhim.TabIndex = 8;
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Items.AddRange(new object[] { "09:00           ", "13:00  ", "19:00" });
            cboSuatChieu.Location = new Point(64, 199);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(457, 28);
            cboSuatChieu.TabIndex = 9;
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(64, 287);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(457, 27);
            txtGheDaChon.TabIndex = 10;
            txtGheDaChon.ReadOnlyChanged += textBox2_ReadOnlyChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGheDaChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(txtTenKhach);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
        private TextBox txtTenKhach;
        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;
        private TextBox txtGheDaChon;
    }
}

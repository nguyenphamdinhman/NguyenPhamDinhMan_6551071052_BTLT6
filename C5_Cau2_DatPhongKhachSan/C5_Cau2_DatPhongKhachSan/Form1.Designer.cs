namespace C5_Cau2_DatPhongKhachSan
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
            btnDatPhong = new Button();
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 72);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Số CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 134);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày nhận phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 196);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày trả phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 257);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 4;
            label5.Text = "Số người lớn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 310);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Số trẻ em";
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.CornflowerBlue;
            btnDatPhong.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatPhong.Location = new Point(94, 366);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(574, 57);
            btnDatPhong.TabIndex = 6;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(96, 42);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(574, 27);
            txtHoTen.TabIndex = 7;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(96, 95);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(574, 27);
            txtCCCD.TabIndex = 8;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(96, 157);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(574, 27);
            txtNgayNhan.TabIndex = 9;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(96, 219);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(574, 27);
            txtNgayTra.TabIndex = 10;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(96, 280);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(574, 27);
            txtSoNguoiLon.TabIndex = 11;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(96, 333);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(574, 27);
            txtSoTreEm.TabIndex = 12;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Controls.Add(btnDatPhong);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Đặt phòng khách sạn";
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
        private Button btnDatPhong;
        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private TextBox txtNgayNhan;
        private TextBox txtNgayTra;
        private TextBox txtSoNguoiLon;
        private TextBox txtSoTreEm;
        private ErrorProvider errorProvider1;
    }
}

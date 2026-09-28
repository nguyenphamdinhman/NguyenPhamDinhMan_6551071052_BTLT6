namespace C5_Cau3_NhapDiemHocSinh
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
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            lstDanhSach = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 37);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 37);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 37);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 3;
            label4.Text = "Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(678, 37);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 4;
            label5.Text = "Anh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(33, 69);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(123, 27);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(162, 69);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(247, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(424, 69);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(99, 27);
            txtToan.TabIndex = 3;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(550, 69);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(99, 27);
            txtVan.TabIndex = 4;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(678, 69);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(99, 27);
            txtAnh.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Lime;
            btnLuu.Location = new Point(33, 118);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = SystemColors.ButtonShadow;
            btnXoaTrang.Location = new Point(148, 118);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 29);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(33, 175);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(744, 244);
            lstDanhSach.TabIndex = 12;
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
            Controls.Add(lstDanhSach);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox lstDanhSach;
        private ErrorProvider errorProvider1;
    }
}

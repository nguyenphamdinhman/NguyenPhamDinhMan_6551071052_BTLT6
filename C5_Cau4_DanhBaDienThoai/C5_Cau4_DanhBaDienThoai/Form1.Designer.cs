namespace C5_Cau4_DanhBaDienThoai
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
            lstLienHe = new ListBox();
            txtTen = new TextBox();
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSDT = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(12, 12);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(342, 424);
            lstLienHe.TabIndex = 0;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(401, 35);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(354, 27);
            txtTen.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(661, 171);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 12);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 72);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 5;
            label2.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(401, 95);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(354, 27);
            txtSDT.TabIndex = 4;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(661, 220);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(661, 270);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(661, 407);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(label2);
            Controls.Add(txtSDT);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Controls.Add(txtTen);
            Controls.Add(lstLienHe);
            Name = "Form1";
            Text = "Quản Lý Danh Bạ";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLienHe;
        private TextBox txtTen;
        private Button btnThem;
        private Label label1;
        private Label label2;
        private TextBox txtSDT;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}

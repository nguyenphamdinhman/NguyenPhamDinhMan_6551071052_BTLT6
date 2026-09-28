namespace C5_Cau5_VeXemPhim
{
    partial class FormChonGhe
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
            lstGhe = new ListBox();
            label1 = new Label();
            btnXacNhan = new Button();
            btnBoQua = new Button();
            lblGheDaChon = new Label();
            SuspendLayout();
            // 
            // lstGhe
            // 
            lstGhe.FormattingEnabled = true;
            lstGhe.Items.AddRange(new object[] { "A1", "", "A2", "", "A3", "", "A4", "", "A5", "", "B1", "", "B2", "", "B3", "", "B4", "", "B5", "", "C1", "", "C2", "", "C3", "", "C4", "", "C5" });
            lstGhe.Location = new Point(47, 24);
            lstGhe.Name = "lstGhe";
            lstGhe.Size = new Size(708, 164);
            lstGhe.TabIndex = 0;
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 216);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Đang chọn";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(362, 303);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(494, 303);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 29);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(132, 216);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(0, 20);
            lblGheDaChon.TabIndex = 4;
            // 
            // FormChonGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGheDaChon);
            Controls.Add(btnBoQua);
            Controls.Add(btnXacNhan);
            Controls.Add(label1);
            Controls.Add(lstGhe);
            Name = "FormChonGhe";
            Text = "FormChonGhe";
            Load += FormChonGhe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGhe;
        private Label label1;
        private Button btnXacNhan;
        private Button btnBoQua;
        private Label lblGheDaChon;
    }
}
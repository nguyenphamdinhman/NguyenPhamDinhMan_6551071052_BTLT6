namespace C5_Cau6_GhiChuCongViec
{
    partial class FormGhiChu
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
            components = new System.ComponentModel.Container();
            lblTieuDeForm = new Label();
            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            textBox3 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Location = new Point(316, 31);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(0, 20);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(246, 87);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(249, 27);
            txtTieuDe.TabIndex = 1;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(142, 126);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(473, 152);
            txtNoiDung.TabIndex = 2;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            txtNoiDung.MouseLeave += txtNoiDung_MouseLeave;
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "", "Trung bình", "", "Cao" });
            cboMucDoUuTien.Location = new Point(246, 332);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(249, 28);
            cboMucDoUuTien.TabIndex = 3;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new Point(303, 366);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(125, 49);
            btnLuuGhiChu.TabIndex = 4;
            btnLuuGhiChu.Text = "Lưu ghi chú";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click_1;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(246, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDeForm);
            Name = "FormGhiChu";
            Text = "FormGhiChu";
            Load += FormGhiChu_Load;
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private TextBox txtTieuDe;
        private TextBox txtNoiDung;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private TextBox textBox3;
        private ErrorProvider errorProvider1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C5_Cau6_GhiChuCongViec
{
    public partial class FormGhiChu : Form
    {
        private bool daThayDoi = false;
        public FormGhiChu()
        {
            InitializeComponent();

            this.KeyPreview = true;

            cboMucDoUuTien.SelectedIndex = 0;
        }

        private void FormGhiChu_Load(object sender, EventArgs e)
        {
           
        }

        private void txtTieuDe_Validating(
           object sender,
           System.ComponentModel.CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();
            if (string.IsNullOrEmpty(tieuDe))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề không được để trống");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (tieuDe.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtTieuDe,
                    "Tiêu đề tối đa 50 ký tự");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtTieuDe_Validated(
           object sender,
           EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;

            errorProvider1.SetError(txtTieuDe, "");
        }

        private void btnLuuGhiChu_Click(
            object sender,
            EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text.Trim();

            daThayDoi = false;

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void btnLuuGhiChu_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text.Trim();

            daThayDoi = false;

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;

                btnLuuGhiChu.PerformClick();
            }

            // ESC
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;

                if (daThayDoi)
                {
                    DialogResult result = MessageBox.Show(
                        "Nội dung ghi chú đã thay đổi. Bạn có muốn đóng không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            daThayDoi = true;
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightBlue;
        }

        private void txtNoiDung_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }
    }
}

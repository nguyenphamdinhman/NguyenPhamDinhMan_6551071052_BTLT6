namespace C5_Cau5_VeXemPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg =
               new FormChonGhe(txtGheDaChon.Text))
            {
                // ShowDialog() làm Form chính bị block
                DialogResult result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Nhận ghế từ Dialog
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên khách!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn phim!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cboPhim.Focus();
                return;
            }

            if (cboSuatChieu.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn suất chiếu!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cboSuatChieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn ghế!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string message =
                "ĐẶT VÉ THÀNH CÔNG!\n\n" +
                "Tên khách: " + txtTenKhach.Text + "\n" +
                "Phim: " + cboPhim.SelectedItem + "\n" +
                "Suất chiếu: " + cboSuatChieu.SelectedItem + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá vé: 75.000đ";

            MessageBox.Show(
                message,
                "Xác nhận đặt vé",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();

            txtTenKhach.Focus();
        }
    }
}

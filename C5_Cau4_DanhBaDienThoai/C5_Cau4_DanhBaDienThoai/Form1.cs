namespace C5_Cau4_DanhBaDienThoai
{
    public partial class Form1 : Form
    {
        private int _indexDangSua = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool coDuLieuChuaLuu =
               !string.IsNullOrWhiteSpace(txtTen.Text)
               ||
               !string.IsNullOrWhiteSpace(txtSDT.Text);

            if (!coDuLieuChuaLuu)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có dữ liệu chưa được lưu. " +
                "Bạn muốn thoát không?",
                "Cảnh báo",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
            }
            else if (result == DialogResult.No)
            {
                txtTen.Clear();
                txtSDT.Clear();

            }

            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show(
                    "Vui lòng nhập tên!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSDT.Focus();
                return;
            }

            string lienHe = ten + " - " + sdt;

            // =================================
            // ĐANG SỬA
            // =================================
            if (_indexDangSua != -1)
            {
                lstLienHe.Items[_indexDangSua] = lienHe;

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                _indexDangSua = -1;
            }

            else
            {
                lstLienHe.Items.Add(lienHe);

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            txtTen.Clear();
            txtSDT.Clear();

            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lấy item đang chọn
            string lienHe = lstLienHe.SelectedItem.ToString();

            // Lấy tên trước dấu " - "
            string ten = lienHe.Split('-')[0].Trim();

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " +
                ten +
                "? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Người dùng chọn Yes
            if (result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(
                    lstLienHe.SelectedIndex
                );

                MessageBox.Show(
                    "Xóa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            _indexDangSua = lstLienHe.SelectedIndex;

            string lienHe = lstLienHe.SelectedItem.ToString();

            string[] parts = lienHe.Split('-');

            txtTen.Text = parts[0].Trim();

            if (parts.Length > 1)
            {
                txtSDT.Text = parts[1].Trim();
            }

            txtTen.Focus();
        }
    }
}

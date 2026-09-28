using System.ComponentModel;
using System.Globalization;

namespace C5_Cau2_DatPhongKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtHoTen.Validating += txtHoTen_Validating;
            txtCCCD.Validating += txtCCCD_Validating;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoTreEm.Validating += txtSoTreEm_Validating;

            txtHoTen.Validated += TextBox_Validated;
            txtCCCD.Validated += TextBox_Validated;
            txtNgayNhan.Validated += TextBox_Validated;
            txtNgayTra.Validated += TextBox_Validated;
            txtSoNguoiLon.Validated += TextBox_Validated;
            txtSoTreEm.Validated += TextBox_Validated;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();

            if (cccd.Length != 12 || !long.TryParse(cccd, out _))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "CCCD phải gồm đúng 12 chữ số!");
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;

            bool hopLe = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            if (!hopLe)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nhận phải có dạng dd/MM/yyyy!"
                );
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayNhan,
                    "Ngày nhận phải từ hôm nay trở đi!"
                );
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            DateTime ngayTra;

            bool nhanHopLe = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            bool traHopLe = DateTime.TryParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayTra
            );

            if (!traHopLe)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải có dạng dd/MM/yyyy!"
                );
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else if (!nhanHopLe)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Vui lòng nhập ngày nhận hợp lệ trước!"
                );
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else if (ngayTra <= ngayNhan)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNgayTra,
                    "Ngày trả phải lớn hơn ngày nhận!"
                );
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNgayTra, "");
                txtNgayTra.BackColor = Color.Honeydew;
            }
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;

            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out soNguoiLon)
                || soNguoiLon < 1
                || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtSoNguoiLon,
                    "Số người lớn phải từ 1 đến 4!"
                );
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;

            if (!int.TryParse(txtSoTreEm.Text.Trim(), out soTreEm)
                || soTreEm < 0
                || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtSoTreEm,
                    "Số trẻ em phải từ 0 đến 3!"
                );
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        private void TextBox_Validated(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt != null)
            {
                txt.BackColor = Color.Honeydew;
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );

            DateTime ngayTra = DateTime.ParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture
            );

            int soDem = (ngayTra - ngayNhan).Days;

            int soNguoiLon = int.Parse(txtSoNguoiLon.Text);
            int soTreEm = int.Parse(txtSoTreEm.Text);

            string message =
                "ĐẶT PHÒNG THÀNH CÔNG!\n\n" +
                "Tên khách: " + txtHoTen.Text.Trim() + "\n" +
                "Số đêm: " + soDem + "\n" +
                "Số người lớn: " + soNguoiLon + "\n" +
                "Số trẻ em: " + soTreEm;

            MessageBox.Show(
                message,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

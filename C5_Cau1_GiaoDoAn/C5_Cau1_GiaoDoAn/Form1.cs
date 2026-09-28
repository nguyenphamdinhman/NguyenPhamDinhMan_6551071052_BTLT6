namespace C5_Cau1_GiaoDoAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool KiemTraHopLe()
        {
            bool hopLe = true;
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                hopLe = false;
            }
            else if (hoTen.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên phải có ít nhất 3 ký tự!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }
            string sdt = txtSDT.Text.Trim();
            if (sdt.Length != 10 || !long.TryParse(sdt, out _) || !sdt.StartsWith("0"))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng 0!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }
            string email = txtEmail.Text.Trim();
            int viTriA = email.IndexOf("@");
            if (viTriA <= 0 || email.IndexOf(".", viTriA + 1) == -1)
            {
                errorProvider1.SetError(txtEmail, "Email phải chứa @ và có dấu . phía sau @!");
                hopLe = false;
            }
            else { errorProvider1.SetError(txtEmail, ""); }
            string matKhau = txtMatKhau.Text; if (matKhau.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có ít nhất 6 ký tự!");
                hopLe = false;
            }
            else { errorProvider1.SetError(txtMatKhau, ""); }
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(
                txtXacNhanMK, "Mật khẩu xác nhận không khớp!"); hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }
            if (txtXacNhanMK.Text != txtMatKhau.Text) { 
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp!"); 
                hopLe = false; } 
            else { 
                errorProvider1.SetError(txtXacNhanMK, ""); 
            }
            return hopLe;
        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) { return; }
            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear(); this.Close();
        }
    }
}

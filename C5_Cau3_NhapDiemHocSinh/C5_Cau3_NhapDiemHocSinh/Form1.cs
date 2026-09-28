namespace C5_Cau3_NhapDiemHocSinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DangKyEnterChuyenField();

            txtToan.Enter += txtDiem_Enter;
            txtVan.Enter += txtDiem_Enter;
            txtAnh.Enter += txtDiem_Enter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control control in GetAllControls(this))
            {
                if (control is TextBox txt)
                {
                    txt.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private System.Collections.Generic.IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;
                foreach (Control child in GetAllControls(control))
                {
                    yield return child;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                TextBox txt = sender as TextBox;
                if (txt == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true
                    );
                }
            }
        }

        private void txtDiem_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt != null)
            {
                txt.SelectAll();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool hopLe = true;

            decimal toan;
            decimal van;
            decimal anh;

            if (!decimal.TryParse(txtToan.Text, out toan)
                || toan < 0
                || toan > 10)
            {
                errorProvider1.SetError(
                    txtToan,
                    "Điểm Toán phải từ 0 đến 10!"
                );

                hopLe = false;
            }
            if (!decimal.TryParse(txtVan.Text, out van)
                || van < 0
                || van > 10)
            {
                errorProvider1.SetError(
                    txtVan,
                    "Điểm Văn phải từ 0 đến 10!"
                );

                hopLe = false;
            }
            if (!decimal.TryParse(txtAnh.Text, out anh)
                || anh < 0
                || anh > 10)
            {
                errorProvider1.SetError(
                    txtAnh,
                    "Điểm Anh phải từ 0 đến 10!"
                );

                hopLe = false;
            }
            if (!hopLe)
            {
                return;
            }

            string dong =
                txtMaHS.Text + " | " +
                txtHoTen.Text + " | " +
                "T:" + toan + " " +
                "V:" + van + " " +
                "A:" + anh;

            lstDanhSach.Items.Add(dong);

            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();

            txtMaHS.Focus();
        }
    }
}

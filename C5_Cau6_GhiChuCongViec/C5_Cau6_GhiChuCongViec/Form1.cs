namespace C5_Cau6_GhiChuCongViec
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
            CapNhatTrangThai();
        }

        private void FormChinh_DoubleClick(object sender, EventArgs e)
        {

        }

        private void mnuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu frm = new FormGhiChu();
            frm.MdiParent = this;

            frm.FormClosed += (s, args) =>
            {
                CapNhatTrangThai();
            };
            frm.Show();
            CapNhatTrangThai();
        }

        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuSapXepCuaSo_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void CapNhatTrangThai()
        {
            lblTrangThai.Text =
                "Số ghi chú đang mở: " + this.MdiChildren.Length;
        }
    }
}

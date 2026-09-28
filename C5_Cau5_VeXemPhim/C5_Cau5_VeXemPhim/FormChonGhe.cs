using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C5_Cau5_VeXemPhim
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }
        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            for (char hang = 'A'; hang <= 'C'; hang++)
            {
                for (int so = 1; so <= 5; so++)
                {
                    lstGhe.Items.Add(hang + so.ToString());
                }
            }

            if (!string.IsNullOrEmpty(gheHienTai))
            {
                int index = lstGhe.Items.IndexOf(gheHienTai);
                if (index >= 0)
                {
                    lstGhe.SelectedIndex = index;
                }
            }
        }

        private void FormChonGhe_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một ghế!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            GheChon = lstGhe.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text =
                    lstGhe.SelectedItem.ToString();
            }
            else
            {
                lblGheDaChon.Text =
                    "Đang chọn: Chưa chọn";
            }
        }
    }
}

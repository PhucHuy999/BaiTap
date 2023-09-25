using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            cboNganhHoc.Items.Add("Công nghệ thông tin");
            cboNganhHoc.Items.Add("Ngôn ngữ anh");
            cboNganhHoc.Items.Add("Quản trị kinh doanh");

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (txtMSSV.Text == null || txtMSSV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên.");
                return;
            }

            if (txtTenSV.Text == null || txtTenSV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên.");
                return;
            }

            if (cboNganhHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khoa.");
                return;
            }

            if (txtDiemTB.Text == null || txtDiemTB.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập điểm trung bình.");
                return;
            }

            // Đóng form
            DialogResult = DialogResult.OK;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiemTB_Validating(object sender, CancelEventArgs e)
        {
            // Lấy giá trị nhập vào từ TextBox
            int diem = Convert.ToInt32(txtDiemTB.Text);

            // Kiểm tra xem giá trị nhập vào có nằm trong khoảng từ 1 đến 10 hay không
            if (diem < 1 || diem > 10)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Điểm phải nằm trong khoảng từ 1 đến 10.", "Lỗi nhập điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Hủy bỏ việc nhập dữ liệu
                e.Cancel = true;
            }
        }
    }
}
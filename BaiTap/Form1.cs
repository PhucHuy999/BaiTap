using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        private int sTT = 1;
        private List<string> dsMaSV = new List<string>();
        private List<DataGridViewRow> dsRow = new List<DataGridViewRow>();
        public Form1()
        {
            InitializeComponent();
            dsRow = new List<DataGridViewRow>();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonThemMoi_Click(object sender, EventArgs e)
        {
            // Mở form2 để nhập thông tin sinh viên
            Form2 form2 = new Form2();
            form2.ShowDialog();

            // Nếu người dùng nhấn OK thì thêm thông tin sinh viên vào DataGridView
            if (form2.DialogResult == DialogResult.OK)
            {
                // Lấy thông tin sinh viên từ form2
                string maSV = form2.txtMSSV.Text;
                string tenSV = form2.txtTenSV.Text;
                string khoa = form2.cboNganhHoc.Text;
                double diemTB = Convert.ToDouble(form2.txtDiemTB.Text);
                // Kiểm tra xem mã số sinh viên đã có trong danh sách hay chưa
                if (dsMaSV.Contains(maSV))
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Mã số sinh viên đã tồn tại.", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm thông tin sinh viên vào DataGridView
                dataGridViewSinhVien.Rows.Add(sTT, maSV, tenSV, khoa, diemTB);
                sTT++;

                // Thêm mã số sinh viên vào danh sách
                dsMaSV.Add(maSV);
            }
        }
        private void FilterData(string searchText)
        {
            foreach (DataGridViewRow row in dataGridViewSinhVien.Rows)
            {
                // Kiểm tra xem hàng có phải là hàng mới không
                if (!row.IsNewRow)
                {
                    if (row.Cells["Column3"].Value != null &&
                        row.Cells["Column3"].Value.ToString()
                            .IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            FilterData(searchText);
        }

    }
}

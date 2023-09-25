using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT
{
    public partial class Form1 : Form
    {
        private int sTT = 1;
        public Form1()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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

                // Thêm dữ liệu vào DataGridView
                dataGridViewSinhVien.Rows.Add(sTT, maSV, tenSV, khoa, diemTB);
                sTT++;
            }
        }




    }
}
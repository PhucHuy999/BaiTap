using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //su dung dialog de mo file
                OpenFileDialog ofile = new OpenFileDialog();
                // chi dinh nhing file dugc mo
                ofile.Filter = "Bitmap file|*.jpg|Jpeg|*.png";
                if (ofile.ShowDialog() == DialogResult.OK)
                {
                    Form2 f2 = new Form2(ofile.FileName);
                    f2.MdiParent = this;
                    f2.Show();
                }
            }
        }
    }
}

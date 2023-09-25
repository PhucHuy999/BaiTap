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
    public partial class Form2 : Form
    {
        public Form2(string imagefile)

        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(imagefile);
            this.Text = imagefile.Substring(imagefile.LastIndexOf('\\') + 1);
         }
        public Form2()
        {
            InitializeComponent();
        }
    }
}


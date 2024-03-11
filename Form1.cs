using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELLOWORDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtshow_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            txtshow.Text = "Hello World!"; //你可以直接複製貼過去
        }
    }
}

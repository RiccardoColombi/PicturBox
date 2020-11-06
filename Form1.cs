using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturBox
{
    // ciao
    // ciao 2
    public partial class frmMain : Form
    {
        int stato = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (stato == 0)
            {
                pictureBox1.Image = Properties.Resources.macchinarossa;
                stato = 1;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.macchinabianca;
                stato = 0;
            }
        }
    }
}

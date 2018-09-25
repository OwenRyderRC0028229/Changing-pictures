using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Changing_pictures
{
    public partial class Form1 : Form
    {
        private Image milner;
        private Image andyrobbo;

        public Form1()
        {
            InitializeComponent();
            Milner = Properties.Resources.milner;
            AndyRobbo = Properties.Resources.andyrobbo;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Milner.Image == milner)
            {
                AndyRobbo.Image = andyrobbo;
            }
            else
            {
                Milner.Image = milner;
            }
    }
}
    }

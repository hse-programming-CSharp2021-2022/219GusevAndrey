using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        private int X, Y;
        private int width, height;

        public Form1()
        {
            InitializeComponent();
            X = 0;
            Y = 0;
            width = 250;
            height = 250;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            trackBar1.Maximum = Width - width;
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDark), X, Y, width, height);
            TransparencyKey = SystemColors.ControlDark;
         
            trackBar2.Maximum = Height - height;
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDark), X, Y, width, height);
            TransparencyKey = SystemColors.ControlDark;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            X = trackBar1.Value;
            Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Y = trackBar2.Maximum - trackBar2.Value;
            Invalidate();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freedraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool draw = false;

        int xp, yp;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;

            xp = e.X;
            yp = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(draw)
            {
                Graphics g = CreateGraphics();
                g.DrawLine(Pens.Black, xp, yp, e.X, e.Y);
                xp = e.X;
                yp = e.Y;
                g.Dispose();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

    }
}

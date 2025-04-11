using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malovani2
{
    public partial class Form1 : Form
    {
        int X, Y, lastX, lastY, penWidth;
        bool penDown;

        private void panelPaiting_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            penDown = true;
            penWidth = (int)trackBarPenWidth.Value;
        }

        private void panelPaiting_MouseUp(object sender, MouseEventArgs e)
        {
            penDown = false;
        }

        public Form1()
        {
            InitializeComponent();
            penDown = false;
        }

        private void panelPaiting_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = panelPaiting.CreateGraphics();
            lastX = X;
            lastY = Y;
            X = e.X;
            Y = e.Y;
            Pen pen = new Pen(Color.Black, penWidth);
            Brush brush = new SolidBrush(Color.Black);
            if (penDown == true)
            {
                gr.DrawLine(pen, lastX, lastY, X, Y);
                gr.FillEllipse(brush, X - (penWidth / 2), Y - (penWidth / 2), penWidth, penWidth);
            }
        }

        private void panelPaiting_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

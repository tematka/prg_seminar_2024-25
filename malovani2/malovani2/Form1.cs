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
        int X, Y, lastX, lastY, penWidth, penRed, penGreen, penBlue;
        bool penDown, colorPlus, colorMinus;
        string penType;

        private void buttonPen_Click(object sender, EventArgs e)
        {
            penWidth = (int)trackBarPenWidth.Value;
            penRed = (int)trackBarRed.Value;
            penGreen = (int)trackBarGreen.Value;
            penBlue = (int)trackBarBlue.Value;
            penType = "pen";
        }

        private void buttonRubber_Click(object sender, EventArgs e)
        {
            penWidth = (int)trackBarPenWidth.Value;
            penRed = 255;
            penGreen = 255;
            penBlue = 255;
            penType = "rubber";
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            penRed = (int)trackBarRed.Value;
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            penGreen = (int)trackBarGreen.Value;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            penBlue = (int)trackBarBlue.Value;
        }

        private void buttonPenRainbow_Click(object sender, EventArgs e)
        {
            penWidth = (int)trackBarPenWidth.Value;
            penRed = (int)trackBarRed.Value;
            penGreen = (int)trackBarGreen.Value;
            penBlue = (int)trackBarBlue.Value;
            penType = "rainbow";
        }

        private void panelPaiting_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            penDown = true;
            /*penWidth = (int)trackBarPenWidth.Value;
            penRed = (int)trackBarRed.Value;
            penGreen = (int)trackBarGreen.Value;
            penBlue = (int)trackBarBlue.Value;*/
        }

        private void trackBarPenWidth_Scroll(object sender, EventArgs e)
        {
            penWidth = (int)trackBarPenWidth.Value;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            panelPaiting.Refresh();
        }

        private void panelPaiting_MouseUp(object sender, MouseEventArgs e)
        {
            penDown = false;
        }

        public Form1()
        {
            InitializeComponent();
            penDown = false;
            penWidth = (int)trackBarPenWidth.Value;
            penRed = (int)trackBarRed.Value;
            penGreen = (int)trackBarGreen.Value;
            penBlue = (int)trackBarBlue.Value;
        }

        private void panelPaiting_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = panelPaiting.CreateGraphics();
            lastX = X;
            lastY = Y;
            X = e.X;
            Y = e.Y;
            Pen pen = new Pen(Color.FromArgb(penRed,penGreen,penBlue), penWidth);
            Brush brush = new SolidBrush(Color.FromArgb(penRed, penGreen, penBlue));
            if (penDown == true)
            {
                if(penType == "rainbow")
                {

                }
                else
                {
                    gr.DrawLine(pen, lastX, lastY, X, Y);
                    gr.FillEllipse(brush, X - (penWidth / 2), Y - (penWidth / 2), penWidth, penWidth);
                }
            }
        }

        private void panelPaiting_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}

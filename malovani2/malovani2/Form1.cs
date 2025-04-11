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
        int X, Y, lastX, lastY, penWidth, penRed, penGreen, penBlue, objectHeight, objectWidth;
        bool penDown, redPlus, greenPlus, bluePlus, paitingObject;
        string penType, objectType;

        private void buttonPen_Click(object sender, EventArgs e)
        {
            penWidth = (int)trackBarPenWidth.Value;
            penRed = (int)trackBarRed.Value;
            penGreen = (int)trackBarGreen.Value;
            penBlue = (int)trackBarBlue.Value;
            penType = "pen";
            objectType = "";
        }

        private void buttonRubber_Click(object sender, EventArgs e)
        {
            penWidth = (int)trackBarPenWidth.Value;
            penRed = 255;
            penGreen = 255;
            penBlue = 255;
            penType = "rubber";
            objectType = "";
        }

        private void buttonElips_Click(object sender, EventArgs e)
        {
            objectType = "elips";
            penType = "";
            penWidth = (int)trackBarPenWidth.Value;
            penRed = (int)trackBarRed.Value;
            penGreen = (int)trackBarGreen.Value;
            penBlue = (int)trackBarBlue.Value;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            objectType = "rectangle";
            penType = "";
            penWidth = (int)trackBarPenWidth.Value;
            penRed = (int)trackBarRed.Value;
            penGreen = (int)trackBarGreen.Value;
            penBlue = (int)trackBarBlue.Value;
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
            objectType = "";
        }

        private void panelPaiting_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            penDown = true;
        }

        private void trackBarPenWidth_Scroll(object sender, EventArgs e)
        {
            penWidth = (int)trackBarPenWidth.Value;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            panelPaiting.Refresh();
            penDown = false;
            penWidth = (int)trackBarPenWidth.Value;
            penRed = (int)trackBarRed.Value;
            penGreen = (int)trackBarGreen.Value;
            penBlue = (int)trackBarBlue.Value;
            redPlus = true;
            greenPlus = true;
            bluePlus = true;
            objectType = "";
            penType = "pen";
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
            redPlus = true;
            greenPlus = true;
            bluePlus = true;
            objectType = "";
            penType = "pen";
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
                if (penType == "rainbow")
                {
                    gr.DrawLine(pen, lastX, lastY, X, Y);
                    gr.FillEllipse(brush, X - (penWidth / 2), Y - (penWidth / 2), penWidth, penWidth);
                    if (penRed == 255)
                    {
                        redPlus = false;
                    }
                    if (penRed == 0)
                    {
                        redPlus = true;
                    }
                    if (penGreen == 255)
                    {
                        greenPlus = false;
                    }
                    if (penGreen == 0)
                    {
                        greenPlus = true;
                    }
                    if (penBlue == 255)
                    {
                        bluePlus = false;
                    }
                    if (penBlue == 0)
                    {
                        bluePlus = true;
                    }
                    if (redPlus == true)
                    {
                        penRed += 1;
                    }
                    else
                    {
                        penRed -= 1;
                    }
                    if (greenPlus == true)
                    {
                        penGreen += 1;
                    }
                    else
                    {
                        penGreen -= 1;
                    }
                    if (bluePlus == true)
                    {
                        penBlue += 1;
                    }
                    else
                    {
                        penBlue -= 1;
                    }
                }
                if (penType == "pen" || penType == "rubber")
                {
                    gr.DrawLine(pen, lastX, lastY, X, Y);
                    gr.FillEllipse(brush, X - (penWidth / 2), Y - (penWidth / 2), penWidth, penWidth);
                }
            }
        }

        private void panelPaiting_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gr = panelPaiting.CreateGraphics();
            X = e.X;
            Y = e.Y;
            objectWidth = (int)numericUpDownObjectWidth.Value;
            objectHeight = (int)numericUpDownObjectHeight.Value;
            Pen pen = new Pen(Color.FromArgb(penRed, penGreen, penBlue), penWidth);
            Brush brush = new SolidBrush(Color.FromArgb(penRed, penGreen, penBlue));
            if (checkBoxFull.Checked == true)
            {
                if (objectType == "elips")
                {
                    gr.FillEllipse(brush, X - (objectWidth / 2), Y - (objectHeight / 2), objectWidth, objectHeight);
                }
                if (objectType == "rectangle")
                {
                    gr.FillRectangle(brush, X - (objectWidth / 2), Y - (objectHeight / 2), objectWidth, objectHeight);
                }
            }
            else
            {
                if (objectType == "elips")
                {
                    gr.DrawEllipse(pen, X - (objectWidth / 2), Y - (objectHeight / 2), objectWidth, objectHeight);
                }
                if (objectType == "rectangle")
                {
                    gr.DrawRectangle(pen, X - (objectWidth / 2), Y - (objectHeight / 2), objectWidth, objectHeight);
                }
            }
        }
    }
}

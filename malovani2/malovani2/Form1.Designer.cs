namespace malovani2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPaiting = new System.Windows.Forms.Panel();
            this.trackBarPenWidth = new System.Windows.Forms.TrackBar();
            this.buttonNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonElips = new System.Windows.Forms.Button();
            this.buttonPen = new System.Windows.Forms.Button();
            this.buttonRubber = new System.Windows.Forms.Button();
            this.buttonPenRainbow = new System.Windows.Forms.Button();
            this.checkBoxFull = new System.Windows.Forms.CheckBox();
            this.numericUpDownObjectWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownObjectHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPaiting
            // 
            this.panelPaiting.BackColor = System.Drawing.Color.White;
            this.panelPaiting.Location = new System.Drawing.Point(6, 168);
            this.panelPaiting.Name = "panelPaiting";
            this.panelPaiting.Size = new System.Drawing.Size(971, 503);
            this.panelPaiting.TabIndex = 0;
            this.panelPaiting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPaiting_MouseClick);
            this.panelPaiting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPaiting_MouseDown);
            this.panelPaiting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPaiting_MouseMove);
            this.panelPaiting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPaiting_MouseUp);
            // 
            // trackBarPenWidth
            // 
            this.trackBarPenWidth.Location = new System.Drawing.Point(124, 56);
            this.trackBarPenWidth.Maximum = 50;
            this.trackBarPenWidth.Minimum = 1;
            this.trackBarPenWidth.Name = "trackBarPenWidth";
            this.trackBarPenWidth.Size = new System.Drawing.Size(220, 45);
            this.trackBarPenWidth.TabIndex = 1;
            this.trackBarPenWidth.Value = 1;
            this.trackBarPenWidth.Scroll += new System.EventHandler(this.trackBarPenWidth_Scroll);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(17, 16);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(82, 25);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "nový";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "šířka psací potřeby";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(483, 9);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(245, 45);
            this.trackBarRed.TabIndex = 4;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(483, 60);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(245, 45);
            this.trackBarGreen.TabIndex = 5;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "červená";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "zelená";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(485, 111);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(243, 45);
            this.trackBarBlue.TabIndex = 8;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "modrá";
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(752, 13);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(62, 43);
            this.buttonRectangle.TabIndex = 10;
            this.buttonRectangle.Text = "obdélník";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonElips
            // 
            this.buttonElips.Location = new System.Drawing.Point(831, 13);
            this.buttonElips.Name = "buttonElips";
            this.buttonElips.Size = new System.Drawing.Size(65, 42);
            this.buttonElips.TabIndex = 11;
            this.buttonElips.Text = "elipsa";
            this.buttonElips.UseVisualStyleBackColor = true;
            this.buttonElips.Click += new System.EventHandler(this.buttonElips_Click);
            // 
            // buttonPen
            // 
            this.buttonPen.Location = new System.Drawing.Point(20, 107);
            this.buttonPen.Name = "buttonPen";
            this.buttonPen.Size = new System.Drawing.Size(61, 45);
            this.buttonPen.TabIndex = 12;
            this.buttonPen.Text = "pero";
            this.buttonPen.UseVisualStyleBackColor = true;
            this.buttonPen.Click += new System.EventHandler(this.buttonPen_Click);
            // 
            // buttonRubber
            // 
            this.buttonRubber.Location = new System.Drawing.Point(100, 107);
            this.buttonRubber.Name = "buttonRubber";
            this.buttonRubber.Size = new System.Drawing.Size(55, 45);
            this.buttonRubber.TabIndex = 13;
            this.buttonRubber.Text = "guma";
            this.buttonRubber.UseVisualStyleBackColor = true;
            this.buttonRubber.Click += new System.EventHandler(this.buttonRubber_Click);
            // 
            // buttonPenRainbow
            // 
            this.buttonPenRainbow.Location = new System.Drawing.Point(175, 107);
            this.buttonPenRainbow.Name = "buttonPenRainbow";
            this.buttonPenRainbow.Size = new System.Drawing.Size(55, 44);
            this.buttonPenRainbow.TabIndex = 14;
            this.buttonPenRainbow.Text = "duhové pero";
            this.buttonPenRainbow.UseVisualStyleBackColor = true;
            this.buttonPenRainbow.Click += new System.EventHandler(this.buttonPenRainbow_Click);
            // 
            // checkBoxFull
            // 
            this.checkBoxFull.AutoSize = true;
            this.checkBoxFull.Location = new System.Drawing.Point(763, 135);
            this.checkBoxFull.Name = "checkBoxFull";
            this.checkBoxFull.Size = new System.Drawing.Size(51, 17);
            this.checkBoxFull.TabIndex = 15;
            this.checkBoxFull.Text = "výplň";
            this.checkBoxFull.UseVisualStyleBackColor = true;
            // 
            // numericUpDownObjectWidth
            // 
            this.numericUpDownObjectWidth.Location = new System.Drawing.Point(801, 70);
            this.numericUpDownObjectWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownObjectWidth.Name = "numericUpDownObjectWidth";
            this.numericUpDownObjectWidth.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownObjectWidth.TabIndex = 16;
            this.numericUpDownObjectWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownObjectHeight
            // 
            this.numericUpDownObjectHeight.Location = new System.Drawing.Point(801, 105);
            this.numericUpDownObjectHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownObjectHeight.Name = "numericUpDownObjectHeight";
            this.numericUpDownObjectHeight.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownObjectHeight.TabIndex = 17;
            this.numericUpDownObjectHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(749, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "šířka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(749, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "výška";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(989, 683);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownObjectHeight);
            this.Controls.Add(this.numericUpDownObjectWidth);
            this.Controls.Add(this.checkBoxFull);
            this.Controls.Add(this.buttonPenRainbow);
            this.Controls.Add(this.buttonRubber);
            this.Controls.Add(this.buttonPen);
            this.Controls.Add(this.buttonElips);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.trackBarPenWidth);
            this.Controls.Add(this.panelPaiting);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjectHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPaiting;
        private System.Windows.Forms.TrackBar trackBarPenWidth;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonElips;
        private System.Windows.Forms.Button buttonPen;
        private System.Windows.Forms.Button buttonRubber;
        private System.Windows.Forms.Button buttonPenRainbow;
        private System.Windows.Forms.CheckBox checkBoxFull;
        private System.Windows.Forms.NumericUpDown numericUpDownObjectWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownObjectHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


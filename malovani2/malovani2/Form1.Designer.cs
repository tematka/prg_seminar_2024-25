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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPaiting
            // 
            this.panelPaiting.BackColor = System.Drawing.Color.White;
            this.panelPaiting.Location = new System.Drawing.Point(6, 119);
            this.panelPaiting.Name = "panelPaiting";
            this.panelPaiting.Size = new System.Drawing.Size(782, 324);
            this.panelPaiting.TabIndex = 0;
            this.panelPaiting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPaiting_MouseClick);
            this.panelPaiting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPaiting_MouseDown);
            this.panelPaiting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPaiting_MouseMove);
            this.panelPaiting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPaiting_MouseUp);
            // 
            // trackBarPenWidth
            // 
            this.trackBarPenWidth.Location = new System.Drawing.Point(21, 24);
            this.trackBarPenWidth.Maximum = 50;
            this.trackBarPenWidth.Minimum = 1;
            this.trackBarPenWidth.Name = "trackBarPenWidth";
            this.trackBarPenWidth.Size = new System.Drawing.Size(252, 45);
            this.trackBarPenWidth.TabIndex = 1;
            this.trackBarPenWidth.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBarPenWidth);
            this.Controls.Add(this.panelPaiting);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPaiting;
        private System.Windows.Forms.TrackBar trackBarPenWidth;
    }
}


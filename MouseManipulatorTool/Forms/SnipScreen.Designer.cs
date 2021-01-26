namespace AutoClicker
{
    partial class SnipScreen
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
            this.Frame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.BackColor = System.Drawing.Color.Transparent;
            this.Frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Frame.ForeColor = System.Drawing.Color.Red;
            this.Frame.Location = new System.Drawing.Point(286, 136);
            this.Frame.Name = "Frame";
            this.Frame.Size = new System.Drawing.Size(189, 101);
            this.Frame.TabIndex = 0;
            this.Frame.Visible = false;
            // 
            // SnipScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Frame);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SnipScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnipScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SnipScreen_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SnipScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SnipScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SnipScreen_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Frame;
    }
}
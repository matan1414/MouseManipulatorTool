namespace AutoClicker
{
    partial class AutoClicker
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
            this.SnipScreenButton = new System.Windows.Forms.Button();
            this.btnOptionsScreen = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SnipScreenButton
            // 
            this.SnipScreenButton.Location = new System.Drawing.Point(281, 170);
            this.SnipScreenButton.Name = "SnipScreenButton";
            this.SnipScreenButton.Size = new System.Drawing.Size(140, 43);
            this.SnipScreenButton.TabIndex = 0;
            this.SnipScreenButton.Text = "Snip Screen";
            this.SnipScreenButton.UseVisualStyleBackColor = true;
            this.SnipScreenButton.Click += new System.EventHandler(this.SnipScreenButton_Click);
            // 
            // btnOptionsScreen
            // 
            this.btnOptionsScreen.Location = new System.Drawing.Point(109, 170);
            this.btnOptionsScreen.Name = "btnOptionsScreen";
            this.btnOptionsScreen.Size = new System.Drawing.Size(140, 43);
            this.btnOptionsScreen.TabIndex = 1;
            this.btnOptionsScreen.Text = "Options";
            this.btnOptionsScreen.UseVisualStyleBackColor = true;
            this.btnOptionsScreen.Click += new System.EventHandler(this.btnOptionsScreen_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(346, 258);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 60);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(248, 258);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 60);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOptionsScreen);
            this.Controls.Add(this.SnipScreenButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AutoClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoClicker_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SnipScreenButton;
        private System.Windows.Forms.Button btnOptionsScreen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}


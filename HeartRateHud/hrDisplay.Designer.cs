namespace HeartRateApp
{
    partial class hrDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hrDisplay));
            this.heartRateDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heartRateDisplay
            // 
            this.heartRateDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.heartRateDisplay.AutoSize = true;
            this.heartRateDisplay.BackColor = System.Drawing.Color.Red;
            this.heartRateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heartRateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heartRateDisplay.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.heartRateDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.heartRateDisplay.Location = new System.Drawing.Point(598, -2);
            this.heartRateDisplay.Name = "heartRateDisplay";
            this.heartRateDisplay.Size = new System.Drawing.Size(23, 25);
            this.heartRateDisplay.TabIndex = 0;
            this.heartRateDisplay.Text = "0";
            this.heartRateDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hrDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1250, 822);
            this.ControlBox = false;
            this.Controls.Add(this.heartRateDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hrDisplay";
            this.Opacity = 0.25D;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heartRateDisplay;
    }
}


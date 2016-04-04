namespace HeartRateApp
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
            this.heartRateDisplay.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartRateDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.heartRateDisplay.Location = new System.Drawing.Point(518, 9);
            this.heartRateDisplay.Name = "heartRateDisplay";
            this.heartRateDisplay.Size = new System.Drawing.Size(63, 70);
            this.heartRateDisplay.TabIndex = 0;
            this.heartRateDisplay.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1250, 822);
            this.ControlBox = false;
            this.Controls.Add(this.heartRateDisplay);
            this.Name = "Form1";
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


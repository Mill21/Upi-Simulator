namespace Upi_simulator
{
    partial class startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startup));
            this.startup_nappi = new System.Windows.Forms.Button();
            this.startup_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startup_nappi
            // 
            this.startup_nappi.BackColor = System.Drawing.Color.Transparent;
            this.startup_nappi.Location = new System.Drawing.Point(652, 372);
            this.startup_nappi.Name = "startup_nappi";
            this.startup_nappi.Size = new System.Drawing.Size(151, 79);
            this.startup_nappi.TabIndex = 1;
            this.startup_nappi.Text = "Aloita peli";
            this.startup_nappi.UseVisualStyleBackColor = false;
            this.startup_nappi.Click += new System.EventHandler(this.startup_nappi_Click);
            // 
            // startup_label
            // 
            this.startup_label.BackColor = System.Drawing.Color.Transparent;
            this.startup_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.startup_label.Location = new System.Drawing.Point(532, -1);
            this.startup_label.Name = "startup_label";
            this.startup_label.Size = new System.Drawing.Size(271, 44);
            this.startup_label.TabIndex = 2;
            this.startup_label.Text = "ÄIjien ilta simulator";
            this.startup_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(798, 451);
            this.Controls.Add(this.startup_label);
            this.Controls.Add(this.startup_nappi);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(814, 490);
            this.MinimumSize = new System.Drawing.Size(814, 490);
            this.Name = "startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upi Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startup_nappi;
        private System.Windows.Forms.Label startup_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
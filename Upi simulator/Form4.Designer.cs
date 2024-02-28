namespace Upi_simulator
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.Startup_button = new System.Windows.Forms.Button();
            this.Startup_label = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Startup_button
            // 
            this.Startup_button.BackColor = System.Drawing.Color.Transparent;
            this.Startup_button.Location = new System.Drawing.Point(652, 372);
            this.Startup_button.Name = "Startup_button";
            this.Startup_button.Size = new System.Drawing.Size(151, 79);
            this.Startup_button.TabIndex = 1;
            this.Startup_button.Text = "Aloita peli";
            this.Startup_button.UseVisualStyleBackColor = false;
            this.Startup_button.Click += new System.EventHandler(this.Startup_nappi_Click);
            // 
            // Startup_label
            // 
            this.Startup_label.BackColor = System.Drawing.Color.Transparent;
            this.Startup_label.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Startup_label.Location = new System.Drawing.Point(532, -1);
            this.Startup_label.Name = "Startup_label";
            this.Startup_label.Size = new System.Drawing.Size(271, 44);
            this.Startup_label.TabIndex = 2;
            this.Startup_label.Text = "ÄIjien ilta simulator";
            this.Startup_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(804, 452);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(798, 451);
            this.Controls.Add(this.Startup_label);
            this.Controls.Add(this.Startup_button);
            this.Controls.Add(this.PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(814, 490);
            this.MinimumSize = new System.Drawing.Size(814, 490);
            this.Name = "Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upi Simulator";
            this.Load += new System.EventHandler(this.Startup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Startup_button;
        private System.Windows.Forms.Label Startup_label;
        private System.Windows.Forms.PictureBox PictureBox1;
    }
}
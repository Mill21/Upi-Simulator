namespace Upi_simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.kela_button = new System.Windows.Forms.Button();
            this.Drink_button = new System.Windows.Forms.Button();
            this.Textbox1 = new System.Windows.Forms.TextBox();
            this.Start_button = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Pizza_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(-4, 28);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(283, 437);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // kela_button
            // 
            this.kela_button.Location = new System.Drawing.Point(285, 28);
            this.kela_button.Name = "kela_button";
            this.kela_button.Size = new System.Drawing.Size(140, 68);
            this.kela_button.TabIndex = 1;
            this.kela_button.Text = "Kirjoita Selvennys Kelalle";
            this.kela_button.UseVisualStyleBackColor = true;
            this.kela_button.Click += new System.EventHandler(this.Kela_selvennys_nappi_Click);
            // 
            // Drink_button
            // 
            this.Drink_button.Location = new System.Drawing.Point(285, 102);
            this.Drink_button.Name = "Drink_button";
            this.Drink_button.Size = new System.Drawing.Size(140, 68);
            this.Drink_button.TabIndex = 2;
            this.Drink_button.Text = "Hanki juomat";
            this.Drink_button.UseVisualStyleBackColor = true;
            this.Drink_button.Click += new System.EventHandler(this.Hanki_juomat_nappi_Click);
            // 
            // Textbox1
            // 
            this.Textbox1.Location = new System.Drawing.Point(453, 28);
            this.Textbox1.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.Textbox1.Multiline = true;
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.ReadOnly = true;
            this.Textbox1.Size = new System.Drawing.Size(337, 427);
            this.Textbox1.TabIndex = 3;
            this.Textbox1.Text = "TERVETULOA ÄIJIEN ILTA SIMULAATTORIIN!\r\nValmistele ennen äijien iltaa\r\n\r\n";
            this.Textbox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Start_button
            // 
            this.Start_button.Enabled = false;
            this.Start_button.Location = new System.Drawing.Point(285, 250);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(140, 68);
            this.Start_button.TabIndex = 4;
            this.Start_button.Text = "Aloita Äijien Ilta";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(71, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(134, 16);
            this.Title.TabIndex = 5;
            this.Title.Text = "ÄIJIEN ILTA SIMULATOR";
            this.Title.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Pizza_button
            // 
            this.Pizza_button.Location = new System.Drawing.Point(285, 176);
            this.Pizza_button.Name = "Pizza_button";
            this.Pizza_button.Size = new System.Drawing.Size(140, 68);
            this.Pizza_button.TabIndex = 6;
            this.Pizza_button.Text = "Hae ruuat";
            this.Pizza_button.UseVisualStyleBackColor = true;
            this.Pizza_button.Click += new System.EventHandler(this.Pizza_nappi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pizza_button);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Textbox1);
            this.Controls.Add(this.kela_button);
            this.Controls.Add(this.Drink_button);
            this.Controls.Add(this.PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button kela_button;
        private System.Windows.Forms.Button Drink_button;
        private System.Windows.Forms.TextBox Textbox1;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Pizza_button;
    }
}


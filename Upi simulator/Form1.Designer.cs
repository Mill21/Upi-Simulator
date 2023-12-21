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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kela_selvennys_nappi = new System.Windows.Forms.Button();
            this.hanki_juomat_nappi = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kela_selvennys_nappi
            // 
            this.kela_selvennys_nappi.Location = new System.Drawing.Point(285, 28);
            this.kela_selvennys_nappi.Name = "kela_selvennys_nappi";
            this.kela_selvennys_nappi.Size = new System.Drawing.Size(140, 68);
            this.kela_selvennys_nappi.TabIndex = 1;
            this.kela_selvennys_nappi.Text = "Kirjoita Selvennys Kelalle";
            this.kela_selvennys_nappi.UseVisualStyleBackColor = true;
            this.kela_selvennys_nappi.Click += new System.EventHandler(this.kela_selvennys_nappi_Click);
            // 
            // hanki_juomat_nappi
            // 
            this.hanki_juomat_nappi.Location = new System.Drawing.Point(285, 102);
            this.hanki_juomat_nappi.Name = "hanki_juomat_nappi";
            this.hanki_juomat_nappi.Size = new System.Drawing.Size(140, 68);
            this.hanki_juomat_nappi.TabIndex = 2;
            this.hanki_juomat_nappi.Text = "Hanki juomat";
            this.hanki_juomat_nappi.UseVisualStyleBackColor = true;
            this.hanki_juomat_nappi.Click += new System.EventHandler(this.hanki_juomat_nappi_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(453, 28);
            this.textbox1.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.ReadOnly = true;
            this.textbox1.Size = new System.Drawing.Size(337, 427);
            this.textbox1.TabIndex = 3;
            this.textbox1.Text = "TERVETULOA ÄIJIEN ILTA SIMULAATTORIIN!\r\nValmistele ennen äijien iltaa\r\n\r\n";
            this.textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(285, 176);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(140, 68);
            this.start.TabIndex = 4;
            this.start.Text = "Aloita Äijien Ilta";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button3_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(71, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(134, 16);
            this.title.TabIndex = 5;
            this.title.Text = "ÄIJIEN ILTA SIMULATOR";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 467);
            this.Controls.Add(this.title);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.kela_selvennys_nappi);
            this.Controls.Add(this.hanki_juomat_nappi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kela_selvennys_nappi;
        private System.Windows.Forms.Button hanki_juomat_nappi;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label title;
    }
}


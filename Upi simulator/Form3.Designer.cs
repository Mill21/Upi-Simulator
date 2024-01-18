namespace Upi_simulator
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Title = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Midsummer_button = new System.Windows.Forms.Button();
            this.Microwawe_button = new System.Windows.Forms.Button();
            this.Pee_button = new System.Windows.Forms.Button();
            this.Woman_button = new System.Windows.Forms.Button();
            this.Chair_button = new System.Windows.Forms.Button();
            this.Gameover_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(291, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(183, 60);
            this.Title.TabIndex = 0;
            this.Title.Text = "ÄIJIEN ILTA";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(262, 53);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(240, 136);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(262, 181);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(240, 136);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 2;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(262, 314);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(240, 136);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 3;
            this.PictureBox3.TabStop = false;
            // 
            // Midsummer_button
            // 
            this.Midsummer_button.Location = new System.Drawing.Point(51, 78);
            this.Midsummer_button.Name = "Midsummer_button";
            this.Midsummer_button.Size = new System.Drawing.Size(140, 68);
            this.Midsummer_button.TabIndex = 4;
            this.Midsummer_button.Text = "Sytytä \"Juhannus\" kokko";
            this.Midsummer_button.UseVisualStyleBackColor = true;
            this.Midsummer_button.Click += new System.EventHandler(this.Juhannus_nappi_Click);
            // 
            // Microwawe_button
            // 
            this.Microwawe_button.Location = new System.Drawing.Point(51, 205);
            this.Microwawe_button.Name = "Microwawe_button";
            this.Microwawe_button.Size = new System.Drawing.Size(140, 68);
            this.Microwawe_button.TabIndex = 5;
            this.Microwawe_button.Text = "Sytytä tupakka";
            this.Microwawe_button.UseVisualStyleBackColor = true;
            this.Microwawe_button.Click += new System.EventHandler(this.Sauna_nappi_Click);
            // 
            // Pee_button
            // 
            this.Pee_button.Location = new System.Drawing.Point(51, 340);
            this.Pee_button.Name = "Pee_button";
            this.Pee_button.Size = new System.Drawing.Size(140, 68);
            this.Pee_button.TabIndex = 6;
            this.Pee_button.Text = "Käy kusella";
            this.Pee_button.UseVisualStyleBackColor = true;
            this.Pee_button.Click += new System.EventHandler(this.Pisu_nappi_Click);
            // 
            // Woman_button
            // 
            this.Woman_button.Location = new System.Drawing.Point(569, 78);
            this.Woman_button.Name = "Woman_button";
            this.Woman_button.Size = new System.Drawing.Size(140, 68);
            this.Woman_button.TabIndex = 7;
            this.Woman_button.Text = "Upi kertoo unelma kumppaninsa";
            this.Woman_button.UseVisualStyleBackColor = true;
            this.Woman_button.Click += new System.EventHandler(this.Koko_nappi_Click);
            // 
            // Chair_button
            // 
            this.Chair_button.Location = new System.Drawing.Point(569, 205);
            this.Chair_button.Name = "Chair_button";
            this.Chair_button.Size = new System.Drawing.Size(140, 68);
            this.Chair_button.TabIndex = 8;
            this.Chair_button.Text = "Nouse tuolille";
            this.Chair_button.UseVisualStyleBackColor = true;
            this.Chair_button.Click += new System.EventHandler(this.Tuoli_nappi_Click);
            // 
            // Gameover_button
            // 
            this.Gameover_button.Location = new System.Drawing.Point(569, 340);
            this.Gameover_button.Name = "Gameover_button";
            this.Gameover_button.Size = new System.Drawing.Size(140, 68);
            this.Gameover_button.TabIndex = 9;
            this.Gameover_button.Text = "Kerro ideaali maailmanloppusi";
            this.Gameover_button.UseVisualStyleBackColor = true;
            this.Gameover_button.Click += new System.EventHandler(this.Maailmanloppu_nappi_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gameover_button);
            this.Controls.Add(this.Chair_button);
            this.Controls.Add(this.Woman_button);
            this.Controls.Add(this.Pee_button);
            this.Controls.Add(this.Microwawe_button);
            this.Controls.Add(this.Midsummer_button);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Äijjien Ilta";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.Button Midsummer_button;
        private System.Windows.Forms.Button Microwawe_button;
        private System.Windows.Forms.Button Pee_button;
        private System.Windows.Forms.Button Woman_button;
        private System.Windows.Forms.Button Chair_button;
        private System.Windows.Forms.Button Gameover_button;
    }
}
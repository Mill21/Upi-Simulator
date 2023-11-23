namespace Upi_simulator
{
    partial class Video_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video_Player));
            this.media_player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.media_player)).BeginInit();
            this.SuspendLayout();
            // 
            // media_player
            // 
            this.media_player.Enabled = true;
            this.media_player.Location = new System.Drawing.Point(-1, 1);
            this.media_player.Name = "media_player";
            this.media_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media_player.OcxState")));
            this.media_player.Size = new System.Drawing.Size(802, 449);
            this.media_player.TabIndex = 0;
            this.media_player.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Video_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.media_player);
            this.Name = "Video_Player";
            this.Text = "Video_Player";
            this.Load += new System.EventHandler(this.Video_Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.media_player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer media_player;
    }
}
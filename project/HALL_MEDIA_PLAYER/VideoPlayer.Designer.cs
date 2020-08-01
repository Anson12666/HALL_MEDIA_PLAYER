namespace HALL_MEDIA_PLAYER
{
    partial class VideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.Video_Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Video_Source = new System.Windows.Forms.ListBox();
            this.Video_Info_TXT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Video_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Video_Player
            // 
            this.Video_Player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Video_Player.Enabled = true;
            this.Video_Player.Location = new System.Drawing.Point(0, 0);
            this.Video_Player.Name = "Video_Player";
            this.Video_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Video_Player.OcxState")));
            this.Video_Player.Size = new System.Drawing.Size(325, 132);
            this.Video_Player.TabIndex = 0;
            this.Video_Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Video_Play_State_Change);
            this.Video_Player.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.MouseMoving);
            // 
            // Video_Source
            // 
            this.Video_Source.FormattingEnabled = true;
            this.Video_Source.HorizontalScrollbar = true;
            this.Video_Source.ItemHeight = 12;
            this.Video_Source.Location = new System.Drawing.Point(0, 0);
            this.Video_Source.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Video_Source.Name = "Video_Source";
            this.Video_Source.Size = new System.Drawing.Size(325, 88);
            this.Video_Source.TabIndex = 1;
            this.Video_Source.Visible = false;
            // 
            // Video_Info_TXT
            // 
            this.Video_Info_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Video_Info_TXT.AutoSize = true;
            this.Video_Info_TXT.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Video_Info_TXT.ForeColor = System.Drawing.Color.White;
            this.Video_Info_TXT.Location = new System.Drawing.Point(12, 9);
            this.Video_Info_TXT.Name = "Video_Info_TXT";
            this.Video_Info_TXT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Video_Info_TXT.Size = new System.Drawing.Size(378, 19);
            this.Video_Info_TXT.TabIndex = 2;
            this.Video_Info_TXT.Text = "Video_Information_is_going_to_Show_HERE!!!!!";
            this.Video_Info_TXT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Video_Info_TXT.Visible = false;
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Video_Info_TXT);
            this.Controls.Add(this.Video_Source);
            this.Controls.Add(this.Video_Player);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoPlayer";
            this.Text = "Player";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Video_Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Video_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Video_Player;
        public System.Windows.Forms.ListBox Video_Source;
        private System.Windows.Forms.Label Video_Info_TXT;
    }
}
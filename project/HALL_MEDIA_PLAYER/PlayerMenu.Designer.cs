namespace HALL_MEDIA_PLAYER
{
    partial class PlayerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Music = new System.Windows.Forms.TabPage();
            this.savepref_level = new System.Windows.Forms.CheckBox();
            this.Single_Player_Mode = new System.Windows.Forms.CheckBox();
            this.Audio_Save_Load = new System.Windows.Forms.Button();
            this.Music_Replay = new System.Windows.Forms.CheckBox();
            this.Music_autochange = new System.Windows.Forms.CheckBox();
            this.Music_Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Replay_Music = new System.Windows.Forms.Button();
            this.Music_Source_ARR_DOWN = new System.Windows.Forms.Button();
            this.Music_Source_ARR_UP = new System.Windows.Forms.Button();
            this.Remove_Music = new System.Windows.Forms.Button();
            this.Music_fade_opt = new System.Windows.Forms.CheckBox();
            this.Play_Music = new System.Windows.Forms.Button();
            this.Music_Source = new System.Windows.Forms.ListBox();
            this.Import_Music = new System.Windows.Forms.Button();
            this.Music_Other_Op = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BGM_Replay = new System.Windows.Forms.CheckBox();
            this.BGM_autochange = new System.Windows.Forms.CheckBox();
            this.BGM_Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Replay_BGM = new System.Windows.Forms.Button();
            this.BGM_Source_ARR_DOWN = new System.Windows.Forms.Button();
            this.BGM_Source_ARR_UP = new System.Windows.Forms.Button();
            this.Remove_BGM = new System.Windows.Forms.Button();
            this.BGM_fade_opt = new System.Windows.Forms.CheckBox();
            this.Play_BGM = new System.Windows.Forms.Button();
            this.BGM_Source = new System.Windows.Forms.ListBox();
            this.Import_BGM = new System.Windows.Forms.Button();
            this.BGM_Other_Op = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Video = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Start_Video = new System.Windows.Forms.Button();
            this.pref_video_autoplay = new System.Windows.Forms.CheckBox();
            this.pref_video_repeat = new System.Windows.Forms.CheckBox();
            this.pref_video_msg = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Video_Source_ARR_DOWN = new System.Windows.Forms.Button();
            this.Video_Source_ARR_UP = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.Video_Save_Load = new System.Windows.Forms.Button();
            this.Import_Command = new System.Windows.Forms.Button();
            this.Delete_Item = new System.Windows.Forms.Button();
            this.Import_Video = new System.Windows.Forms.Button();
            this.Video_Source = new System.Windows.Forms.ListBox();
            this.Emergency_Stop_Btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Music.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Music_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGM_Player)).BeginInit();
            this.Video.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.Music);
            this.tabControl1.Controls.Add(this.Video);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(24, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // Music
            // 
            this.Music.AllowDrop = true;
            this.Music.Controls.Add(this.savepref_level);
            this.Music.Controls.Add(this.Single_Player_Mode);
            this.Music.Controls.Add(this.Audio_Save_Load);
            this.Music.Controls.Add(this.Music_Replay);
            this.Music.Controls.Add(this.Music_autochange);
            this.Music.Controls.Add(this.Music_Player);
            this.Music.Controls.Add(this.Replay_Music);
            this.Music.Controls.Add(this.Music_Source_ARR_DOWN);
            this.Music.Controls.Add(this.Music_Source_ARR_UP);
            this.Music.Controls.Add(this.Remove_Music);
            this.Music.Controls.Add(this.Music_fade_opt);
            this.Music.Controls.Add(this.Play_Music);
            this.Music.Controls.Add(this.Music_Source);
            this.Music.Controls.Add(this.Import_Music);
            this.Music.Controls.Add(this.Music_Other_Op);
            this.Music.Controls.Add(this.label3);
            this.Music.Controls.Add(this.BGM_Replay);
            this.Music.Controls.Add(this.BGM_autochange);
            this.Music.Controls.Add(this.BGM_Player);
            this.Music.Controls.Add(this.Replay_BGM);
            this.Music.Controls.Add(this.BGM_Source_ARR_DOWN);
            this.Music.Controls.Add(this.BGM_Source_ARR_UP);
            this.Music.Controls.Add(this.Remove_BGM);
            this.Music.Controls.Add(this.BGM_fade_opt);
            this.Music.Controls.Add(this.Play_BGM);
            this.Music.Controls.Add(this.BGM_Source);
            this.Music.Controls.Add(this.Import_BGM);
            this.Music.Controls.Add(this.BGM_Other_Op);
            this.Music.Controls.Add(this.label1);
            this.Music.Font = new System.Drawing.Font("新細明體", 11F);
            this.Music.Location = new System.Drawing.Point(4, 26);
            this.Music.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Music.Name = "Music";
            this.Music.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Music.Size = new System.Drawing.Size(818, 442);
            this.Music.TabIndex = 1;
            this.Music.Text = "播放音樂";
            this.Music.UseVisualStyleBackColor = true;
            this.Music.Click += new System.EventHandler(this.Video_Click);
            // 
            // savepref_level
            // 
            this.savepref_level.AutoSize = true;
            this.savepref_level.Location = new System.Drawing.Point(652, 367);
            this.savepref_level.Name = "savepref_level";
            this.savepref_level.Size = new System.Drawing.Size(116, 19);
            this.savepref_level.TabIndex = 32;
            this.savepref_level.Text = "儲存所有設定";
            this.savepref_level.UseVisualStyleBackColor = true;
            this.savepref_level.Visible = false;
            // 
            // Single_Player_Mode
            // 
            this.Single_Player_Mode.AutoSize = true;
            this.Single_Player_Mode.Checked = true;
            this.Single_Player_Mode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Single_Player_Mode.Location = new System.Drawing.Point(652, 60);
            this.Single_Player_Mode.Name = "Single_Player_Mode";
            this.Single_Player_Mode.Size = new System.Drawing.Size(146, 19);
            this.Single_Player_Mode.TabIndex = 31;
            this.Single_Player_Mode.Text = "只允許一個播放器";
            this.Single_Player_Mode.UseVisualStyleBackColor = true;
            // 
            // Audio_Save_Load
            // 
            this.Audio_Save_Load.Location = new System.Drawing.Point(652, 404);
            this.Audio_Save_Load.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Audio_Save_Load.Name = "Audio_Save_Load";
            this.Audio_Save_Load.Size = new System.Drawing.Size(163, 34);
            this.Audio_Save_Load.TabIndex = 30;
            this.Audio_Save_Load.Text = "儲存/讀取設定";
            this.Audio_Save_Load.UseVisualStyleBackColor = true;
            this.Audio_Save_Load.Click += new System.EventHandler(this.Audio_Save_Load_Click);
            // 
            // Music_Replay
            // 
            this.Music_Replay.AutoSize = true;
            this.Music_Replay.Location = new System.Drawing.Point(347, 83);
            this.Music_Replay.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Music_Replay.Name = "Music_Replay";
            this.Music_Replay.Size = new System.Drawing.Size(86, 19);
            this.Music_Replay.TabIndex = 29;
            this.Music_Replay.Text = "循環列表";
            this.Music_Replay.UseVisualStyleBackColor = true;
            // 
            // Music_autochange
            // 
            this.Music_autochange.AutoSize = true;
            this.Music_autochange.Location = new System.Drawing.Point(347, 60);
            this.Music_autochange.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Music_autochange.Name = "Music_autochange";
            this.Music_autochange.Size = new System.Drawing.Size(86, 19);
            this.Music_autochange.TabIndex = 28;
            this.Music_autochange.Text = "自動換歌";
            this.Music_autochange.UseVisualStyleBackColor = true;
            // 
            // Music_Player
            // 
            this.Music_Player.Enabled = true;
            this.Music_Player.Location = new System.Drawing.Point(334, 215);
            this.Music_Player.Name = "Music_Player";
            this.Music_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Music_Player.OcxState")));
            this.Music_Player.Size = new System.Drawing.Size(209, 45);
            this.Music_Player.TabIndex = 27;
            this.Music_Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Music_Play_State_Change);
            // 
            // Replay_Music
            // 
            this.Replay_Music.Location = new System.Drawing.Point(344, 165);
            this.Replay_Music.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Replay_Music.Name = "Replay_Music";
            this.Replay_Music.Size = new System.Drawing.Size(86, 34);
            this.Replay_Music.TabIndex = 26;
            this.Replay_Music.Text = "重新播放";
            this.Replay_Music.UseVisualStyleBackColor = true;
            this.Replay_Music.Click += new System.EventHandler(this.Replay_Music_Click);
            // 
            // Music_Source_ARR_DOWN
            // 
            this.Music_Source_ARR_DOWN.Location = new System.Drawing.Point(557, 339);
            this.Music_Source_ARR_DOWN.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Music_Source_ARR_DOWN.Name = "Music_Source_ARR_DOWN";
            this.Music_Source_ARR_DOWN.Size = new System.Drawing.Size(39, 34);
            this.Music_Source_ARR_DOWN.TabIndex = 25;
            this.Music_Source_ARR_DOWN.Text = "↓";
            this.Music_Source_ARR_DOWN.UseVisualStyleBackColor = true;
            this.Music_Source_ARR_DOWN.Click += new System.EventHandler(this.Music_Source_ARR_DOWN_Click);
            // 
            // Music_Source_ARR_UP
            // 
            this.Music_Source_ARR_UP.Location = new System.Drawing.Point(557, 293);
            this.Music_Source_ARR_UP.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Music_Source_ARR_UP.Name = "Music_Source_ARR_UP";
            this.Music_Source_ARR_UP.Size = new System.Drawing.Size(39, 34);
            this.Music_Source_ARR_UP.TabIndex = 24;
            this.Music_Source_ARR_UP.Text = "↑";
            this.Music_Source_ARR_UP.UseVisualStyleBackColor = true;
            this.Music_Source_ARR_UP.Click += new System.EventHandler(this.Music_Source_ARR_UP_Click);
            // 
            // Remove_Music
            // 
            this.Remove_Music.Location = new System.Drawing.Point(450, 395);
            this.Remove_Music.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Remove_Music.Name = "Remove_Music";
            this.Remove_Music.Size = new System.Drawing.Size(86, 34);
            this.Remove_Music.TabIndex = 23;
            this.Remove_Music.Text = "移除曲目";
            this.Remove_Music.UseVisualStyleBackColor = true;
            this.Remove_Music.Click += new System.EventHandler(this.Remove_Music_Click);
            // 
            // Music_fade_opt
            // 
            this.Music_fade_opt.AutoSize = true;
            this.Music_fade_opt.Location = new System.Drawing.Point(449, 60);
            this.Music_fade_opt.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Music_fade_opt.Name = "Music_fade_opt";
            this.Music_fade_opt.Size = new System.Drawing.Size(86, 19);
            this.Music_fade_opt.TabIndex = 22;
            this.Music_fade_opt.Text = "淡出淡入";
            this.Music_fade_opt.UseVisualStyleBackColor = true;
            this.Music_fade_opt.CheckedChanged += new System.EventHandler(this.Music_fade_opt_CheckedChanged);
            // 
            // Play_Music
            // 
            this.Play_Music.Location = new System.Drawing.Point(344, 127);
            this.Play_Music.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Play_Music.Name = "Play_Music";
            this.Play_Music.Size = new System.Drawing.Size(86, 34);
            this.Play_Music.TabIndex = 21;
            this.Play_Music.Text = "立即播放";
            this.Play_Music.UseVisualStyleBackColor = true;
            this.Play_Music.Click += new System.EventHandler(this.Play_Music_Click);
            // 
            // Music_Source
            // 
            this.Music_Source.FormattingEnabled = true;
            this.Music_Source.HorizontalScrollbar = true;
            this.Music_Source.ItemHeight = 15;
            this.Music_Source.Location = new System.Drawing.Point(334, 277);
            this.Music_Source.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Music_Source.Name = "Music_Source";
            this.Music_Source.Size = new System.Drawing.Size(202, 109);
            this.Music_Source.TabIndex = 20;
            // 
            // Import_Music
            // 
            this.Import_Music.Location = new System.Drawing.Point(337, 395);
            this.Import_Music.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Import_Music.Name = "Import_Music";
            this.Import_Music.Size = new System.Drawing.Size(86, 34);
            this.Import_Music.TabIndex = 19;
            this.Import_Music.Text = "增加曲目";
            this.Import_Music.UseVisualStyleBackColor = true;
            this.Import_Music.Click += new System.EventHandler(this.Import_Music_Click);
            // 
            // Music_Other_Op
            // 
            this.Music_Other_Op.Location = new System.Drawing.Point(457, 127);
            this.Music_Other_Op.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Music_Other_Op.Name = "Music_Other_Op";
            this.Music_Other_Op.Size = new System.Drawing.Size(86, 34);
            this.Music_Other_Op.TabIndex = 18;
            this.Music_Other_Op.Text = "其他選項";
            this.Music_Other_Op.UseVisualStyleBackColor = true;
            this.Music_Other_Op.Visible = false;
            this.Music_Other_Op.Click += new System.EventHandler(this.Music_Other_Op_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "音樂播放";
            // 
            // BGM_Replay
            // 
            this.BGM_Replay.AutoSize = true;
            this.BGM_Replay.Checked = true;
            this.BGM_Replay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BGM_Replay.Location = new System.Drawing.Point(78, 83);
            this.BGM_Replay.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BGM_Replay.Name = "BGM_Replay";
            this.BGM_Replay.Size = new System.Drawing.Size(86, 19);
            this.BGM_Replay.TabIndex = 16;
            this.BGM_Replay.Text = "循環列表";
            this.BGM_Replay.UseVisualStyleBackColor = true;
            // 
            // BGM_autochange
            // 
            this.BGM_autochange.AutoSize = true;
            this.BGM_autochange.Checked = true;
            this.BGM_autochange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BGM_autochange.Location = new System.Drawing.Point(78, 60);
            this.BGM_autochange.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BGM_autochange.Name = "BGM_autochange";
            this.BGM_autochange.Size = new System.Drawing.Size(86, 19);
            this.BGM_autochange.TabIndex = 15;
            this.BGM_autochange.Text = "自動換歌";
            this.BGM_autochange.UseVisualStyleBackColor = true;
            // 
            // BGM_Player
            // 
            this.BGM_Player.Enabled = true;
            this.BGM_Player.Location = new System.Drawing.Point(68, 215);
            this.BGM_Player.Name = "BGM_Player";
            this.BGM_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BGM_Player.OcxState")));
            this.BGM_Player.Size = new System.Drawing.Size(209, 45);
            this.BGM_Player.TabIndex = 13;
            this.BGM_Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.BGM_Play_State_Change);
            // 
            // Replay_BGM
            // 
            this.Replay_BGM.Location = new System.Drawing.Point(75, 165);
            this.Replay_BGM.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Replay_BGM.Name = "Replay_BGM";
            this.Replay_BGM.Size = new System.Drawing.Size(86, 34);
            this.Replay_BGM.TabIndex = 12;
            this.Replay_BGM.Text = "重新播放";
            this.Replay_BGM.UseVisualStyleBackColor = true;
            this.Replay_BGM.Click += new System.EventHandler(this.Replay_BGM_Click);
            // 
            // BGM_Source_ARR_DOWN
            // 
            this.BGM_Source_ARR_DOWN.Location = new System.Drawing.Point(18, 339);
            this.BGM_Source_ARR_DOWN.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BGM_Source_ARR_DOWN.Name = "BGM_Source_ARR_DOWN";
            this.BGM_Source_ARR_DOWN.Size = new System.Drawing.Size(39, 34);
            this.BGM_Source_ARR_DOWN.TabIndex = 11;
            this.BGM_Source_ARR_DOWN.Text = "↓";
            this.BGM_Source_ARR_DOWN.UseVisualStyleBackColor = true;
            this.BGM_Source_ARR_DOWN.Click += new System.EventHandler(this.BGM_Source_ARR_DOWN_Click);
            // 
            // BGM_Source_ARR_UP
            // 
            this.BGM_Source_ARR_UP.Location = new System.Drawing.Point(18, 293);
            this.BGM_Source_ARR_UP.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BGM_Source_ARR_UP.Name = "BGM_Source_ARR_UP";
            this.BGM_Source_ARR_UP.Size = new System.Drawing.Size(39, 34);
            this.BGM_Source_ARR_UP.TabIndex = 10;
            this.BGM_Source_ARR_UP.Text = "↑";
            this.BGM_Source_ARR_UP.UseVisualStyleBackColor = true;
            this.BGM_Source_ARR_UP.Click += new System.EventHandler(this.BGM_Source_ARR_UP_Click);
            // 
            // Remove_BGM
            // 
            this.Remove_BGM.Location = new System.Drawing.Point(188, 395);
            this.Remove_BGM.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Remove_BGM.Name = "Remove_BGM";
            this.Remove_BGM.Size = new System.Drawing.Size(86, 34);
            this.Remove_BGM.TabIndex = 7;
            this.Remove_BGM.Text = "移除曲目";
            this.Remove_BGM.UseVisualStyleBackColor = true;
            this.Remove_BGM.Click += new System.EventHandler(this.Remove_BGM_Click);
            // 
            // BGM_fade_opt
            // 
            this.BGM_fade_opt.AutoSize = true;
            this.BGM_fade_opt.Location = new System.Drawing.Point(180, 60);
            this.BGM_fade_opt.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BGM_fade_opt.Name = "BGM_fade_opt";
            this.BGM_fade_opt.Size = new System.Drawing.Size(86, 19);
            this.BGM_fade_opt.TabIndex = 6;
            this.BGM_fade_opt.Text = "淡出淡入";
            this.BGM_fade_opt.UseVisualStyleBackColor = true;
            this.BGM_fade_opt.CheckedChanged += new System.EventHandler(this.BGM_fade_opt_CheckedChanged);
            // 
            // Play_BGM
            // 
            this.Play_BGM.Location = new System.Drawing.Point(75, 127);
            this.Play_BGM.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Play_BGM.Name = "Play_BGM";
            this.Play_BGM.Size = new System.Drawing.Size(86, 34);
            this.Play_BGM.TabIndex = 4;
            this.Play_BGM.Text = "立即播放";
            this.Play_BGM.UseVisualStyleBackColor = true;
            this.Play_BGM.Click += new System.EventHandler(this.Play_BGM_Click);
            // 
            // BGM_Source
            // 
            this.BGM_Source.FormattingEnabled = true;
            this.BGM_Source.HorizontalScrollbar = true;
            this.BGM_Source.ItemHeight = 15;
            this.BGM_Source.Location = new System.Drawing.Point(72, 277);
            this.BGM_Source.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BGM_Source.Name = "BGM_Source";
            this.BGM_Source.Size = new System.Drawing.Size(202, 109);
            this.BGM_Source.TabIndex = 3;
            // 
            // Import_BGM
            // 
            this.Import_BGM.Location = new System.Drawing.Point(75, 395);
            this.Import_BGM.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Import_BGM.Name = "Import_BGM";
            this.Import_BGM.Size = new System.Drawing.Size(86, 34);
            this.Import_BGM.TabIndex = 2;
            this.Import_BGM.Text = "增加曲目";
            this.Import_BGM.UseVisualStyleBackColor = true;
            this.Import_BGM.Click += new System.EventHandler(this.Import_BGM_Click);
            // 
            // BGM_Other_Op
            // 
            this.BGM_Other_Op.Location = new System.Drawing.Point(188, 127);
            this.BGM_Other_Op.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.BGM_Other_Op.Name = "BGM_Other_Op";
            this.BGM_Other_Op.Size = new System.Drawing.Size(86, 34);
            this.BGM_Other_Op.TabIndex = 1;
            this.BGM_Other_Op.Text = "其他選項";
            this.BGM_Other_Op.UseVisualStyleBackColor = true;
            this.BGM_Other_Op.Visible = false;
            this.BGM_Other_Op.Click += new System.EventHandler(this.BGM_Other_Op_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "背景音樂";
            // 
            // Video
            // 
            this.Video.Controls.Add(this.label4);
            this.Video.Controls.Add(this.Start_Video);
            this.Video.Controls.Add(this.pref_video_autoplay);
            this.Video.Controls.Add(this.pref_video_repeat);
            this.Video.Controls.Add(this.pref_video_msg);
            this.Video.Controls.Add(this.label2);
            this.Video.Controls.Add(this.Video_Source_ARR_DOWN);
            this.Video.Controls.Add(this.Video_Source_ARR_UP);
            this.Video.Controls.Add(this.button13);
            this.Video.Controls.Add(this.button14);
            this.Video.Controls.Add(this.Video_Save_Load);
            this.Video.Controls.Add(this.Import_Command);
            this.Video.Controls.Add(this.Delete_Item);
            this.Video.Controls.Add(this.Import_Video);
            this.Video.Controls.Add(this.Video_Source);
            this.Video.Font = new System.Drawing.Font("新細明體", 11F);
            this.Video.Location = new System.Drawing.Point(4, 26);
            this.Video.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Video.Name = "Video";
            this.Video.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Video.Size = new System.Drawing.Size(818, 442);
            this.Video.TabIndex = 2;
            this.Video.Text = "播放影片";
            this.Video.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(58, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 96);
            this.label4.TabIndex = 16;
            this.label4.Text = "説明：\r\n移動鼠標在左上角會顯示時間\r\nQ：前一條影片 W：後一條影片 R：重播影片\r\n空格：暫停影片\r\n方向鍵：可控制影片進度（± 15秒）\r\n其他：按鍵會顯示" +
    "播放器";
            // 
            // Start_Video
            // 
            this.Start_Video.Location = new System.Drawing.Point(148, 38);
            this.Start_Video.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Start_Video.Name = "Start_Video";
            this.Start_Video.Size = new System.Drawing.Size(188, 95);
            this.Start_Video.TabIndex = 15;
            this.Start_Video.Text = "開始播放";
            this.Start_Video.UseVisualStyleBackColor = true;
            this.Start_Video.Click += new System.EventHandler(this.Start_Video_Click);
            // 
            // pref_video_autoplay
            // 
            this.pref_video_autoplay.AutoSize = true;
            this.pref_video_autoplay.Checked = true;
            this.pref_video_autoplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pref_video_autoplay.Location = new System.Drawing.Point(492, 152);
            this.pref_video_autoplay.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pref_video_autoplay.Name = "pref_video_autoplay";
            this.pref_video_autoplay.Size = new System.Drawing.Size(116, 19);
            this.pref_video_autoplay.TabIndex = 13;
            this.pref_video_autoplay.Text = "自動連續播放";
            this.pref_video_autoplay.UseVisualStyleBackColor = true;
            // 
            // pref_video_repeat
            // 
            this.pref_video_repeat.AutoSize = true;
            this.pref_video_repeat.Checked = true;
            this.pref_video_repeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pref_video_repeat.Location = new System.Drawing.Point(492, 114);
            this.pref_video_repeat.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pref_video_repeat.Name = "pref_video_repeat";
            this.pref_video_repeat.Size = new System.Drawing.Size(86, 19);
            this.pref_video_repeat.TabIndex = 12;
            this.pref_video_repeat.Text = "循環列表";
            this.pref_video_repeat.UseVisualStyleBackColor = true;
            // 
            // pref_video_msg
            // 
            this.pref_video_msg.AutoSize = true;
            this.pref_video_msg.Checked = true;
            this.pref_video_msg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pref_video_msg.Location = new System.Drawing.Point(492, 75);
            this.pref_video_msg.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pref_video_msg.Name = "pref_video_msg";
            this.pref_video_msg.Size = new System.Drawing.Size(221, 19);
            this.pref_video_msg.TabIndex = 11;
            this.pref_video_msg.Text = "滑鼠移動時在左上角顯示訊息";
            this.pref_video_msg.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(462, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "偏好設定";
            // 
            // Video_Source_ARR_DOWN
            // 
            this.Video_Source_ARR_DOWN.Location = new System.Drawing.Point(9, 374);
            this.Video_Source_ARR_DOWN.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Video_Source_ARR_DOWN.Name = "Video_Source_ARR_DOWN";
            this.Video_Source_ARR_DOWN.Size = new System.Drawing.Size(41, 40);
            this.Video_Source_ARR_DOWN.TabIndex = 8;
            this.Video_Source_ARR_DOWN.Text = "↓";
            this.Video_Source_ARR_DOWN.UseVisualStyleBackColor = true;
            this.Video_Source_ARR_DOWN.Click += new System.EventHandler(this.Video_Source_ARR_DOWN_Click);
            // 
            // Video_Source_ARR_UP
            // 
            this.Video_Source_ARR_UP.Location = new System.Drawing.Point(9, 324);
            this.Video_Source_ARR_UP.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Video_Source_ARR_UP.Name = "Video_Source_ARR_UP";
            this.Video_Source_ARR_UP.Size = new System.Drawing.Size(41, 40);
            this.Video_Source_ARR_UP.TabIndex = 7;
            this.Video_Source_ARR_UP.Text = "↑";
            this.Video_Source_ARR_UP.UseVisualStyleBackColor = true;
            this.Video_Source_ARR_UP.Click += new System.EventHandler(this.Video_Source_ARR_UP_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(697, 374);
            this.button13.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(108, 40);
            this.button13.TabIndex = 6;
            this.button13.Text = "測試中";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(697, 324);
            this.button14.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(108, 40);
            this.button14.TabIndex = 5;
            this.button14.Text = "測試中";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            // 
            // Video_Save_Load
            // 
            this.Video_Save_Load.Location = new System.Drawing.Point(581, 374);
            this.Video_Save_Load.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Video_Save_Load.Name = "Video_Save_Load";
            this.Video_Save_Load.Size = new System.Drawing.Size(108, 40);
            this.Video_Save_Load.TabIndex = 4;
            this.Video_Save_Load.Text = "存取配置";
            this.Video_Save_Load.UseVisualStyleBackColor = true;
            this.Video_Save_Load.Click += new System.EventHandler(this.Video_Save_Load_Click);
            // 
            // Import_Command
            // 
            this.Import_Command.Location = new System.Drawing.Point(581, 324);
            this.Import_Command.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Import_Command.Name = "Import_Command";
            this.Import_Command.Size = new System.Drawing.Size(108, 40);
            this.Import_Command.TabIndex = 3;
            this.Import_Command.Text = "加入指令";
            this.Import_Command.UseVisualStyleBackColor = true;
            this.Import_Command.Visible = false;
            this.Import_Command.Click += new System.EventHandler(this.Import_Command_Click);
            // 
            // Delete_Item
            // 
            this.Delete_Item.Location = new System.Drawing.Point(464, 374);
            this.Delete_Item.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Delete_Item.Name = "Delete_Item";
            this.Delete_Item.Size = new System.Drawing.Size(108, 40);
            this.Delete_Item.TabIndex = 2;
            this.Delete_Item.Text = "移除項目";
            this.Delete_Item.UseVisualStyleBackColor = true;
            this.Delete_Item.Click += new System.EventHandler(this.Delete_Item_Click);
            // 
            // Import_Video
            // 
            this.Import_Video.Location = new System.Drawing.Point(464, 324);
            this.Import_Video.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Import_Video.Name = "Import_Video";
            this.Import_Video.Size = new System.Drawing.Size(108, 40);
            this.Import_Video.TabIndex = 1;
            this.Import_Video.Text = "新增影片";
            this.Import_Video.UseVisualStyleBackColor = true;
            this.Import_Video.Click += new System.EventHandler(this.Import_Video_Click);
            // 
            // Video_Source
            // 
            this.Video_Source.FormattingEnabled = true;
            this.Video_Source.HorizontalScrollbar = true;
            this.Video_Source.ItemHeight = 15;
            this.Video_Source.Location = new System.Drawing.Point(61, 323);
            this.Video_Source.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Video_Source.Name = "Video_Source";
            this.Video_Source.Size = new System.Drawing.Size(388, 94);
            this.Video_Source.TabIndex = 0;
            // 
            // Emergency_Stop_Btn
            // 
            this.Emergency_Stop_Btn.Location = new System.Drawing.Point(725, 12);
            this.Emergency_Stop_Btn.Name = "Emergency_Stop_Btn";
            this.Emergency_Stop_Btn.Size = new System.Drawing.Size(118, 23);
            this.Emergency_Stop_Btn.TabIndex = 1;
            this.Emergency_Stop_Btn.Text = "停止所有音樂";
            this.Emergency_Stop_Btn.UseVisualStyleBackColor = true;
            this.Emergency_Stop_Btn.Click += new System.EventHandler(this.Emergency_Stop_Btn_Click);
            // 
            // PlayerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 504);
            this.Controls.Add(this.Emergency_Stop_Btn);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerMenu";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.PlayerMenu_Load);
            this.Resize += new System.EventHandler(this.PlayerMenu_Resize);
            this.tabControl1.ResumeLayout(false);
            this.Music.ResumeLayout(false);
            this.Music.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Music_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGM_Player)).EndInit();
            this.Video.ResumeLayout(false);
            this.Video.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Music;
        private System.Windows.Forms.TabPage Video;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Remove_BGM;
        private System.Windows.Forms.CheckBox BGM_fade_opt;
        private System.Windows.Forms.Button Play_BGM;
        private System.Windows.Forms.ListBox BGM_Source;
        private System.Windows.Forms.Button Import_BGM;
        private System.Windows.Forms.Button BGM_Other_Op;
        private System.Windows.Forms.Button BGM_Source_ARR_DOWN;
        private System.Windows.Forms.Button BGM_Source_ARR_UP;
        private System.Windows.Forms.CheckBox pref_video_autoplay;
        private System.Windows.Forms.CheckBox pref_video_repeat;
        private System.Windows.Forms.CheckBox pref_video_msg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Video_Source_ARR_DOWN;
        private System.Windows.Forms.Button Video_Source_ARR_UP;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button Video_Save_Load;
        private System.Windows.Forms.Button Import_Command;
        private System.Windows.Forms.Button Delete_Item;
        private System.Windows.Forms.Button Import_Video;
        private System.Windows.Forms.Button Replay_BGM;
        private System.Windows.Forms.Button Start_Video;
        private AxWMPLib.AxWindowsMediaPlayer BGM_Player;
        private System.Windows.Forms.CheckBox BGM_Replay;
        private System.Windows.Forms.CheckBox BGM_autochange;
        private System.Windows.Forms.CheckBox Music_Replay;
        private System.Windows.Forms.CheckBox Music_autochange;
        private AxWMPLib.AxWindowsMediaPlayer Music_Player;
        private System.Windows.Forms.Button Replay_Music;
        private System.Windows.Forms.Button Music_Source_ARR_DOWN;
        private System.Windows.Forms.Button Music_Source_ARR_UP;
        private System.Windows.Forms.Button Remove_Music;
        private System.Windows.Forms.CheckBox Music_fade_opt;
        private System.Windows.Forms.Button Play_Music;
        private System.Windows.Forms.ListBox Music_Source;
        private System.Windows.Forms.Button Import_Music;
        private System.Windows.Forms.Button Music_Other_Op;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Audio_Save_Load;
        public System.Windows.Forms.ListBox Video_Source;
        private System.Windows.Forms.Button Emergency_Stop_Btn;
        private System.Windows.Forms.CheckBox Single_Player_Mode;
        private System.Windows.Forms.CheckBox savepref_level;
        private System.Windows.Forms.Label label4;
    }
}
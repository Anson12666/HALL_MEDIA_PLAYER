using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace HALL_MEDIA_PLAYER
{
    public partial class PlayerMenu : Form
    {
        public PlayerMenu()
        {
            InitializeComponent();
        }


        private void PlayerMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void Video_Click(object sender, EventArgs e)
        {

        }


        private void Import_Video_Click(object sender, EventArgs e)
        {
            ListBoxAction(Video_Source, "Open", "");
        }



        private void Delete_Item_Click(object sender, EventArgs e)
        {
            ListBoxAction(Video_Source, "Delete", "");
        }

        private void Video_Source_ARR_UP_Click(object sender, EventArgs e)
        {
            ListBoxAction(Video_Source, "Rearrange", "up");
        }

        private void Video_Source_ARR_DOWN_Click(object sender, EventArgs e)
        {
            ListBoxAction(Video_Source, "Rearrange","down");
        }

        private void ListBoxAction(ListBox source, string actiontype, string Args)
        {
            switch (actiontype)
            {
                case "Rearrange":
                    if (Args == "up" && source.SelectedIndex > 0)
                    {
                        int index = source.SelectedIndex;
                        object item = source.SelectedItem;
                        source.Items.RemoveAt(source.SelectedIndex);
                        source.Items.Insert(index - 1, item);
                        source.SelectedIndex = index - 1;
                    }

                    if (Args == "down" && source.SelectedIndex != source.Items.Count - 1)
                    {
                        int index = source.SelectedIndex;
                        object item = source.SelectedItem;
                        source.Items.RemoveAt(source.SelectedIndex);
                        source.Items.Insert(index + 1, item);
                        source.SelectedIndex = index + 1;
                    }
                    break;

                case "Delete":

                        ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(source);
                        selectedItems = source.SelectedItems;
                        switch (source.SelectedIndex)
                        {
                            case -1:
                                MessageBox.Show("請選擇要刪除的項目");
                                break;
                            case 0:
                            DialogResult dialogResult = MessageBox.Show("你是否確定要從播放列表中刪除" + "/n" + source.SelectedItem.ToString(), "警告", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                for (int i = selectedItems.Count - 1; i >= 0; i--)
                                    source.Items.Remove(selectedItems[i]);
                                if (source.Items.Count != 0)
                                    source.SelectedIndex = 0;
                            }
                                break;
                            default:
                            DialogResult dialogResult1 = MessageBox.Show("你是否確定要從播放列表中刪除" + "/n" + source.SelectedItem.ToString(), "警告", MessageBoxButtons.YesNo);
                            if (dialogResult1 == DialogResult.Yes)
                            {
                                var current_number = source.SelectedIndex;
                                for (int i = selectedItems.Count - 1; i >= 0; i--)
                                    source.Items.Remove(selectedItems[i]);
                                source.SelectedIndex = current_number - 1;
                            }
                                break;
                        
                    }
                    break;

                case "Open":
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Title = "Select file";
                    dialog.InitialDirectory = ".\\";
                    //dialog.Filter = "xls files (*.*)|*.xls";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        source.Items.Insert(source.SelectedIndex + 1, dialog.FileName);
                        source.SelectedIndex = source.SelectedIndex + 1;
                    }
                    if(source.Items.Count != 0)
                        source.SelectedIndex = 0;
                    
                    break;

            }
        }

        private void BGM_Source_ARR_UP_Click(object sender, EventArgs e)
        {
            ListBoxAction(BGM_Source, "Rearrange", "up");
        }

        private void BGM_Source_ARR_DOWN_Click(object sender, EventArgs e)
        {
            ListBoxAction(BGM_Source, "Rearrange", "down");
        }

        private void Import_BGM_Click(object sender, EventArgs e)
        {
            ListBoxAction(BGM_Source, "Open", "");
        }

        private void Remove_BGM_Click(object sender, EventArgs e)
        {
            ListBoxAction(BGM_Source, "Delete", "");
        }

        private void Play_BGM_Click(object sender, EventArgs e)
        {
            AudioAction(BGM_Source, BGM_Player, "play", checkpref("BGM"));
        }

        private void Replay_BGM_Click(object sender, EventArgs e)
        {
            AudioAction(BGM_Source, BGM_Player, "Replay", "");
        }

        private int BGM_volume_bef_play = 50;
        private int Music_volume_bef_play = 50;
        private int BGMorigfadetime = 0;
        private int Musicorigfadetime = 0;
        private void AudioAction(ListBox source,AxWindowsMediaPlayer Cast,string action , string Args)
        {
            switch (action)
            {
                case "play":
                    if (source.SelectedIndex != -1)
                    {

                        if (Cast == BGM_Player)
                            BGM_volume_bef_play = BGM_Player.settings.volume;
                        else
                            Music_volume_bef_play = Music_Player.settings.volume;

                        Cast.URL = source.SelectedItem.ToString();

                        Action delay = () => PlayWaittimer(source, Cast, action, Args);
                        DelayAction(500, delay);

                    }
                    else
                        MessageBox.Show("請選擇一個項目");
                    break;

                case "Replay":
                    Cast.Ctlcontrols.currentPosition = 0;
                    break;

                case "playstate":
                    if (Cast.playState == WMPLib.WMPPlayState.wmppsMediaEnded && Args.Contains("autochange"))
                    {
                        if ((!Args.Contains("replay") && Cast.URL != source.SelectedItem.ToString())||Args.Contains("replay"))
                        {
                            Action delay = () => AudioAction(source, Cast, "play", Args);
                            DelayAction(500, delay);
                        }
                    }
                    if(Cast.playState == WMPLib.WMPPlayState.wmppsPlaying && Cast.Ctlcontrols.currentPosition < 0.5 && Args.Contains("fade"))
                    {
                        fademedia(Cast, "fadein");

                        int video_length;
                        if (Cast == BGM_Player)
                            video_length = Convert.ToInt32(Cast.currentMedia.duration * 1000 - Cast.Ctlcontrols.currentPosition - (fadetime+51) * (100 - BGM_volume_bef_play));
                        else
                            video_length = Convert.ToInt32(Cast.currentMedia.duration * 1000 - Cast.Ctlcontrols.currentPosition - (fadetime+51) * (100 - Music_volume_bef_play));

                        if (video_length >= 0)
                        {
                            Action delay = () => fademedia(Cast, "fadeout");
                            DelayAction(video_length, delay);
                        }
                    }
                    break;
            }
        }

        private void PlayWaittimer(ListBox source, AxWindowsMediaPlayer Cast, string action, string Args)
        {

            if (Cast == BGM_Player)
            {
                //Convert.ToInt32(Cast.currentMedia.duration * 1000 - Cast.Ctlcontrols.currentPosition - (fadetime+51) * (100 - BGM_volume_bef_play)
                BGMorigfadetime = fadetime;
                if (Convert.ToInt32(Cast.currentMedia.duration * 1000 / 2) - Cast.Ctlcontrols.currentPosition < (fadetime+51) * (100 - BGM_volume_bef_play))
                {
                    MessageBox.Show("");
                    fadetime = Convert.ToInt32((Cast.currentMedia.duration * 1000 - Cast.Ctlcontrols.currentPosition)/2 / (100 - BGM_volume_bef_play) -51);
                }
            }
            else
            {
                Musicorigfadetime = fadetime;
                if (Convert.ToInt32(Cast.currentMedia.duration * 1000 / 2) < fadetime * (100 - Music_volume_bef_play))
                {

                    fadetime = Convert.ToInt32(Cast.currentMedia.duration * 1000 / 2);
                }
            }

            if (Single_Player_Mode.Checked)
                StopAnotherPlayer(Cast);

            if (source.SelectedIndex == source.Items.Count - 1 && Args.Contains("replay"))
                source.SelectedIndex = 0;
            else if (source.SelectedIndex != source.Items.Count - 1)
                source.SelectedIndex = source.SelectedIndex + 1;
        }

        private void BGM_Play_State_Change(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            AudioAction(BGM_Source, BGM_Player, "playstate", checkpref("BGM"));
        }

        private void Music_Play_State_Change(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            AudioAction(Music_Source, Music_Player, "playstate", checkpref("Music"));
            if (Music_Player.playState == WMPLib.WMPPlayState.wmppsPlaying && Music_fade_opt.Checked)
                fademedia(Music_Player, "fadein");
        }
        private void StopAnotherPlayer(AxWindowsMediaPlayer Cast)
        {
            if(Cast == BGM_Player)
            {
                if(Music_fade_opt.Checked)
                {

                }
                else 
                    Music_Player.Ctlcontrols.pause();
            }
            if(Cast == Music_Player)
            {
                if (BGM_fade_opt.Checked)
                {

                }
                else
                    BGM_Player.Ctlcontrols.pause();
            }
        }

        private int castvolumeusing = 0;
        private int fadetime = 50;
        private void fademedia(AxWindowsMediaPlayer Cast, string action)
        {
            switch (action)
            {
                case "fadein":
                    if (Cast.settings.volume < 100)
                    {if (castvolumeusing == 0)
                        {
                            castvolumeusing = castvolumeusing + 1;
                            Action delay0 = () => castvolumeusing = castvolumeusing - 1;
                            DelayAction(fadetime, delay0);
                            Action delay1 = () => Cast.settings.volume = Cast.settings.volume + 1;
                            DelayAction(fadetime, delay1);
                        }
                        Action delay = () => fademedia(Cast, "fadein");
                        DelayAction(50, delay);
                    }

                    break;

                case "fadeout":
                    if (Cast == BGM_Player)
                    {
                        if (Cast.settings.volume > BGM_volume_bef_play)
                        {
                            if (castvolumeusing == 0)
                            {
                                castvolumeusing = castvolumeusing + 1;
                                Action delay0 = () => castvolumeusing = castvolumeusing - 1;
                                DelayAction(fadetime, delay0);
                                Action delay1 = () => Cast.settings.volume = Cast.settings.volume - 1;
                                DelayAction(fadetime, delay1);
                                Action delay = () => fademedia(Cast, "fadeout");
                                DelayAction(50, delay);
                            }
                        }
                    }
                    else
                    {
                        if (Cast.settings.volume > Music_volume_bef_play)
                        {
                            if (castvolumeusing == 0)
                            {
                                castvolumeusing = castvolumeusing + 1;
                                Action delay0 = () => castvolumeusing = castvolumeusing - 1;
                                DelayAction(fadetime, delay0);
                                Action delay1 = () => Cast.settings.volume = Cast.settings.volume - 1;
                                DelayAction(fadetime, delay1);
                            }
                            Action delay = () => fademedia(Cast, "fadeout");
                            DelayAction(50, delay);
                        }
                    }
                    if (Cast == BGM_Player)
                        fadetime = BGMorigfadetime;
                    else
                        fadetime = Musicorigfadetime;

                    break;
            }
        }
        private string checkpref(string inputtype)
        {
            var Args = "";
            if (inputtype.Contains("BGM"))
            {
                if (BGM_autochange.Checked)
                    Args = "autochange";
                if (BGM_Replay.Checked)
                    Args = Args + " replay";
                if(BGM_fade_opt.Checked)
                    Args = Args + " fade";
            }
            if (inputtype.Contains("Music"))
            {
                if (Music_autochange.Checked)
                    Args = "autochange";
                if (Music_Replay.Checked)
                    Args = Args + " replay";
                if (Music_fade_opt.Checked)
                    Args = Args + " fade";
            }
            return Args;
        }

        private void DelayAction(int millisecond, Action action)
        {
            var timer = new DispatcherTimer();
            timer.Tick += delegate

            {
                action.Invoke();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromMilliseconds(millisecond);
            timer.Start();
        }


        private void Import_Music_Click(object sender, EventArgs e)
        {
            ListBoxAction(Music_Source, "Open", "");
        }

        private void Remove_Music_Click(object sender, EventArgs e)
        {
            ListBoxAction(Music_Source, "Delete", "");
        }

        private void Music_Source_ARR_UP_Click(object sender, EventArgs e)
        {
            ListBoxAction(Music_Source, "Rearrange", "up");
        }

        private void Music_Source_ARR_DOWN_Click(object sender, EventArgs e)
        {
            ListBoxAction(Music_Source, "Rearrange", "down");
        }

        private void Play_Music_Click(object sender, EventArgs e)
        {
            AudioAction(Music_Source, Music_Player, "play", checkpref("Music"));
        }

        private void Replay_Music_Click(object sender, EventArgs e)
        {
            AudioAction(Music_Source, Music_Player, "Replay", "");
        }

        
        public void Start_Video_Click(object sender, EventArgs e)
        {
            VideoPlayer vplayer = new VideoPlayer();
            VideoPlayer.getArgs = checkvideoargs();
            string[] clist = Video_Source.Items.OfType<string>().ToArray();
            VideoPlayer.getURLs = clist;
            VideoPlayer.sourceselectedindex = Video_Source.SelectedIndex;
            if(Video_Source.Items.Count>0)
            vplayer.Show();

        }

        private string checkvideoargs()
        {
            var output = "";
            if (pref_video_msg.Checked)
                output = output + "msg";
            if (pref_video_repeat.Checked)
                output = output + "replay";
            if (pref_video_autoplay.Checked)
                output = output + "autochange";
            return output;
        }



        private void BGM_Play_Pos_Change(object sender, _WMPOCXEvents_DurationUnitChangeEvent e)
        {
            MessageBox.Show("");
            fademedia(BGM_Player, "fadein");
        }

        private void Music_Other_Op_Click(object sender, EventArgs e)
        {

        }

        private void BGM_Other_Op_Click(object sender, EventArgs e)
        {

        }

        private void Video_Save_Load_Click(object sender, EventArgs e)
        {
            load_save_files(Video_Source);
        }

        private void Audio_Save_Load_Click(object sender, EventArgs e)
        {
            var source = InputBox("讀取/儲存音頻", "請選擇模式", "BGM", "Music");
            if (source == DialogResult.OK)//BGM
            {
                load_save_files(BGM_Source);
            }
            if (source == DialogResult.Yes)//Music
            {
                load_save_files(Music_Source);
            }
        }

        private void load_save_files(ListBox target)
        {
            var mode = InputBox("讀取/儲存音頻", "請選擇模式", "讀取", "儲存");
            if (mode == DialogResult.OK)//Load
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select file";
                dialog.InitialDirectory = ".\\";
                dialog.Filter = "txt files (*.*)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (target.Items.Count != 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("你是否要先刪除列表項目", "選項", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                            target.Items.Clear();
                    }
                    string sPath = dialog.FileName;
                    var lines = File.ReadAllLines(sPath);
                    target.Items.AddRange(lines);
                    if (target.Items.Count != 0)
                        target.SelectedIndex = 0;
                }
            }
            if (mode == DialogResult.Yes)//Save
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.*)|*.txt";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog.FileName != "")
                {
                    string sPath = saveFileDialog.FileName;
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                    foreach (var item in target.Items)
                    {
                        SaveFile.WriteLine(item);
                    }
                    SaveFile.Close();
                    MessageBox.Show("Programs saved!");
                }
            }
        }

        public static DialogResult InputBox(string title, string promptText, string btnlefttext, string btnrighttxt)
        {
            Form form = new Form();
            Label label = new Label();
            Button buttonSave = new Button();
            Button buttonLoad = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonSave.Text = btnrighttxt;
            buttonLoad.Text = btnlefttext;
            buttonCancel.Text = "取消";
            buttonSave.DialogResult = DialogResult.Yes;
            buttonLoad.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            buttonSave.SetBounds(228, 72, 75, 23);
            buttonLoad.SetBounds(147, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, buttonSave, buttonLoad, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            //value = textBox.Text;
            return dialogResult;
        }

        private void Import_Command_Click(object sender, EventArgs e)
        {

        }

        private void Emergency_Stop_Btn_Click(object sender, EventArgs e)
        {
            BGM_Player.Ctlcontrols.pause();
            Music_Player.Ctlcontrols.pause();
        }


        private void PlayerMenu_Resize(object sender, EventArgs e)
        {

        }

        private void BGM_fade_opt_CheckedChanged(object sender, EventArgs e)
        {
            if (BGM_fade_opt.Checked && !Music_fade_opt.Checked)
            {
                string value = fadetime.ToString();
                if (InputBox("淡入淡出", "請輸入淡入淡出時間", ref value) == DialogResult.OK)
                {
                    fadetime = Int32.Parse(value);
                }
            }
        }

        private void Music_fade_opt_CheckedChanged(object sender, EventArgs e)
        {
            if (Music_fade_opt.Checked && !BGM_fade_opt.Checked)
            {
                string value = fadetime.ToString();
                if (InputBox("淡入淡出", "請輸入淡入淡出時間", ref value) == DialogResult.OK)
                {
                    fadetime = Int32.Parse(value);
                }
            }
        }

        private static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}

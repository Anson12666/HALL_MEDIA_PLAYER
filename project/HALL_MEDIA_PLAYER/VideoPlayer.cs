using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace HALL_MEDIA_PLAYER
{
    public partial class VideoPlayer : Form
    {
        public static string[] getURLs;
        public static string getArgs;
        public static int sourceselectedindex;
        public static int delayactionstatus = 0;

        public VideoPlayer()
        {
            InitializeComponent();
            Application.AddMessageFilter(new IgnoreMouseClickMessageFilter(this, Video_Player));
        }

        private void Video_Player_Load(object sender, EventArgs e)
        {
            delayactionstatus = 0;
            Video_Player.Width = Convert.ToInt32(this.Width);
            Video_Player.Height = Convert.ToInt32(this.Height);
            Video_Player.uiMode = "none";
            Video_Player.enableContextMenu = false;
            Video_Player.fullScreen = false;
            Video_Player.stretchToFit = true;
            Video_Player.TabStop = false;
            Video_Player.UseWaitCursor = true;
            Video_Player.windowlessVideo = true;

            Video_Source.Items.Clear();
            for (int i = 0; i < getURLs.Length; i++)
                Video_Source.Items.Add(getURLs[i].ToString());
            Video_Source.SelectedIndex = sourceselectedindex;

            VideoAction(Video_Source, Video_Player, "play", "");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    if (delayactionstatus == 0)
                    {
                        delayactionstatus = -1;
                        Action delay0 = () => this.Close();
                        DelayAction(500, delay0);


                    }
                    else
                        MessageBox.Show("請等待5秒再關閉 (ref.uimodedelay_" + delayactionstatus + ")");

                    return true;    // indicate that you handled this keystroke

                case Keys.Space:
                    if (Video_Player.playState == WMPLib.WMPPlayState.wmppsPlaying) //Playing
                    {
                        Action delay01 = () => Video_Player.Ctlcontrols.pause();
                        DelayAction(100, delay01);
                    }
                    if (Video_Player.playState == WMPLib.WMPPlayState.wmppsPaused) //Playing
                    {
                        Action delay02 = () => Video_Player.Ctlcontrols.play();
                        DelayAction(100, delay02);
                    }
                    return true;    // indicate that you handled this keystroke

                case Keys.R:
                    VideoAction(Video_Source, Video_Player, "Replay", "");
                    return true;    // indicate that you handled this keystroke

                default:

                    Video_Player.uiMode = "full";
                    delayactionstatus = delayactionstatus + 1;
                    if (delayactionstatus == 1)
                    {
                        Action delay1 = () => Video_Player.uiMode = "none";
                        DelayAction(4000, delay1);
                    }
                    Action delay2 = () => delayactionstatus = delayactionstatus - 1;
                    DelayAction(6000, delay2);
                    break;

            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void DelayAction(int millisecond, Action action)
        {
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += delegate

            {
                action.Invoke();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromMilliseconds(millisecond);
            timer.Start();
        }

        private void VideoAction(ListBox source, AxWindowsMediaPlayer Cast, string action, string Args)
        {
            switch (action)
            {
                case "play":
                    if (source.SelectedIndex != -1)
                    {
                        Cast.URL = source.SelectedItem.ToString();
                        if (source.SelectedIndex == source.Items.Count - 1 && getArgs.Contains("replay"))
                            source.SelectedIndex = 0;
                        else if (source.SelectedIndex != source.Items.Count - 1)
                            source.SelectedIndex = source.SelectedIndex + 1;
                    }
                    else
                        MessageBox.Show("請選擇一個項目");
                    break;

                case "Replay":
                    Cast.Ctlcontrols.currentPosition = 0;
                    break;

                case "playstate":
                    if (Cast.playState == WMPLib.WMPPlayState.wmppsMediaEnded && Cast.URL != source.SelectedItem.ToString() && getArgs.Contains("autochange"))
                    {
                        Action delay = () => VideoAction(source, Cast, "play", Args);
                        DelayAction(500, delay);
                    }
                    break;
            }
        }

        private void Video_Play_State_Change(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            VideoAction(Video_Source, Video_Player, "playstate", "autochange replay");
        }

        private static int mousemovetimer = 0;
        private static Point mousemovedist = Cursor.Position;
        private void MouseMoving(object sender, _WMPOCXEvents_MouseMoveEvent e)
        {
            videoshowtext();
            if ((mousemovedist.X != Cursor.Position.X || mousemovedist.Y != Cursor.Position.Y)&&getArgs.Contains("msg"))
            {
                mousemovedist = Cursor.Position;
                Video_Info_TXT.Visible = true;

                if (mousemovetimer == 0)
                {
                    mousemovetimer = mousemovetimer + 1;
                    Action delay = () => Video_Info_TXT.Visible = false;
                    DelayAction(1500, delay);
                    Action delay1 = () => mousemovetimer = mousemovetimer - 1;
                    DelayAction(1500, delay1);
                }
            }
        }

        private void videoshowtext()
        {
            TimeSpan timecurrent = TimeSpan.FromSeconds(Video_Player.Ctlcontrols.currentPosition);
            string currenttime = timecurrent.ToString(@"hh\:mm\:ss");
            TimeSpan timetotal = TimeSpan.FromSeconds(Video_Player.currentMedia.duration);
            string totaltime = timetotal.ToString(@"hh\:mm\:ss");
            var outputtext = "播放進度："+ currenttime + "/" + totaltime;
            Video_Info_TXT.Text = outputtext;
        }

        internal static void getArgscheckvideoargs()
        {
            throw new NotImplementedException();
        }
    }

    class IgnoreMouseClickMessageFilter : IMessageFilter
    {
        private Control parent { get; set; }
        private Control target { get; set; }

        public IgnoreMouseClickMessageFilter(Control parent, Control target)
        {
            this.parent = parent;
            this.target = target;
        }

        public bool PreFilterMessage(ref Message messageBeforeFiltering)
        {
            const Boolean FilterTheMessageOut = true;
            const Boolean LetTheMessageThrough = false;

            if (IsNull(parent)) return LetTheMessageThrough;
            if (IsNull(target)) return LetTheMessageThrough;
            if (WasNotClickedOnTarget(parent, target)) return LetTheMessageThrough;
            if (MessageContainsAnyMousebutton(messageBeforeFiltering)) return FilterTheMessageOut;
            return LetTheMessageThrough;
        }

        private bool MessageContainsAnyMousebutton(Message message)
        {
            //if (message.Msg == 0x202) return true; /* WM_LBUTTONUP*/
            if (message.Msg == 0x203) return true; /* WM_LBUTTONDBLCLK*/
            //if (message.Msg == 0x204) return true; /* WM_RBUTTONDOWN */
            //if (message.Msg == 0x205) return true; /* WM_RBUTTONUP */
            return false;
        }

        private bool WasNotClickedOnTarget(Control parent, Control target)
        {
            try
            {
                Control clickedOn = parent.GetChildAtPoint(Cursor.Position);
            if (IsNull(clickedOn)) return true;
            if (AreEqual(clickedOn, target)) return false;
            }
            catch { }
            return true;
        }

        private bool AreEqual(Control controlA, Control controlB)
        {
            if (controlA == controlB) return true;
            return false;
        }

        private bool IsNull(Control control)
        {
            if (control == null) return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using AutoUpdaterDotNET;

namespace HALL_MEDIA_PLAYER
{
    public partial class IntroPage : Form
    {
        public IntroPage()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                MessageBox.Show(System.Reflection.Assembly.GetEntryAssembly().Location +"\n" + System.Reflection.Assembly.GetExecutingAssembly().ToString());
                return true;    // indicate that you handled this keystroke
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void Start_Program_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerMenu MenuP = new PlayerMenu();
            MenuP.ShowDialog();
            this.Close();
        }

        private void Check_Update_Btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click_FistPage_UPDATE" + new DirectoryInfo(Environment.CurrentDirectory).FullName);
            UpdateProgram("Auto");
        }



        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //nameSpace = the namespace of your project, located right above your class' name;
            //outDirectory = where the file will be extracted to;
            //internalFilePath = the name of the folder inside visual studio which the files are in;
            //resourceName = the name of the file;
            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                w.Write(r.ReadBytes((int)s.Length));
            }
        }

        private void IntroPage_Load(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                MessageBox.Show("應用程式已經開啓，請先關閉現有程式。若以上操作無效，請重新登入Windows！");
                Environment.Exit(0);
            }
            if (!System.Reflection.Assembly.GetEntryAssembly().Location.Contains(@"\HALL_MEDIA_PLAYER.exe"))
            {
                DialogResult dialogResult = MessageBox.Show("應用程序名稱不正確，正在重新開啓。如仍有問題請點擊“Yes”重新下載！", "錯誤", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/Anson12666/HALL_MEDIA_PLAYER/blob/master/HALL_MEDIA_PLAYER.exe?raw=true");
                    Environment.Exit(0);
                }
                else
                {
                    if (File.Exists("HALL_MEDIA_PLAYER.exe"))
                        System.Diagnostics.Process.Start("HALL_MEDIA_PLAYER.exe");
                    else
                    {
                        Extract("HALL_MEDIA_PLAYER", Environment.CurrentDirectory, "Ext", "HALL_MEDIA_PLAYER.exe");
                        System.Diagnostics.Process.Start("HALL_MEDIA_PLAYER.exe");
                    }
                        Environment.Exit(0);
                }
            }

            string[] patches = new string[] { "AutoUpdater.NET.dll", "AxInterop.WMPLib.dll", "Interop.WMPLib.dll" };
            for (int i = 0; i < patches.Length; i++)
            {
                if (!(File.Exists(patches[i])))
                {
                    String local = Environment.CurrentDirectory; //gets current path to extract the files
                    Extract("HALL_MEDIA_PLAYER", local, "DLL", patches[i]);
                }
            }

            if(!(File.Exists("stopupdatethisthinggggg.testonly")))
            UpdateProgram("Emergency");
        }

        private void UpdateProgram(string updatemode)
        {
            AutoUpdater.InstallationPath = new DirectoryInfo(Environment.CurrentDirectory).FullName;
            AutoUpdater.RunUpdateAsAdmin = false;
            AutoUpdater.LetUserSelectRemindLater = false;
            switch (updatemode)
            {
                case "Auto":
                    AutoUpdater.ReportErrors = true; 
                    AutoUpdater.Start("https://raw.githubusercontent.com/Anson12666/HALL_MEDIA_PLAYER/master/AutoupdateService.xml");
                    break;
                case "Emergency":
                    AutoUpdater.Start("https://raw.githubusercontent.com/Anson12666/HALL_MEDIA_PLAYER/master/EmergencyupdateService.xml");
                    break;
            }
            AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
            void AutoUpdater_ApplicationExitEvent()
            {
                Text = @"Closing application...";
                Thread.Sleep(2500);
                Application.Exit();
            }
        }
    }
}

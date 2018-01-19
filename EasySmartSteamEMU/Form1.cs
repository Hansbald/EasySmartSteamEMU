using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasySmartSteamEMU
{
    public partial class frmMain : Form
    {

        private Icon _exeIcon;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            File.WriteAllBytes(Path.GetTempPath() + "\\rh.exe", EasySmartSteamEMU.Properties.Resources.ResourceHacker);
            cbExeIcon.Checked = true;
            cb64Bit.Checked = true;

            if (Environment.GetCommandLineArgs().Length > 1 && Environment.GetCommandLineArgs()[1].EndsWith(".exe"))
            {
                ExtractIcon(Path.GetFileName(Environment.GetCommandLineArgs()[1]));
                CreateSSE(Environment.GetCommandLineArgs()[1]);
                CleanUp();
                Environment.Exit(0);
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (!tbPath.Text.EndsWith(".exe"))
            {
                MessageBox.Show("Please Choose Path.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateSSE(tbPath.Text);
        }

        private void CreateSSE(string path)
        {
            string exeName = Path.GetFileName(path);
            string dir = Path.GetDirectoryName(path);

            //Copy Files
            File.WriteAllText(dir + "\\SmartSteamEmu.ini", EasySmartSteamEMU.Properties.Resources.SmartSteamEmuINI);
            if (cb64Bit.Checked)
            {
                File.WriteAllBytes(dir + "\\Launcher_64.exe", EasySmartSteamEMU.Properties.Resources.Launcher_x64);
                File.WriteAllBytes(dir + "\\SmartSteamEmu64.dll", EasySmartSteamEMU.Properties.Resources.SmartSteamEmu64);
            }
            else
            {
                File.WriteAllBytes(dir + "\\Launcher.exe", EasySmartSteamEMU.Properties.Resources.Launcher);
                File.WriteAllBytes(dir + "\\SmartSteamEmu.dll", EasySmartSteamEMU.Properties.Resources.SmartSteamEmuDLL);
            }

            //Change Icons
            if (cbExeIcon.Checked && cb64Bit.Checked)
            {
                Console.WriteLine("Changing 64Bit exe icon...");
                Console.WriteLine(Path.GetTempPath() + "rh.exe" + " " + String.Format("-open \"{0}\" -save \"{0}\" -action addskip -res \"{1}\" -mask ICONGROUP,MAINICON,", dir + "\\Launcher_64.exe", Path.GetTempPath() + "Icon.ico"));
                Process.Start(Path.GetTempPath() + "rh.exe", String.Format("-open \"{0}\" -save \"{0}\" -action addskip -res \"{1}\" -mask ICONGROUP,MAINICON,", dir + "\\Launcher_64.exe", Path.GetTempPath() + "Icon.ico"));
            }
            else if (cbExeIcon.Checked && !cb64Bit.Checked)
            {
                Console.WriteLine("Changing 32Bit exe icon...");
                Process.Start(Path.GetTempPath() + "rh.exe", String.Format("-open \"{0}\" -save \"{0}\" -action addskip -res \"{1}\" -mask ICONGROUP,MAINICON,", dir + "\\Launcher.exe", Path.GetTempPath() + "Icon.ico"));
            }

            //Change Ini
            string iniFile = File.ReadAllText(dir + "\\SmartSteamEmu.ini");
            iniFile = iniFile.Replace("%REPLACEME%", Path.GetFileName(exeName));
            File.WriteAllText(dir + "\\SmartSteamEmu.ini", iniFile);
        }

        private void ExtractIcon(string fileName)
        {
            Process.Start(Path.GetTempPath() + "rh.exe", String.Format("-open \"{0}\" -save {1}savedicons.rc -action extract -mask ICONGROUP,,", fileName, Path.GetTempPath()));
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            File.Delete(Path.GetTempPath() + "Icon.ico");
            OpenFileDialog browseDialog = new OpenFileDialog();

            browseDialog.InitialDirectory = @"D:\VR\Cracked Games\";
            browseDialog.Filter = "Executable files (*.exe)|*.exe";
            browseDialog.RestoreDirectory = true;

            if (browseDialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = browseDialog.FileName;

            }
            else
            {
                return;
            }

            _exeIcon = Icon.ExtractAssociatedIcon(browseDialog.FileName);      
            imgIcon.Image = _exeIcon.ToBitmap();

            //Extract Icon
            Console.WriteLine(Path.GetTempPath() + "rh.exe" + " " + String.Format("-open \"{0}\" -save {1}savedicons.rc -action extract -mask ICONGROUP,,", browseDialog.FileName, Path.GetTempPath()));
            ExtractIcon(browseDialog.FileName);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
            CleanUp();
        }

        private void CleanUp()
        {
            //Delete Files
            File.Delete(Path.GetTempPath() + "Icon.ico");
            File.Delete(Path.GetTempPath() + "savedicons.rc");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Created by Hansbald");
        }

        private void tbPath_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}

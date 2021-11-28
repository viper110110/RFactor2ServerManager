using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = System.IO.File;

namespace RFactor2ServerManager
{
    public partial class RFactor2ServerManager : Form
    {
        private string steamCmdDir;
        private string serverDir;
        private string[] packages;
        public RFactor2ServerManager()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void RFactor2ServerManager_Load(object sender, EventArgs e)
        {

        }

        private void steamCmdDirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                steamCmdDir = folderBrowserDialog1.SelectedPath;
                steamCmdDirLbl.Text = steamCmdDir;
            }

            UpdatePackageList();
        }

        private void installDirBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                serverDir = folderBrowserDialog1.SelectedPath;
                serverDirLbl.Text = serverDir;
            }
        }

        private void installServerBtn_Click(object sender, EventArgs e)
        {
            var result = RunSteamCmd("+force_install_dir " + serverDir + " +app_update 400300 +quit");
            serverInstallLbl.Text = "Exit code: " + result;
            CreateShortcut();
        }

        private void UpdatePackageList()
        {
            string packageFolder = steamCmdDir + @"\steamapps\workshop\content\365960";
            packages = Directory.GetDirectories(packageFolder);
            debugLabel.Text = packageFolder + " Count: " + packages.Length;
            packagesListBox.Items.Clear();
            packagesListBox.Items.AddRange(packages);
        }

        private void CopyFiles(string sourceDir, string destDir)
        {
            foreach (var file in Directory.GetFiles(sourceDir))
            {
                var fileName = file.Split(@"\").Last();
                File.Copy(file, destDir + @"\" + fileName, true); // Allow overwriting because that's how we update
            }
        }

        private void copyPackageBtn_Click(object sender, EventArgs e)
        {
            foreach (var packageFolder in packages)
            {
                CopyFiles(packageFolder, serverDir + @"\Packages");
            }
        }

        private void addPackageText_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPackageButton_Click(object sender, EventArgs e)
        {
            var result = RunSteamCmd("+workshop_download_item 365960 " + addPackageText.Text + " +quit");
            packageAddResultLbl.Text = "Package " + addPackageText.Text + " add result: " + result;
            UpdatePackageList();
        }

        /// <summary>
        /// Runs steamcmd.exe with whatever command arguments are requested
        /// </summary>
        /// <param name="command"></param>
        /// <returns>exit code of steamcmd.exe</returns>
        private int RunSteamCmd(string command)
        {
            var p = new Process
            {
                StartInfo =
                {
                    FileName = steamCmdDir + @"\steamcmd.exe",
                    WorkingDirectory = steamCmdDir,
                    Arguments = "+login anonymous " + command
                }
            };

            p.Start();
            p.WaitForExit();
            return p.ExitCode;
        }

        private void CreateShortcut()
        {
            WshShell shell = new WshShell();
            string shortcutAddress = serverDir + @"\Bin64\rfactor2-dedicated-shortcut.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);

            shortcut.Description = "Shortcut to start server";
            shortcut.TargetPath = serverDir + @"\Bin64\rfactor2 Dedicated.exe";
            shortcut.WorkingDirectory = serverDir + @"\Bin64";
            shortcut.Arguments = "+path=\"..\"";
            
            shortcut.Save();
        }
    }
}

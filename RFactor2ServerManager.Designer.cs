
namespace RFactor2ServerManager
{
    partial class RFactor2ServerManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.steamCmdDirBtn = new System.Windows.Forms.Button();
            this.installDirBtn = new System.Windows.Forms.Button();
            this.steamCmdDirLbl = new System.Windows.Forms.Label();
            this.serverDirLbl = new System.Windows.Forms.Label();
            this.installServerBtn = new System.Windows.Forms.Button();
            this.serverInstallLbl = new System.Windows.Forms.Label();
            this.packagesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.copyPackageBtn = new System.Windows.Forms.Button();
            this.copyPackageLbl = new System.Windows.Forms.Label();
            this.addPackageText = new System.Windows.Forms.TextBox();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.packageAddResultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // steamCmdDirBtn
            // 
            this.steamCmdDirBtn.Location = new System.Drawing.Point(18, 30);
            this.steamCmdDirBtn.Name = "steamCmdDirBtn";
            this.steamCmdDirBtn.Size = new System.Drawing.Size(190, 40);
            this.steamCmdDirBtn.TabIndex = 0;
            this.steamCmdDirBtn.Text = "SteamCMD directory";
            this.steamCmdDirBtn.UseVisualStyleBackColor = true;
            this.steamCmdDirBtn.Click += new System.EventHandler(this.steamCmdDirBtn_Click);
            // 
            // installDirBtn
            // 
            this.installDirBtn.Location = new System.Drawing.Point(18, 90);
            this.installDirBtn.Name = "installDirBtn";
            this.installDirBtn.Size = new System.Drawing.Size(240, 41);
            this.installDirBtn.TabIndex = 1;
            this.installDirBtn.Text = "Server installation directory";
            this.installDirBtn.UseVisualStyleBackColor = true;
            this.installDirBtn.Click += new System.EventHandler(this.installDirBtn_Click);
            // 
            // steamCmdDirLbl
            // 
            this.steamCmdDirLbl.AutoSize = true;
            this.steamCmdDirLbl.Location = new System.Drawing.Point(223, 38);
            this.steamCmdDirLbl.Name = "steamCmdDirLbl";
            this.steamCmdDirLbl.Size = new System.Drawing.Size(121, 25);
            this.steamCmdDirLbl.TabIndex = 2;
            this.steamCmdDirLbl.Text = "E:\\SteamCMD";
            // 
            // serverDirLbl
            // 
            this.serverDirLbl.AutoSize = true;
            this.serverDirLbl.Location = new System.Drawing.Point(279, 98);
            this.serverDirLbl.Name = "serverDirLbl";
            this.serverDirLbl.Size = new System.Drawing.Size(215, 25);
            this.serverDirLbl.TabIndex = 4;
            this.serverDirLbl.Text = "E:\\rf2\\rfactor2-dedicated\\";
            // 
            // installServerBtn
            // 
            this.installServerBtn.Location = new System.Drawing.Point(18, 151);
            this.installServerBtn.Name = "installServerBtn";
            this.installServerBtn.Size = new System.Drawing.Size(130, 34);
            this.installServerBtn.TabIndex = 5;
            this.installServerBtn.Text = "Install Server";
            this.installServerBtn.UseVisualStyleBackColor = true;
            this.installServerBtn.Click += new System.EventHandler(this.installServerBtn_Click);
            // 
            // serverInstallLbl
            // 
            this.serverInstallLbl.AutoSize = true;
            this.serverInstallLbl.Location = new System.Drawing.Point(175, 156);
            this.serverInstallLbl.Name = "serverInstallLbl";
            this.serverInstallLbl.Size = new System.Drawing.Size(87, 25);
            this.serverInstallLbl.TabIndex = 6;
            this.serverInstallLbl.Text = "Exit code:";
            // 
            // packagesListBox
            // 
            this.packagesListBox.FormattingEnabled = true;
            this.packagesListBox.ItemHeight = 25;
            this.packagesListBox.Location = new System.Drawing.Point(610, 41);
            this.packagesListBox.Name = "packagesListBox";
            this.packagesListBox.Size = new System.Drawing.Size(902, 404);
            this.packagesListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Downloaded Packages";
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(95, 457);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(64, 25);
            this.debugLabel.TabIndex = 9;
            this.debugLabel.Text = "debug";
            // 
            // copyPackageBtn
            // 
            this.copyPackageBtn.Location = new System.Drawing.Point(18, 204);
            this.copyPackageBtn.Name = "copyPackageBtn";
            this.copyPackageBtn.Size = new System.Drawing.Size(199, 34);
            this.copyPackageBtn.TabIndex = 10;
            this.copyPackageBtn.Text = "Copy package content";
            this.copyPackageBtn.UseVisualStyleBackColor = true;
            this.copyPackageBtn.Click += new System.EventHandler(this.copyPackageBtn_Click);
            // 
            // copyPackageLbl
            // 
            this.copyPackageLbl.AutoSize = true;
            this.copyPackageLbl.Location = new System.Drawing.Point(234, 209);
            this.copyPackageLbl.Name = "copyPackageLbl";
            this.copyPackageLbl.Size = new System.Drawing.Size(87, 25);
            this.copyPackageLbl.TabIndex = 11;
            this.copyPackageLbl.Text = "Exit code:";
            // 
            // addPackageText
            // 
            this.addPackageText.Location = new System.Drawing.Point(610, 488);
            this.addPackageText.Name = "addPackageText";
            this.addPackageText.Size = new System.Drawing.Size(336, 31);
            this.addPackageText.TabIndex = 12;
            this.addPackageText.TextChanged += new System.EventHandler(this.addPackageText_TextChanged);
            // 
            // addPackageButton
            // 
            this.addPackageButton.Location = new System.Drawing.Point(968, 486);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(139, 34);
            this.addPackageButton.TabIndex = 13;
            this.addPackageButton.Text = "Add Package";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // packageAddResultLbl
            // 
            this.packageAddResultLbl.AutoSize = true;
            this.packageAddResultLbl.Location = new System.Drawing.Point(968, 527);
            this.packageAddResultLbl.Name = "packageAddResultLbl";
            this.packageAddResultLbl.Size = new System.Drawing.Size(55, 25);
            this.packageAddResultLbl.TabIndex = 14;
            this.packageAddResultLbl.Text = "result";
            // 
            // RFactor2ServerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2679, 810);
            this.Controls.Add(this.packageAddResultLbl);
            this.Controls.Add(this.addPackageButton);
            this.Controls.Add(this.addPackageText);
            this.Controls.Add(this.copyPackageLbl);
            this.Controls.Add(this.copyPackageBtn);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packagesListBox);
            this.Controls.Add(this.serverInstallLbl);
            this.Controls.Add(this.installServerBtn);
            this.Controls.Add(this.serverDirLbl);
            this.Controls.Add(this.steamCmdDirLbl);
            this.Controls.Add(this.installDirBtn);
            this.Controls.Add(this.steamCmdDirBtn);
            this.Name = "RFactor2ServerManager";
            this.Text = "RFactor 2 Server Manager";
            this.Load += new System.EventHandler(this.RFactor2ServerManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button steamCmdDirBtn;
        private System.Windows.Forms.Button installDirBtn;
        private System.Windows.Forms.Label steamCmdDirLbl;
        private System.Windows.Forms.Label serverDirLbl;
        private System.Windows.Forms.Button installServerBtn;
        private System.Windows.Forms.Label serverInstallLbl;
        private System.Windows.Forms.ListBox packagesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Button copyPackageBtn;
        private System.Windows.Forms.Label copyPackageLbl;
        private System.Windows.Forms.TextBox addPackageText;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.Label packageAddResultLbl;
    }
}


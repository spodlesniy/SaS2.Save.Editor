namespace SaS2.Save.Editor.Desktop
{
    partial class FormRequirementsCheck
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
            groupBoxGameFolder = new GroupBox();
            buttonBrowse = new Button();
            textGameFolderPath = new TextBox();
            folderBrowseGameFolderPath = new FolderBrowserDialog();
            groupBoxLog = new GroupBox();
            textLogs = new TextBox();
            groupBoxGameFolder.SuspendLayout();
            groupBoxLog.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxGameFolder
            // 
            groupBoxGameFolder.Controls.Add(buttonBrowse);
            groupBoxGameFolder.Controls.Add(textGameFolderPath);
            groupBoxGameFolder.Dock = DockStyle.Top;
            groupBoxGameFolder.Location = new Point(0, 0);
            groupBoxGameFolder.Name = "groupBoxGameFolder";
            groupBoxGameFolder.Size = new Size(800, 59);
            groupBoxGameFolder.TabIndex = 0;
            groupBoxGameFolder.TabStop = false;
            groupBoxGameFolder.Text = "Game Folder";
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(713, 21);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 23);
            buttonBrowse.TabIndex = 1;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // textGameFolderPath
            // 
            textGameFolderPath.Location = new Point(6, 22);
            textGameFolderPath.Name = "textGameFolderPath";
            textGameFolderPath.ReadOnly = true;
            textGameFolderPath.Size = new Size(701, 23);
            textGameFolderPath.TabIndex = 0;
            // 
            // folderBrowseGameFolderPath
            // 
            folderBrowseGameFolderPath.AddToRecent = false;
            folderBrowseGameFolderPath.OkRequiresInteraction = true;
            folderBrowseGameFolderPath.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowseGameFolderPath.ShowNewFolderButton = false;
            folderBrowseGameFolderPath.ShowPinnedPlaces = false;
            // 
            // groupBoxLog
            // 
            groupBoxLog.Controls.Add(textLogs);
            groupBoxLog.Dock = DockStyle.Fill;
            groupBoxLog.Location = new Point(0, 59);
            groupBoxLog.Name = "groupBoxLog";
            groupBoxLog.Size = new Size(800, 391);
            groupBoxLog.TabIndex = 1;
            groupBoxLog.TabStop = false;
            groupBoxLog.Text = "Log";
            // 
            // textLogs
            // 
            textLogs.Dock = DockStyle.Fill;
            textLogs.Location = new Point(3, 19);
            textLogs.Multiline = true;
            textLogs.Name = "textLogs";
            textLogs.ReadOnly = true;
            textLogs.ScrollBars = ScrollBars.Vertical;
            textLogs.Size = new Size(794, 369);
            textLogs.TabIndex = 0;
            // 
            // FormRequirementsCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxLog);
            Controls.Add(groupBoxGameFolder);
            Name = "FormRequirementsCheck";
            Text = "Check Requirements";
            Shown += FormRequirementsCheck_Shown;
            groupBoxGameFolder.ResumeLayout(false);
            groupBoxGameFolder.PerformLayout();
            groupBoxLog.ResumeLayout(false);
            groupBoxLog.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGameFolder;
        private Button buttonBrowse;
        private TextBox textGameFolderPath;
        private FolderBrowserDialog folderBrowseGameFolderPath;
        private GroupBox groupBoxLog;
        private TextBox textLogs;
    }
}
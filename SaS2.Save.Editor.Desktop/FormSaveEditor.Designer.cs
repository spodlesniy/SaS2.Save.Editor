namespace SaS2.Save.Editor.Desktop
{
    partial class FormSaveEditor
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
            dialogOpenSaveFile = new OpenFileDialog();
            textSaveFilePath = new TextBox();
            buttonOpenSaveFile = new Button();
            textLogs = new TextBox();
            panelSaveDetails = new Panel();
            saveDetails = new SaS2.Save.Editor.Controls.SaveDetails();
            labelNoSaveFileSelected = new Label();
            buttonOpenWriteFile = new Button();
            dialogOpenWriteFile = new SaveFileDialog();
            panelFIlesAndDirs = new Panel();
            labelSaveFilePath = new Label();
            textGameDir = new TextBox();
            labelGameDir = new Label();
            panelSaveDetails.SuspendLayout();
            panelFIlesAndDirs.SuspendLayout();
            SuspendLayout();
            // 
            // dialogOpenSaveFile
            // 
            dialogOpenSaveFile.AddToRecent = false;
            dialogOpenSaveFile.Filter = "Save files|*.slv|All files|*.*";
            dialogOpenSaveFile.RestoreDirectory = true;
            dialogOpenSaveFile.ShowHiddenFiles = true;
            dialogOpenSaveFile.SupportMultiDottedExtensions = true;
            // 
            // textSaveFilePath
            // 
            textSaveFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSaveFilePath.Location = new Point(91, 41);
            textSaveFilePath.Name = "textSaveFilePath";
            textSaveFilePath.ReadOnly = true;
            textSaveFilePath.Size = new Size(743, 23);
            textSaveFilePath.TabIndex = 0;
            // 
            // buttonOpenSaveFile
            // 
            buttonOpenSaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenSaveFile.Location = new Point(840, 41);
            buttonOpenSaveFile.Name = "buttonOpenSaveFile";
            buttonOpenSaveFile.Size = new Size(75, 23);
            buttonOpenSaveFile.TabIndex = 1;
            buttonOpenSaveFile.Text = "Open";
            buttonOpenSaveFile.UseVisualStyleBackColor = true;
            buttonOpenSaveFile.Click += buttonOpenSaveFile_Click;
            // 
            // textLogs
            // 
            textLogs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textLogs.Location = new Point(12, 585);
            textLogs.Multiline = true;
            textLogs.Name = "textLogs";
            textLogs.ReadOnly = true;
            textLogs.Size = new Size(984, 132);
            textLogs.TabIndex = 4;
            // 
            // panelSaveDetails
            // 
            panelSaveDetails.Controls.Add(saveDetails);
            panelSaveDetails.Controls.Add(labelNoSaveFileSelected);
            panelSaveDetails.Dock = DockStyle.Fill;
            panelSaveDetails.Location = new Point(0, 71);
            panelSaveDetails.Name = "panelSaveDetails";
            panelSaveDetails.Size = new Size(1008, 658);
            panelSaveDetails.TabIndex = 3;
            // 
            // saveDetails
            // 
            saveDetails.Dock = DockStyle.Fill;
            saveDetails.Location = new Point(0, 0);
            saveDetails.Name = "saveDetails";
            saveDetails.Size = new Size(1008, 658);
            saveDetails.TabIndex = 3;
            saveDetails.Visible = false;
            // 
            // labelNoSaveFileSelected
            // 
            labelNoSaveFileSelected.Dock = DockStyle.Fill;
            labelNoSaveFileSelected.Location = new Point(0, 0);
            labelNoSaveFileSelected.Name = "labelNoSaveFileSelected";
            labelNoSaveFileSelected.Size = new Size(1008, 658);
            labelNoSaveFileSelected.TabIndex = 0;
            labelNoSaveFileSelected.Text = "Save file is not selected";
            labelNoSaveFileSelected.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonOpenWriteFile
            // 
            buttonOpenWriteFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenWriteFile.Enabled = false;
            buttonOpenWriteFile.Location = new Point(921, 41);
            buttonOpenWriteFile.Name = "buttonOpenWriteFile";
            buttonOpenWriteFile.Size = new Size(75, 23);
            buttonOpenWriteFile.TabIndex = 2;
            buttonOpenWriteFile.Text = "Save";
            buttonOpenWriteFile.UseVisualStyleBackColor = true;
            buttonOpenWriteFile.Click += buttonOpenWriteFile_Click;
            // 
            // dialogOpenWriteFile
            // 
            dialogOpenWriteFile.AddToRecent = false;
            dialogOpenWriteFile.DefaultExt = "slv";
            dialogOpenWriteFile.Filter = "Save files|*.slv|All files|*.*";
            dialogOpenWriteFile.OkRequiresInteraction = true;
            dialogOpenWriteFile.RestoreDirectory = true;
            dialogOpenWriteFile.ShowHiddenFiles = true;
            dialogOpenWriteFile.SupportMultiDottedExtensions = true;
            // 
            // panelFIlesAndDirs
            // 
            panelFIlesAndDirs.Controls.Add(labelSaveFilePath);
            panelFIlesAndDirs.Controls.Add(textGameDir);
            panelFIlesAndDirs.Controls.Add(labelGameDir);
            panelFIlesAndDirs.Controls.Add(textSaveFilePath);
            panelFIlesAndDirs.Controls.Add(buttonOpenWriteFile);
            panelFIlesAndDirs.Controls.Add(buttonOpenSaveFile);
            panelFIlesAndDirs.Dock = DockStyle.Top;
            panelFIlesAndDirs.Location = new Point(0, 0);
            panelFIlesAndDirs.Name = "panelFIlesAndDirs";
            panelFIlesAndDirs.Size = new Size(1008, 71);
            panelFIlesAndDirs.TabIndex = 5;
            // 
            // labelSaveFilePath
            // 
            labelSaveFilePath.AutoSize = true;
            labelSaveFilePath.Location = new Point(3, 44);
            labelSaveFilePath.Name = "labelSaveFilePath";
            labelSaveFilePath.Size = new Size(82, 15);
            labelSaveFilePath.TabIndex = 5;
            labelSaveFilePath.Text = "Save File Path:";
            // 
            // textGameDir
            // 
            textGameDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textGameDir.Location = new Point(91, 12);
            textGameDir.Name = "textGameDir";
            textGameDir.ReadOnly = true;
            textGameDir.Size = new Size(743, 23);
            textGameDir.TabIndex = 4;
            // 
            // labelGameDir
            // 
            labelGameDir.AutoSize = true;
            labelGameDir.Location = new Point(3, 15);
            labelGameDir.Name = "labelGameDir";
            labelGameDir.Size = new Size(59, 15);
            labelGameDir.TabIndex = 3;
            labelGameDir.Text = "Game Dir:";
            // 
            // FormSaveEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(panelSaveDetails);
            Controls.Add(textLogs);
            Controls.Add(panelFIlesAndDirs);
            Name = "FormSaveEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salt and Sacrifice v2.0.0.1 Save Editor";
            panelSaveDetails.ResumeLayout(false);
            panelFIlesAndDirs.ResumeLayout(false);
            panelFIlesAndDirs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog dialogOpenSaveFile;
        private TextBox textSaveFilePath;
        private Button buttonOpenSaveFile;
        private TextBox textLogs;
        private Panel panelSaveDetails;
        private Label labelNoSaveFileSelected;
        private Controls.SaveDetails saveDetails;
        private Button buttonOpenWriteFile;
        private SaveFileDialog dialogOpenWriteFile;
        private Panel panelFIlesAndDirs;
        private Label labelSaveFilePath;
        private TextBox textGameDir;
        private Label labelGameDir;
    }
}

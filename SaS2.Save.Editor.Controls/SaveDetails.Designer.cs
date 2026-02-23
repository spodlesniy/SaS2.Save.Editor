namespace SaS2.Save.Editor.Controls
{
    partial class SaveDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabSaveDetails = new TabControl();
            tabSavePagePlainDetails = new TabPage();
            groupBoxPlayerFlags = new GroupBox();
            listBoxPlayerFlags = new ListBox();
            groupBoxStatsAdd = new GroupBox();
            tableStatsAdd = new TableLayoutPanel();
            labelNgLevelValue = new Label();
            labelNgLevel = new Label();
            labelPlayerLevelValue = new Label();
            labelPlayerLevel = new Label();
            labelTimePlayedValue = new Label();
            labelTimePlayed = new Label();
            groupBoxPlayerInfo = new GroupBox();
            checkBoxPlayerHazeBirnt = new CheckBox();
            numericPlayerSilver = new NumericUpDown();
            labelPlayerSilver = new Label();
            numericPlayerXp = new NumericUpDown();
            labelPlayerXp = new Label();
            textBoxPlayerName = new TextBox();
            labelPlayerName = new Label();
            groupBoxStats = new GroupBox();
            playerStatsWarning = new PictureBox();
            flowLayoutPanelStats = new FlowLayoutPanel();
            groupBoxSaveInfo = new GroupBox();
            textBoxHashData = new TextBox();
            labelHashData = new Label();
            textBoxVersion = new TextBox();
            labelVersion = new Label();
            tabPageItems = new TabPage();
            itemsGroupView = new SaS2ItemsGroupsView();
            dialogOpenGameDir = new FolderBrowserDialog();
            toolTipPlayerStatsWarning = new ToolTip(components);
            tabSaveDetails.SuspendLayout();
            tabSavePagePlainDetails.SuspendLayout();
            groupBoxPlayerFlags.SuspendLayout();
            groupBoxStatsAdd.SuspendLayout();
            tableStatsAdd.SuspendLayout();
            groupBoxPlayerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPlayerSilver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPlayerXp).BeginInit();
            groupBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerStatsWarning).BeginInit();
            groupBoxSaveInfo.SuspendLayout();
            tabPageItems.SuspendLayout();
            SuspendLayout();
            // 
            // tabSaveDetails
            // 
            tabSaveDetails.Controls.Add(tabSavePagePlainDetails);
            tabSaveDetails.Controls.Add(tabPageItems);
            tabSaveDetails.Dock = DockStyle.Fill;
            tabSaveDetails.Location = new Point(0, 0);
            tabSaveDetails.Name = "tabSaveDetails";
            tabSaveDetails.SelectedIndex = 0;
            tabSaveDetails.Size = new Size(1032, 628);
            tabSaveDetails.TabIndex = 0;
            // 
            // tabSavePagePlainDetails
            // 
            tabSavePagePlainDetails.Controls.Add(groupBoxPlayerFlags);
            tabSavePagePlainDetails.Controls.Add(groupBoxStatsAdd);
            tabSavePagePlainDetails.Controls.Add(groupBoxPlayerInfo);
            tabSavePagePlainDetails.Controls.Add(groupBoxStats);
            tabSavePagePlainDetails.Controls.Add(groupBoxSaveInfo);
            tabSavePagePlainDetails.Location = new Point(4, 24);
            tabSavePagePlainDetails.Name = "tabSavePagePlainDetails";
            tabSavePagePlainDetails.Padding = new Padding(3);
            tabSavePagePlainDetails.Size = new Size(1024, 600);
            tabSavePagePlainDetails.TabIndex = 0;
            tabSavePagePlainDetails.Text = "Base Info";
            tabSavePagePlainDetails.UseVisualStyleBackColor = true;
            // 
            // groupBoxPlayerFlags
            // 
            groupBoxPlayerFlags.Controls.Add(listBoxPlayerFlags);
            groupBoxPlayerFlags.Location = new Point(6, 232);
            groupBoxPlayerFlags.Name = "groupBoxPlayerFlags";
            groupBoxPlayerFlags.Size = new Size(373, 362);
            groupBoxPlayerFlags.TabIndex = 3;
            groupBoxPlayerFlags.TabStop = false;
            groupBoxPlayerFlags.Text = "Player Flags";
            // 
            // listBoxPlayerFlags
            // 
            listBoxPlayerFlags.Dock = DockStyle.Fill;
            listBoxPlayerFlags.FormattingEnabled = true;
            listBoxPlayerFlags.ItemHeight = 15;
            listBoxPlayerFlags.Location = new Point(3, 19);
            listBoxPlayerFlags.Name = "listBoxPlayerFlags";
            listBoxPlayerFlags.Size = new Size(367, 340);
            listBoxPlayerFlags.TabIndex = 0;
            // 
            // groupBoxStatsAdd
            // 
            groupBoxStatsAdd.Controls.Add(tableStatsAdd);
            groupBoxStatsAdd.Location = new Point(533, 6);
            groupBoxStatsAdd.Name = "groupBoxStatsAdd";
            groupBoxStatsAdd.Size = new Size(147, 220);
            groupBoxStatsAdd.TabIndex = 2;
            groupBoxStatsAdd.TabStop = false;
            groupBoxStatsAdd.Text = "Player Add Stats";
            // 
            // tableStatsAdd
            // 
            tableStatsAdd.ColumnCount = 2;
            tableStatsAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableStatsAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableStatsAdd.Controls.Add(labelNgLevelValue, 1, 2);
            tableStatsAdd.Controls.Add(labelNgLevel, 0, 2);
            tableStatsAdd.Controls.Add(labelPlayerLevelValue, 1, 1);
            tableStatsAdd.Controls.Add(labelPlayerLevel, 0, 1);
            tableStatsAdd.Controls.Add(labelTimePlayedValue, 1, 0);
            tableStatsAdd.Controls.Add(labelTimePlayed, 0, 0);
            tableStatsAdd.Dock = DockStyle.Fill;
            tableStatsAdd.Location = new Point(3, 19);
            tableStatsAdd.Name = "tableStatsAdd";
            tableStatsAdd.RowCount = 4;
            tableStatsAdd.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableStatsAdd.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableStatsAdd.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableStatsAdd.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableStatsAdd.Size = new Size(141, 198);
            tableStatsAdd.TabIndex = 0;
            // 
            // labelNgLevelValue
            // 
            labelNgLevelValue.AutoSize = true;
            labelNgLevelValue.Location = new Point(84, 47);
            labelNgLevelValue.Margin = new Padding(0, 3, 0, 3);
            labelNgLevelValue.Name = "labelNgLevelValue";
            labelNgLevelValue.Size = new Size(0, 15);
            labelNgLevelValue.TabIndex = 12;
            // 
            // labelNgLevel
            // 
            labelNgLevel.AutoSize = true;
            labelNgLevel.Location = new Point(0, 47);
            labelNgLevel.Margin = new Padding(0, 3, 0, 3);
            labelNgLevel.Name = "labelNgLevel";
            labelNgLevel.Size = new Size(54, 15);
            labelNgLevel.TabIndex = 11;
            labelNgLevel.Text = "NG Level";
            // 
            // labelPlayerLevelValue
            // 
            labelPlayerLevelValue.AutoSize = true;
            labelPlayerLevelValue.Location = new Point(84, 25);
            labelPlayerLevelValue.Margin = new Padding(0, 3, 0, 3);
            labelPlayerLevelValue.Name = "labelPlayerLevelValue";
            labelPlayerLevelValue.Size = new Size(0, 15);
            labelPlayerLevelValue.TabIndex = 10;
            // 
            // labelPlayerLevel
            // 
            labelPlayerLevel.AutoSize = true;
            labelPlayerLevel.Location = new Point(0, 25);
            labelPlayerLevel.Margin = new Padding(0, 3, 0, 3);
            labelPlayerLevel.Name = "labelPlayerLevel";
            labelPlayerLevel.Size = new Size(69, 15);
            labelPlayerLevel.TabIndex = 9;
            labelPlayerLevel.Text = "Player Level";
            // 
            // labelTimePlayedValue
            // 
            labelTimePlayedValue.AutoSize = true;
            labelTimePlayedValue.Location = new Point(84, 3);
            labelTimePlayedValue.Margin = new Padding(0, 3, 0, 3);
            labelTimePlayedValue.Name = "labelTimePlayedValue";
            labelTimePlayedValue.Size = new Size(0, 15);
            labelTimePlayedValue.TabIndex = 1;
            // 
            // labelTimePlayed
            // 
            labelTimePlayed.AutoSize = true;
            labelTimePlayed.Location = new Point(0, 3);
            labelTimePlayed.Margin = new Padding(0, 3, 0, 3);
            labelTimePlayed.Name = "labelTimePlayed";
            labelTimePlayed.Size = new Size(72, 15);
            labelTimePlayed.TabIndex = 0;
            labelTimePlayed.Text = "Time Played";
            // 
            // groupBoxPlayerInfo
            // 
            groupBoxPlayerInfo.Controls.Add(checkBoxPlayerHazeBirnt);
            groupBoxPlayerInfo.Controls.Add(numericPlayerSilver);
            groupBoxPlayerInfo.Controls.Add(labelPlayerSilver);
            groupBoxPlayerInfo.Controls.Add(numericPlayerXp);
            groupBoxPlayerInfo.Controls.Add(labelPlayerXp);
            groupBoxPlayerInfo.Controls.Add(textBoxPlayerName);
            groupBoxPlayerInfo.Controls.Add(labelPlayerName);
            groupBoxPlayerInfo.Location = new Point(6, 87);
            groupBoxPlayerInfo.Name = "groupBoxPlayerInfo";
            groupBoxPlayerInfo.Size = new Size(373, 139);
            groupBoxPlayerInfo.TabIndex = 1;
            groupBoxPlayerInfo.TabStop = false;
            groupBoxPlayerInfo.Text = "Player Info";
            // 
            // checkBoxPlayerHazeBirnt
            // 
            checkBoxPlayerHazeBirnt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxPlayerHazeBirnt.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxPlayerHazeBirnt.Location = new Point(6, 110);
            checkBoxPlayerHazeBirnt.Name = "checkBoxPlayerHazeBirnt";
            checkBoxPlayerHazeBirnt.Size = new Size(108, 19);
            checkBoxPlayerHazeBirnt.TabIndex = 6;
            checkBoxPlayerHazeBirnt.Text = "Haze Burnt?";
            checkBoxPlayerHazeBirnt.UseVisualStyleBackColor = true;
            // 
            // numericPlayerSilver
            // 
            numericPlayerSilver.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericPlayerSilver.Location = new Point(100, 80);
            numericPlayerSilver.Maximum = new decimal(new int[] { -294967296, 0, 0, 0 });
            numericPlayerSilver.Name = "numericPlayerSilver";
            numericPlayerSilver.Size = new Size(267, 23);
            numericPlayerSilver.TabIndex = 5;
            numericPlayerSilver.ValueChanged += numericPlayerSilver_ValueChanged;
            // 
            // labelPlayerSilver
            // 
            labelPlayerSilver.AutoSize = true;
            labelPlayerSilver.Location = new Point(6, 82);
            labelPlayerSilver.Name = "labelPlayerSilver";
            labelPlayerSilver.Size = new Size(70, 15);
            labelPlayerSilver.TabIndex = 4;
            labelPlayerSilver.Text = "Player Silver";
            // 
            // numericPlayerXp
            // 
            numericPlayerXp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericPlayerXp.Location = new Point(100, 51);
            numericPlayerXp.Maximum = new decimal(new int[] { -294967296, 0, 0, 0 });
            numericPlayerXp.Name = "numericPlayerXp";
            numericPlayerXp.Size = new Size(267, 23);
            numericPlayerXp.TabIndex = 4;
            numericPlayerXp.ValueChanged += numericPlayerXp_ValueChanged;
            // 
            // labelPlayerXp
            // 
            labelPlayerXp.AutoSize = true;
            labelPlayerXp.Location = new Point(6, 53);
            labelPlayerXp.Name = "labelPlayerXp";
            labelPlayerXp.Size = new Size(56, 15);
            labelPlayerXp.TabIndex = 4;
            labelPlayerXp.Text = "Player XP";
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPlayerName.Location = new Point(100, 22);
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(267, 23);
            textBoxPlayerName.TabIndex = 3;
            textBoxPlayerName.TextChanged += textBoxPlayerName_TextChanged;
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Location = new Point(6, 25);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(74, 15);
            labelPlayerName.TabIndex = 2;
            labelPlayerName.Text = "Player Name";
            // 
            // groupBoxStats
            // 
            groupBoxStats.Controls.Add(playerStatsWarning);
            groupBoxStats.Controls.Add(flowLayoutPanelStats);
            groupBoxStats.Location = new Point(385, 6);
            groupBoxStats.Name = "groupBoxStats";
            groupBoxStats.Size = new Size(142, 220);
            groupBoxStats.TabIndex = 1;
            groupBoxStats.TabStop = false;
            groupBoxStats.Text = "Player Stats";
            // 
            // playerStatsWarning
            // 
            playerStatsWarning.Cursor = Cursors.Help;
            playerStatsWarning.Location = new Point(112, -2);
            playerStatsWarning.Name = "playerStatsWarning";
            playerStatsWarning.Size = new Size(20, 20);
            playerStatsWarning.SizeMode = PictureBoxSizeMode.StretchImage;
            playerStatsWarning.TabIndex = 2;
            playerStatsWarning.TabStop = false;
            toolTipPlayerStatsWarning.SetToolTip(playerStatsWarning, "Techically it is possible to modify these values and save.\r\nBut the game recalculates them after save loading based on Skill Tree");
            // 
            // flowLayoutPanelStats
            // 
            flowLayoutPanelStats.Dock = DockStyle.Fill;
            flowLayoutPanelStats.Location = new Point(3, 19);
            flowLayoutPanelStats.Name = "flowLayoutPanelStats";
            flowLayoutPanelStats.Size = new Size(136, 198);
            flowLayoutPanelStats.TabIndex = 0;
            // 
            // groupBoxSaveInfo
            // 
            groupBoxSaveInfo.Controls.Add(textBoxHashData);
            groupBoxSaveInfo.Controls.Add(labelHashData);
            groupBoxSaveInfo.Controls.Add(textBoxVersion);
            groupBoxSaveInfo.Controls.Add(labelVersion);
            groupBoxSaveInfo.Location = new Point(6, 6);
            groupBoxSaveInfo.Name = "groupBoxSaveInfo";
            groupBoxSaveInfo.Size = new Size(373, 75);
            groupBoxSaveInfo.TabIndex = 0;
            groupBoxSaveInfo.TabStop = false;
            groupBoxSaveInfo.Text = "Save Info";
            // 
            // textBoxHashData
            // 
            textBoxHashData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxHashData.Location = new Point(100, 45);
            textBoxHashData.Name = "textBoxHashData";
            textBoxHashData.ReadOnly = true;
            textBoxHashData.Size = new Size(267, 23);
            textBoxHashData.TabIndex = 2;
            // 
            // labelHashData
            // 
            labelHashData.AutoSize = true;
            labelHashData.Location = new Point(6, 48);
            labelHashData.Name = "labelHashData";
            labelHashData.Size = new Size(61, 15);
            labelHashData.TabIndex = 0;
            labelHashData.Text = "Hash Data";
            // 
            // textBoxVersion
            // 
            textBoxVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxVersion.Location = new Point(100, 16);
            textBoxVersion.Name = "textBoxVersion";
            textBoxVersion.ReadOnly = true;
            textBoxVersion.Size = new Size(267, 23);
            textBoxVersion.TabIndex = 1;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(6, 19);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(45, 15);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "Version";
            // 
            // tabPageItems
            // 
            tabPageItems.Controls.Add(itemsGroupView);
            tabPageItems.Location = new Point(4, 24);
            tabPageItems.Name = "tabPageItems";
            tabPageItems.Padding = new Padding(3);
            tabPageItems.Size = new Size(1024, 600);
            tabPageItems.TabIndex = 1;
            tabPageItems.Text = "Items";
            tabPageItems.UseVisualStyleBackColor = true;
            // 
            // itemsGroupView
            // 
            itemsGroupView.Dock = DockStyle.Fill;
            itemsGroupView.Location = new Point(3, 3);
            itemsGroupView.Name = "itemsGroupView";
            itemsGroupView.Size = new Size(1018, 594);
            itemsGroupView.TabIndex = 1;
            // 
            // dialogOpenGameDir
            // 
            dialogOpenGameDir.AddToRecent = false;
            dialogOpenGameDir.OkRequiresInteraction = true;
            dialogOpenGameDir.RootFolder = Environment.SpecialFolder.MyComputer;
            dialogOpenGameDir.ShowHiddenFiles = true;
            dialogOpenGameDir.ShowNewFolderButton = false;
            // 
            // toolTipPlayerStatsWarning
            // 
            toolTipPlayerStatsWarning.IsBalloon = true;
            toolTipPlayerStatsWarning.ToolTipIcon = ToolTipIcon.Warning;
            // 
            // SaveDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabSaveDetails);
            Name = "SaveDetails";
            Size = new Size(1032, 628);
            tabSaveDetails.ResumeLayout(false);
            tabSavePagePlainDetails.ResumeLayout(false);
            groupBoxPlayerFlags.ResumeLayout(false);
            groupBoxStatsAdd.ResumeLayout(false);
            tableStatsAdd.ResumeLayout(false);
            tableStatsAdd.PerformLayout();
            groupBoxPlayerInfo.ResumeLayout(false);
            groupBoxPlayerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPlayerSilver).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPlayerXp).EndInit();
            groupBoxStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)playerStatsWarning).EndInit();
            groupBoxSaveInfo.ResumeLayout(false);
            groupBoxSaveInfo.PerformLayout();
            tabPageItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabSaveDetails;
        private TabPage tabSavePagePlainDetails;
        private TabPage tabPageItems;
        private GroupBox groupBoxSaveInfo;
        private TextBox textBoxVersion;
        private Label labelVersion;
        private TextBox textBoxHashData;
        private Label labelHashData;
        private GroupBox groupBoxStats;
        private FlowLayoutPanel flowLayoutPanelStats;
        private GroupBox groupBoxPlayerInfo;
        private TextBox textBoxPlayerName;
        private Label labelPlayerName;
        private Label labelPlayerXp;
        private NumericUpDown numericPlayerXp;
        private NumericUpDown numericPlayerSilver;
        private Label labelPlayerSilver;
        private CheckBox checkBoxPlayerHazeBirnt;
        private FolderBrowserDialog dialogOpenGameDir;
        private SaS2ItemsGroupsView itemsGroupView;
        private PictureBox playerStatsWarning;
        private ToolTip toolTipPlayerStatsWarning;
        private GroupBox groupBoxStatsAdd;
        private TableLayoutPanel tableStatsAdd;
        private Label labelTimePlayed;
        private Label labelTimePlayedValue;
        private Label labelPlayerLevel;
        private Label labelPlayerLevelValue;
        private Label labelNgLevelValue;
        private Label labelNgLevel;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxPlayerFlags;
        private ListBox listBoxPlayerFlags;
    }
}

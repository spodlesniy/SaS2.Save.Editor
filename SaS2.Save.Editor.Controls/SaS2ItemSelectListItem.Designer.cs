namespace SaS2.Save.Editor.Controls
{
    partial class SaS2ItemSelectListItem
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
            itemView = new SaS2ItemView();
            tableItemInfo = new TableLayoutPanel();
            labelInfoValue = new Label();
            labelInfo = new Label();
            labelTitleValue = new Label();
            labelItemName = new Label();
            labelTitle = new Label();
            labelItemNameValue = new Label();
            buttonSelect = new Button();
            tableItemInfo.SuspendLayout();
            SuspendLayout();
            // 
            // itemView
            // 
            itemView.BorderStyle = BorderStyle.FixedSingle;
            itemView.Interactive = false;
            itemView.Location = new Point(3, 3);
            itemView.Name = "itemView";
            itemView.Padding = new Padding(2);
            itemView.Size = new Size(62, 62);
            itemView.TabIndex = 0;
            // 
            // tableItemInfo
            // 
            tableItemInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableItemInfo.ColumnCount = 2;
            tableItemInfo.ColumnStyles.Add(new ColumnStyle());
            tableItemInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableItemInfo.Controls.Add(labelInfoValue, 1, 2);
            tableItemInfo.Controls.Add(labelInfo, 0, 2);
            tableItemInfo.Controls.Add(labelTitleValue, 1, 1);
            tableItemInfo.Controls.Add(labelItemName, 0, 0);
            tableItemInfo.Controls.Add(labelTitle, 0, 1);
            tableItemInfo.Controls.Add(labelItemNameValue, 1, 0);
            tableItemInfo.Location = new Point(71, 4);
            tableItemInfo.Name = "tableItemInfo";
            tableItemInfo.RowCount = 3;
            tableItemInfo.RowStyles.Add(new RowStyle());
            tableItemInfo.RowStyles.Add(new RowStyle());
            tableItemInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableItemInfo.Size = new Size(464, 61);
            tableItemInfo.TabIndex = 1;
            // 
            // labelInfoValue
            // 
            labelInfoValue.Dock = DockStyle.Fill;
            labelInfoValue.Location = new Point(48, 45);
            labelInfoValue.Margin = new Padding(3);
            labelInfoValue.Name = "labelInfoValue";
            labelInfoValue.Size = new Size(413, 14);
            labelInfoValue.TabIndex = 4;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(3, 45);
            labelInfo.Margin = new Padding(3);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(28, 14);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "Info";
            // 
            // labelTitleValue
            // 
            labelTitleValue.Dock = DockStyle.Fill;
            labelTitleValue.Location = new Point(48, 24);
            labelTitleValue.Margin = new Padding(3);
            labelTitleValue.Name = "labelTitleValue";
            labelTitleValue.Size = new Size(413, 15);
            labelTitleValue.TabIndex = 2;
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Dock = DockStyle.Fill;
            labelItemName.Location = new Point(3, 3);
            labelItemName.Margin = new Padding(3);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(39, 15);
            labelItemName.TabIndex = 0;
            labelItemName.Text = "Name";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(3, 24);
            labelTitle.Margin = new Padding(3);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(30, 15);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // labelItemNameValue
            // 
            labelItemNameValue.Dock = DockStyle.Fill;
            labelItemNameValue.Location = new Point(48, 3);
            labelItemNameValue.Margin = new Padding(3);
            labelItemNameValue.Name = "labelItemNameValue";
            labelItemNameValue.Size = new Size(413, 15);
            labelItemNameValue.TabIndex = 1;
            // 
            // buttonSelect
            // 
            buttonSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelect.Location = new Point(541, 3);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(75, 23);
            buttonSelect.TabIndex = 2;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // SaS2ItemSelectListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSelect);
            Controls.Add(tableItemInfo);
            Controls.Add(itemView);
            Name = "SaS2ItemSelectListItem";
            Size = new Size(619, 68);
            tableItemInfo.ResumeLayout(false);
            tableItemInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SaS2ItemView itemView;
        private TableLayoutPanel tableItemInfo;
        private Button buttonSelect;
        private Label labelItemName;
        private Label labelTitle;
        private Label labelItemNameValue;
        private Label labelTitleValue;
        private Label labelInfo;
        private Label labelInfoValue;
    }
}

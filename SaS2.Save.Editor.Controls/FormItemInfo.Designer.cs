namespace SaS2.Save.Editor.Controls
{
    partial class FormItemInfo
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
            buttonClose = new Button();
            labelItemDescription = new Label();
            saS2ItemView = new SaS2ItemView();
            tableLayoutItemDetails = new TableLayoutPanel();
            labelItemDescriptionValue = new Label();
            tableLayoutBaseInfo = new TableLayoutPanel();
            tableLayoutSecondaryInfo = new TableLayoutPanel();
            labelSubTypeValue = new Label();
            labelSubType = new Label();
            tableLayoutItemInfo = new TableLayoutPanel();
            labelTypeValue = new Label();
            labelType = new Label();
            labelItemTitleValue = new Label();
            labelItemTitle = new Label();
            labelItemNameValue = new Label();
            labelItemName = new Label();
            tableLayoutItemDetails.SuspendLayout();
            tableLayoutBaseInfo.SuspendLayout();
            tableLayoutSecondaryInfo.SuspendLayout();
            tableLayoutItemInfo.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose.DialogResult = DialogResult.OK;
            buttonClose.Location = new Point(713, 415);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // labelItemDescription
            // 
            labelItemDescription.AutoSize = true;
            labelItemDescription.Location = new Point(0, 4);
            labelItemDescription.Margin = new Padding(0, 4, 4, 4);
            labelItemDescription.Name = "labelItemDescription";
            labelItemDescription.Size = new Size(67, 15);
            labelItemDescription.TabIndex = 3;
            labelItemDescription.Text = "Description";
            // 
            // saS2ItemView
            // 
            saS2ItemView.BorderStyle = BorderStyle.FixedSingle;
            saS2ItemView.Interactive = false;
            saS2ItemView.Location = new Point(12, 12);
            saS2ItemView.Name = "saS2ItemView";
            saS2ItemView.Padding = new Padding(2);
            saS2ItemView.Size = new Size(127, 127);
            saS2ItemView.TabIndex = 3;
            // 
            // tableLayoutItemDetails
            // 
            tableLayoutItemDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutItemDetails.AutoScroll = true;
            tableLayoutItemDetails.ColumnCount = 2;
            tableLayoutItemDetails.ColumnStyles.Add(new ColumnStyle());
            tableLayoutItemDetails.ColumnStyles.Add(new ColumnStyle());
            tableLayoutItemDetails.Controls.Add(labelItemDescriptionValue, 1, 0);
            tableLayoutItemDetails.Controls.Add(labelItemDescription, 0, 0);
            tableLayoutItemDetails.Location = new Point(12, 145);
            tableLayoutItemDetails.Name = "tableLayoutItemDetails";
            tableLayoutItemDetails.RowCount = 2;
            tableLayoutItemDetails.RowStyles.Add(new RowStyle());
            tableLayoutItemDetails.RowStyles.Add(new RowStyle());
            tableLayoutItemDetails.Size = new Size(776, 264);
            tableLayoutItemDetails.TabIndex = 4;
            // 
            // labelItemDescriptionValue
            // 
            labelItemDescriptionValue.AutoSize = true;
            labelItemDescriptionValue.Dock = DockStyle.Fill;
            labelItemDescriptionValue.Location = new Point(71, 4);
            labelItemDescriptionValue.Margin = new Padding(0, 4, 0, 4);
            labelItemDescriptionValue.MaximumSize = new Size(700, 0);
            labelItemDescriptionValue.Name = "labelItemDescriptionValue";
            labelItemDescriptionValue.Size = new Size(700, 15);
            labelItemDescriptionValue.TabIndex = 5;
            labelItemDescriptionValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutBaseInfo
            // 
            tableLayoutBaseInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutBaseInfo.ColumnCount = 2;
            tableLayoutBaseInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutBaseInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutBaseInfo.Controls.Add(tableLayoutSecondaryInfo, 1, 0);
            tableLayoutBaseInfo.Controls.Add(tableLayoutItemInfo, 0, 0);
            tableLayoutBaseInfo.Location = new Point(145, 12);
            tableLayoutBaseInfo.Name = "tableLayoutBaseInfo";
            tableLayoutBaseInfo.RowCount = 1;
            tableLayoutBaseInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutBaseInfo.Size = new Size(643, 127);
            tableLayoutBaseInfo.TabIndex = 5;
            // 
            // tableLayoutSecondaryInfo
            // 
            tableLayoutSecondaryInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutSecondaryInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutSecondaryInfo.ColumnCount = 2;
            tableLayoutSecondaryInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutSecondaryInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutSecondaryInfo.Controls.Add(labelSubTypeValue, 1, 0);
            tableLayoutSecondaryInfo.Controls.Add(labelSubType, 0, 0);
            tableLayoutSecondaryInfo.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutSecondaryInfo.Location = new Point(324, 3);
            tableLayoutSecondaryInfo.Name = "tableLayoutSecondaryInfo";
            tableLayoutSecondaryInfo.RowCount = 2;
            tableLayoutSecondaryInfo.RowStyles.Add(new RowStyle());
            tableLayoutSecondaryInfo.RowStyles.Add(new RowStyle());
            tableLayoutSecondaryInfo.Size = new Size(316, 121);
            tableLayoutSecondaryInfo.TabIndex = 4;
            // 
            // labelSubTypeValue
            // 
            labelSubTypeValue.AutoSize = true;
            labelSubTypeValue.Dock = DockStyle.Fill;
            labelSubTypeValue.Location = new Point(59, 4);
            labelSubTypeValue.Margin = new Padding(0, 4, 0, 4);
            labelSubTypeValue.Name = "labelSubTypeValue";
            labelSubTypeValue.Size = new Size(257, 15);
            labelSubTypeValue.TabIndex = 9;
            labelSubTypeValue.TextAlign = ContentAlignment.MiddleLeft;
            labelSubTypeValue.Visible = false;
            // 
            // labelSubType
            // 
            labelSubType.AutoSize = true;
            labelSubType.Location = new Point(0, 4);
            labelSubType.Margin = new Padding(0, 4, 4, 4);
            labelSubType.Name = "labelSubType";
            labelSubType.Size = new Size(55, 15);
            labelSubType.TabIndex = 8;
            labelSubType.Text = "Sub Type";
            labelSubType.Visible = false;
            // 
            // tableLayoutItemInfo
            // 
            tableLayoutItemInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutItemInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutItemInfo.ColumnCount = 2;
            tableLayoutItemInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutItemInfo.ColumnStyles.Add(new ColumnStyle());
            tableLayoutItemInfo.Controls.Add(labelTypeValue, 1, 2);
            tableLayoutItemInfo.Controls.Add(labelType, 0, 2);
            tableLayoutItemInfo.Controls.Add(labelItemTitleValue, 1, 1);
            tableLayoutItemInfo.Controls.Add(labelItemTitle, 0, 1);
            tableLayoutItemInfo.Controls.Add(labelItemNameValue, 1, 0);
            tableLayoutItemInfo.Controls.Add(labelItemName, 0, 0);
            tableLayoutItemInfo.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutItemInfo.Location = new Point(3, 3);
            tableLayoutItemInfo.Name = "tableLayoutItemInfo";
            tableLayoutItemInfo.RowCount = 4;
            tableLayoutItemInfo.RowStyles.Add(new RowStyle());
            tableLayoutItemInfo.RowStyles.Add(new RowStyle());
            tableLayoutItemInfo.RowStyles.Add(new RowStyle());
            tableLayoutItemInfo.RowStyles.Add(new RowStyle());
            tableLayoutItemInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutItemInfo.Size = new Size(315, 121);
            tableLayoutItemInfo.TabIndex = 3;
            // 
            // labelTypeValue
            // 
            labelTypeValue.AutoSize = true;
            labelTypeValue.Dock = DockStyle.Fill;
            labelTypeValue.Location = new Point(43, 50);
            labelTypeValue.Margin = new Padding(0, 4, 0, 4);
            labelTypeValue.Name = "labelTypeValue";
            labelTypeValue.Size = new Size(272, 15);
            labelTypeValue.TabIndex = 8;
            labelTypeValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(0, 50);
            labelType.Margin = new Padding(0, 4, 4, 4);
            labelType.Name = "labelType";
            labelType.Size = new Size(32, 15);
            labelType.TabIndex = 7;
            labelType.Text = "Type";
            // 
            // labelItemTitleValue
            // 
            labelItemTitleValue.AutoSize = true;
            labelItemTitleValue.Dock = DockStyle.Fill;
            labelItemTitleValue.Location = new Point(43, 27);
            labelItemTitleValue.Margin = new Padding(0, 4, 0, 4);
            labelItemTitleValue.Name = "labelItemTitleValue";
            labelItemTitleValue.Size = new Size(272, 15);
            labelItemTitleValue.TabIndex = 6;
            labelItemTitleValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelItemTitle
            // 
            labelItemTitle.AutoSize = true;
            labelItemTitle.Location = new Point(0, 27);
            labelItemTitle.Margin = new Padding(0, 4, 4, 4);
            labelItemTitle.Name = "labelItemTitle";
            labelItemTitle.Size = new Size(30, 15);
            labelItemTitle.TabIndex = 5;
            labelItemTitle.Text = "Title";
            // 
            // labelItemNameValue
            // 
            labelItemNameValue.AutoSize = true;
            labelItemNameValue.Dock = DockStyle.Fill;
            labelItemNameValue.Location = new Point(43, 4);
            labelItemNameValue.Margin = new Padding(0, 4, 0, 4);
            labelItemNameValue.Name = "labelItemNameValue";
            labelItemNameValue.Size = new Size(272, 15);
            labelItemNameValue.TabIndex = 2;
            labelItemNameValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Location = new Point(0, 4);
            labelItemName.Margin = new Padding(0, 4, 4, 4);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(39, 15);
            labelItemName.TabIndex = 1;
            labelItemName.Text = "Name";
            // 
            // FormItemInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonClose;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(tableLayoutBaseInfo);
            Controls.Add(tableLayoutItemDetails);
            Controls.Add(saS2ItemView);
            Controls.Add(buttonClose);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormItemInfo";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Item Info";
            tableLayoutItemDetails.ResumeLayout(false);
            tableLayoutItemDetails.PerformLayout();
            tableLayoutBaseInfo.ResumeLayout(false);
            tableLayoutSecondaryInfo.ResumeLayout(false);
            tableLayoutSecondaryInfo.PerformLayout();
            tableLayoutItemInfo.ResumeLayout(false);
            tableLayoutItemInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClose;
        private SaS2ItemView saS2ItemView;
        private Label labelItemDescription;
        private TableLayoutPanel tableLayoutItemDetails;
        private Label labelItemDescriptionValue;
        private TableLayoutPanel tableLayoutBaseInfo;
        private TableLayoutPanel tableLayoutSecondaryInfo;
        private TableLayoutPanel tableLayoutItemInfo;
        private Label labelTypeValue;
        private Label labelType;
        private Label labelItemTitleValue;
        private Label labelItemTitle;
        private Label labelItemNameValue;
        private Label labelItemName;
        private Label labelSubTypeValue;
        private Label labelSubType;
    }
}
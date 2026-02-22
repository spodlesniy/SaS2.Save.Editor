namespace SaS2.Save.Editor.Controls
{
    partial class SaS2ItemView
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
            pictureItem = new PictureBox();
            pictureUpgrade = new PictureBox();
            toolTip = new ToolTip(components);
            labelCount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpgrade).BeginInit();
            SuspendLayout();
            // 
            // pictureItem
            // 
            pictureItem.BackColor = SystemColors.Control;
            pictureItem.Dock = DockStyle.Fill;
            pictureItem.Location = new Point(2, 2);
            pictureItem.Margin = new Padding(0);
            pictureItem.Name = "pictureItem";
            pictureItem.Size = new Size(58, 58);
            pictureItem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureItem.TabIndex = 0;
            pictureItem.TabStop = false;
            pictureItem.Click += pictureItem_Click;
            pictureItem.MouseHover += pictureItem_MouseHover;
            // 
            // pictureUpgrade
            // 
            pictureUpgrade.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureUpgrade.Location = new Point(2, 48);
            pictureUpgrade.Name = "pictureUpgrade";
            pictureUpgrade.Size = new Size(12, 12);
            pictureUpgrade.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUpgrade.TabIndex = 1;
            pictureUpgrade.TabStop = false;
            pictureUpgrade.Tag = "";
            pictureUpgrade.Visible = false;
            pictureUpgrade.Click += pictureUpgrade_Click;
            pictureUpgrade.MouseHover += pictureUpgrade_MouseHover;
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCount.Location = new Point(42, -2);
            labelCount.Margin = new Padding(0);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(21, 15);
            labelCount.TabIndex = 2;
            labelCount.Text = "1";
            labelCount.TextAlign = ContentAlignment.TopRight;
            labelCount.Click += labelCount_Click;
            labelCount.MouseEnter += labelCount_MouseEnter;
            labelCount.MouseLeave += labelCount_MouseLeave;
            labelCount.MouseHover += labelCount_MouseHover;
            // 
            // SaS2ItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelCount);
            Controls.Add(pictureUpgrade);
            Controls.Add(pictureItem);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            Name = "SaS2ItemView";
            Padding = new Padding(2);
            Size = new Size(62, 62);
            Click += pictureItem_Click;
            ((System.ComponentModel.ISupportInitialize)pictureItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUpgrade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureItem;
        private PictureBox pictureUpgrade;
        private ToolTip toolTip;
        private Label labelCount;
    }
}

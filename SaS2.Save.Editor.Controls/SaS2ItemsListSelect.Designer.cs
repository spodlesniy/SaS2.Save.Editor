namespace SaS2.Save.Editor.Controls
{
    partial class SaS2ItemsListSelect
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
            tableItems = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tableItems
            // 
            tableItems.AutoScroll = true;
            tableItems.ColumnCount = 1;
            tableItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableItems.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableItems.Dock = DockStyle.Fill;
            tableItems.Location = new Point(0, 0);
            tableItems.Name = "tableItems";
            tableItems.RowCount = 1;
            tableItems.RowStyles.Add(new RowStyle());
            tableItems.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableItems.Size = new Size(761, 256);
            tableItems.TabIndex = 0;
            // 
            // SaS2ItemsListSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableItems);
            Name = "SaS2ItemsListSelect";
            Size = new Size(761, 256);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableItems;
    }
}

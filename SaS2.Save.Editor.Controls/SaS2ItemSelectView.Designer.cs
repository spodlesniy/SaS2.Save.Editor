namespace SaS2.Save.Editor.Controls
{
    partial class SaS2ItemSelectView
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
            itemsGroupSelect = new SaS2ItemsGroupSelect();
            itemListSelect = new SaS2ItemsListSelect();
            SuspendLayout();
            // 
            // itemsGroupSelect
            // 
            itemsGroupSelect.Dock = DockStyle.Top;
            itemsGroupSelect.Location = new Point(0, 0);
            itemsGroupSelect.Name = "itemsGroupSelect";
            itemsGroupSelect.Size = new Size(995, 100);
            itemsGroupSelect.TabIndex = 3;
            itemsGroupSelect.OnItemGroupChangeChangedEvent += itemsGroupSelect_OnItemGroupChangeChangedEvent;
            // 
            // itemListSelect
            // 
            itemListSelect.Dock = DockStyle.Fill;
            itemListSelect.Location = new Point(0, 100);
            itemListSelect.Name = "itemListSelect";
            itemListSelect.Size = new Size(995, 418);
            itemListSelect.TabIndex = 4;
            itemListSelect.OnItemSelectedEvent += itemListSelect_OnItemSelectedEvent;
            // 
            // SaS2ItemSelectView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(itemListSelect);
            Controls.Add(itemsGroupSelect);
            Name = "SaS2ItemSelectView";
            Size = new Size(995, 518);
            ResumeLayout(false);
        }

        #endregion
        private SaS2ItemsGroupSelect itemsGroupSelect;
        private SaS2ItemsListSelect itemListSelect;
    }
}

namespace SaS2.Save.Editor.Controls
{
    partial class SaS2ItemsGroupSelect
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
            flowLayoutItemGroups = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutItemGroups
            // 
            flowLayoutItemGroups.Dock = DockStyle.Fill;
            flowLayoutItemGroups.Location = new Point(0, 0);
            flowLayoutItemGroups.Name = "flowLayoutItemGroups";
            flowLayoutItemGroups.Size = new Size(824, 100);
            flowLayoutItemGroups.TabIndex = 0;
            // 
            // SaS2ItemsGroupSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutItemGroups);
            Name = "SaS2ItemsGroupSelect";
            Size = new Size(824, 100);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutItemGroups;
    }
}

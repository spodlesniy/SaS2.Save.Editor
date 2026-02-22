namespace SaS2.Save.Editor.Controls
{
    partial class SaS2ItemsList
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
            flowItems = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowItems
            // 
            flowItems.AutoScroll = true;
            flowItems.Dock = DockStyle.Fill;
            flowItems.Location = new Point(0, 0);
            flowItems.Margin = new Padding(0);
            flowItems.Name = "flowItems";
            flowItems.Size = new Size(699, 432);
            flowItems.TabIndex = 0;
            // 
            // SaS2ItemsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(flowItems);
            Name = "SaS2ItemsList";
            Size = new Size(699, 432);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowItems;
    }
}

namespace SaS2.Save.Editor.Controls
{
    partial class FormSelectItem
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
            itemSelectView = new SaS2ItemSelectView();
            SuspendLayout();
            // 
            // itemSelectView
            // 
            itemSelectView.Dock = DockStyle.Fill;
            itemSelectView.Location = new Point(0, 0);
            itemSelectView.Name = "itemSelectView";
            itemSelectView.Size = new Size(800, 450);
            itemSelectView.TabIndex = 0;
            itemSelectView.OnItemSelectedEvent += saS2ItemSelectView1_OnItemSelectedEvent;
            // 
            // FormSelectItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(itemSelectView);
            Name = "FormSelectItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Item to Add";
            ResumeLayout(false);
        }

        #endregion

        private SaS2ItemSelectView itemSelectView;
    }
}
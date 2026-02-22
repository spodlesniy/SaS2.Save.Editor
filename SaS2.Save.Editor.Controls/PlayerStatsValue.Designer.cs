namespace SaS2.Save.Editor.Controls
{
    partial class PlayerStatsValue
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
            labelStatName = new Label();
            labelStatValue = new Label();
            SuspendLayout();
            // 
            // labelStatName
            // 
            labelStatName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelStatName.AutoEllipsis = true;
            labelStatName.Location = new Point(0, 0);
            labelStatName.Name = "labelStatName";
            labelStatName.Size = new Size(102, 16);
            labelStatName.TabIndex = 0;
            labelStatName.Text = "Stat name";
            labelStatName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelStatValue
            // 
            labelStatValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelStatValue.AutoEllipsis = true;
            labelStatValue.Location = new Point(108, 0);
            labelStatValue.Name = "labelStatValue";
            labelStatValue.Size = new Size(61, 16);
            labelStatValue.TabIndex = 1;
            labelStatValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PlayerStatsValue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelStatValue);
            Controls.Add(labelStatName);
            Name = "PlayerStatsValue";
            Size = new Size(168, 16);
            ResumeLayout(false);
        }

        #endregion

        private Label labelStatName;
        private Label labelStatValue;
    }
}

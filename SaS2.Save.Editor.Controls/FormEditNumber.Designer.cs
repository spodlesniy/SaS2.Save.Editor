namespace SaS2.Save.Editor.Controls
{
    partial class FormEditNumber
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
            tableLayout = new TableLayoutPanel();
            labelTitle = new Label();
            numericValue = new NumericUpDown();
            buttonConfirm = new Button();
            cancelButton = new Button();
            tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericValue).BeginInit();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout.ColumnCount = 1;
            tableLayout.ColumnStyles.Add(new ColumnStyle());
            tableLayout.Controls.Add(labelTitle, 0, 0);
            tableLayout.Controls.Add(numericValue, 0, 1);
            tableLayout.Location = new Point(12, 12);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 2;
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.Size = new Size(164, 54);
            tableLayout.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 10F);
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(0, 4, 0, 4);
            labelTitle.Size = new Size(158, 27);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // numericValue
            // 
            numericValue.Dock = DockStyle.Fill;
            numericValue.Location = new Point(3, 30);
            numericValue.Name = "numericValue";
            numericValue.Size = new Size(158, 23);
            numericValue.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Location = new Point(101, 72);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 23);
            buttonConfirm.TabIndex = 3;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(12, 72);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // FormEditNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(188, 107);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(buttonConfirm);
            Controls.Add(tableLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormEditNumber";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Value";
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayout;
        private Label labelTitle;
        private Button buttonConfirm;
        private Button cancelButton;
        private NumericUpDown numericValue;
    }
}
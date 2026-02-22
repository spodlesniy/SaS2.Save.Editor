namespace SaS2.Save.Editor.Controls
{
    partial class SaS2ItemsGroupsView
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
            itemList = new SaS2ItemsList();
            groupBoxItemPlacemetn = new GroupBox();
            radioButtonStockpile = new RadioButton();
            radioButtonPlayer = new RadioButton();
            itemsGroupSelect = new SaS2ItemsGroupSelect();
            buttonAddItem = new Button();
            groupBoxItemPlacemetn.SuspendLayout();
            SuspendLayout();
            // 
            // itemList
            // 
            itemList.BorderStyle = BorderStyle.FixedSingle;
            itemList.Dock = DockStyle.Fill;
            itemList.Location = new Point(0, 154);
            itemList.Name = "itemList";
            itemList.Size = new Size(995, 364);
            itemList.TabIndex = 1;
            // 
            // groupBoxItemPlacemetn
            // 
            groupBoxItemPlacemetn.Controls.Add(buttonAddItem);
            groupBoxItemPlacemetn.Controls.Add(radioButtonStockpile);
            groupBoxItemPlacemetn.Controls.Add(radioButtonPlayer);
            groupBoxItemPlacemetn.Dock = DockStyle.Top;
            groupBoxItemPlacemetn.Location = new Point(0, 0);
            groupBoxItemPlacemetn.Margin = new Padding(0);
            groupBoxItemPlacemetn.Name = "groupBoxItemPlacemetn";
            groupBoxItemPlacemetn.Size = new Size(995, 54);
            groupBoxItemPlacemetn.TabIndex = 2;
            groupBoxItemPlacemetn.TabStop = false;
            groupBoxItemPlacemetn.Text = "Item Placement";
            // 
            // radioButtonStockpile
            // 
            radioButtonStockpile.AutoSize = true;
            radioButtonStockpile.Location = new Point(69, 22);
            radioButtonStockpile.Name = "radioButtonStockpile";
            radioButtonStockpile.Size = new Size(73, 19);
            radioButtonStockpile.TabIndex = 1;
            radioButtonStockpile.Tag = "1";
            radioButtonStockpile.Text = "Stockpile";
            radioButtonStockpile.UseVisualStyleBackColor = true;
            radioButtonStockpile.CheckedChanged += radioButtonPlayer_CheckedChanged;
            // 
            // radioButtonPlayer
            // 
            radioButtonPlayer.AutoSize = true;
            radioButtonPlayer.Checked = true;
            radioButtonPlayer.Location = new Point(6, 22);
            radioButtonPlayer.Name = "radioButtonPlayer";
            radioButtonPlayer.Size = new Size(57, 19);
            radioButtonPlayer.TabIndex = 0;
            radioButtonPlayer.TabStop = true;
            radioButtonPlayer.Text = "Player";
            radioButtonPlayer.UseVisualStyleBackColor = true;
            radioButtonPlayer.CheckedChanged += radioButtonPlayer_CheckedChanged;
            // 
            // itemsGroupSelect
            // 
            itemsGroupSelect.Dock = DockStyle.Top;
            itemsGroupSelect.Location = new Point(0, 54);
            itemsGroupSelect.Name = "itemsGroupSelect";
            itemsGroupSelect.Size = new Size(995, 100);
            itemsGroupSelect.TabIndex = 3;
            itemsGroupSelect.OnItemGroupChangeChangedEvent += itemsGroupSelect_OnItemGroupChangeChangedEvent;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddItem.Location = new Point(914, 18);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(75, 23);
            buttonAddItem.TabIndex = 2;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // SaS2ItemsGroupsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(itemList);
            Controls.Add(itemsGroupSelect);
            Controls.Add(groupBoxItemPlacemetn);
            Name = "SaS2ItemsGroupsView";
            Size = new Size(995, 518);
            groupBoxItemPlacemetn.ResumeLayout(false);
            groupBoxItemPlacemetn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SaS2ItemsList itemList;
        private GroupBox groupBoxItemPlacemetn;
        private RadioButton radioButtonStockpile;
        private RadioButton radioButtonPlayer;
        private SaS2ItemsGroupSelect itemsGroupSelect;
        private Button buttonAddItem;
    }
}

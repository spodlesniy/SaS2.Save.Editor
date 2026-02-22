using System.ComponentModel;

namespace SaS2.Save.Editor.Controls
{
    public partial class SaS2ItemsGroupSelect : UserControl
    {
        public class ItemGroupChangeEventArgs : EventArgs
        {

        }

        public delegate void OnItemGroupChangeChanged(SaS2ItemGroupType group);

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event OnItemGroupChangeChanged? OnItemGroupChangeChangedEvent;

        public SaS2ItemsGroupSelect()
        {
            InitializeComponent();
        }

        public void InitItemGroupButtons()
        {
            flowLayoutItemGroups.Controls.Clear();

            for (int i = 0; i < (int)SaS2ItemGroupType.TotalCount; i++)
            {
                var itemGroupButton = new Button()
                {
                    Image = ImageSource.FramedImage($"item_group_{i}", 5, new Size(64, 64)), // I like number 5 :)
                    Tag = i,
                    AutoSize = false,
                    Cursor = Cursors.Hand,
                    Margin = Padding.Empty,
                    Padding = Padding.Empty,
                    Size = new Size(70, 96),
                    TextImageRelation = TextImageRelation.TextAboveImage
                };

                itemGroupButton.Click += ItemGroupButton_Click;

                flowLayoutItemGroups.Controls.Add(itemGroupButton);
            }
        }

        public void UpdateItemGroupCount(SaS2ItemGroupType group, int count, SaS2ItemGroupType currentGroup)
        {
            var currentButton = flowLayoutItemGroups.Controls[(int)group];

            if (currentButton == null)
            {
                return;
            }

            var hasItems = count > 0;
            var isSelected = currentGroup == group;

            currentButton.Text = hasItems ? count.ToString() : "—";
            currentButton.Font = hasItems ? new Font(DefaultFont, FontStyle.Bold) : DefaultFont;
            currentButton.BackColor = isSelected ? Color.LightGreen : Color.FromKnownColor(KnownColor.Control);
            currentButton.Enabled = hasItems;
        }

        private void ItemGroupButton_Click(object? sender, EventArgs e)
        {
            if (sender == null || sender is not Button || ((Button)sender).Tag == null)
            {
                return;
            }

            var itemGroup = (SaS2ItemGroupType)((Button)sender).Tag;

            OnItemGroupChangeChangedEvent?.Invoke(itemGroup);
        }
    }
}

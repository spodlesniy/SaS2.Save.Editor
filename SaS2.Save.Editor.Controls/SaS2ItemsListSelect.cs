using System.ComponentModel;

namespace SaS2.Save.Editor.Controls
{
    public partial class SaS2ItemsListSelect : UserControl
    {
        public delegate void OnItemSelected(SaS2Item selectedItem);

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks Select button")]
        public event OnItemSelected? OnItemSelectedEvent;

        public SaS2ItemsListSelect()
        {
            InitializeComponent();

        }

        public void SetItems(List<SaS2Item> items)
        {
            SuspendLayout();

            try
            {
                tableItems.Controls.Clear();
                tableItems.RowStyles.Clear();
                tableItems.RowCount = 0;

                for (int i = 0; i < items.Count; i++)
                {
                    tableItems.RowStyles.Add(new RowStyle
                    {
                        SizeType = SizeType.AutoSize
                    });

                    var itemView = new SaS2ItemSelectListItem
                    {
                        Margin = Padding.Empty,
                        Padding = Padding.Empty,
                        Dock = DockStyle.Top
                    };

                    itemView.SetItem(items[i]);
                    itemView.OnItemSelectedEvent += ItemView_OnItemSelectedEvent;

                    tableItems.Controls.Add(itemView);
                }
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void ItemView_OnItemSelectedEvent(SaS2Item selectedItem)
        {
            OnItemSelectedEvent?.Invoke(selectedItem);
        }
    }
}

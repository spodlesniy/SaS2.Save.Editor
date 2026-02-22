namespace SaS2.Save.Editor.Controls
{
    public partial class SaS2ItemsList : UserControl
    {
        protected List<SaS2Item>? items = null;

        public SaS2ItemsList()
        {
            InitializeComponent();
        }

        public void SetItems(List<SaS2Item> items)
        {
            this.items = items;

            SuspendLayout();

            try
            {
                flowItems.Controls.Clear();

                for (int i = 0; i < items.Count; i++)
                {
                    var itemView = new SaS2ItemView
                    {
                        Interactive = true
                    };

                    itemView.SetItem(items[i]);

                    flowItems.Controls.Add(itemView);
                }
            }
            finally
            {
                ResumeLayout();
            }
        }
    }
}

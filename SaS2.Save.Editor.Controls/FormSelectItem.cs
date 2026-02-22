namespace SaS2.Save.Editor.Controls
{
    public partial class FormSelectItem : Form
    {
        public SaS2Item? SelectedItem = null;

        public FormSelectItem()
        {
            InitializeComponent();
        }

        public static SaS2Item? ShowItemSelect(List<SaS2Item> playerItems)
        {
            var formSelect = new FormSelectItem();
            formSelect.itemSelectView.SetItems(playerItems);

            if (formSelect.ShowDialog() == DialogResult.OK)
            {
                return formSelect.SelectedItem;
            }

            return null;
        }

        private void saS2ItemSelectView1_OnItemSelectedEvent(SaS2Item selectedItem)
        {
            SelectedItem = selectedItem;

            DialogResult = DialogResult.OK;
        }
    }
}

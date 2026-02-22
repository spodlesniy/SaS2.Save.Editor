using static SaS2.Save.SaS2LootCategory;

namespace SaS2.Save.Editor.Controls
{
    public partial class SaS2ItemView : UserControl
    {
        protected SaS2Item? item = null;
        public SaS2LootDef? itemInfo = null;
        public SaS2LootCategory? itemCategory = null;

        protected bool _hasUpdates = false;

        public bool Interactive { get; set; }

        protected bool HasUpdates
        {
            get { return _hasUpdates; }
            set
            {
                _hasUpdates = value;

                BackColor = _hasUpdates ? Color.Pink : Color.FromKnownColor(KnownColor.Control);
            }
        }

        public SaS2ItemView()
        {
            InitializeComponent();
        }

        private void SetUpgrade(int newUpgrade)
        {
            pictureUpgrade.Image = newUpgrade > 0 ? ImageSource.ImageList[$"upgrade_{newUpgrade}"] : null;
            pictureUpgrade.Tag = newUpgrade;
        }

        public void SetItem(SaS2Item item)
        {

            labelCount.Visible = false;

            var itemInfo = SaS2LootCatalog.lootDefs[item.lootIdx];
            var lootCategory = itemInfo.type switch
            {
                (int)SaS2LootCategoryType.TYPE_ARMOR => new SaS2LootCategoryArmor(),
                (int)SaS2LootCategoryType.TYPE_WEAPON => new SaS2LootCategoryWeapon(),
                (int)SaS2LootCategoryType.TYPE_RANGED => new SaS2LootCategoryRanged(),
                (int)SaS2LootCategoryType.TYPE_CONSUMABLE => new SaS2LootCategoryConsumable(),
                (int)SaS2LootCategoryType.TYPE_MATERIAL => new SaS2LootCategoryMaterial(),
                (int)SaS2LootCategoryType.TYPE_KEY => new SaS2LootCategoryKey(),
                (int)SaS2LootCategoryType.TYPE_CHARM => new SaS2LootCategoryCharm(),
                (int)SaS2LootCategoryType.TYPE_MAGIC => new SaS2LootCategoryMagic(),
                (int)SaS2LootCategoryType.TYPE_GESTURE => new SaS2LootCategoryGesture(),

                _ => new SaS2LootCategory()
            };

            this.item = item;
            this.itemInfo = itemInfo;
            this.itemCategory = lootCategory;

            pictureItem.Image = ImageSource.ImageList[itemInfo.name];

            switch (itemInfo.type)
            {
                case (int)SaS2LootCategoryType.TYPE_ARMOR:
                case (int)SaS2LootCategoryType.TYPE_CONSUMABLE:
                case (int)SaS2LootCategoryType.TYPE_RANGED:
                case (int)SaS2LootCategoryType.TYPE_WEAPON:

                    SetUpgrade(item.upgrade);
                    pictureUpgrade.Visible = Interactive;

                    break;
                default:
                    pictureUpgrade.Visible = false;
                    break;
            }

            if (Interactive && (lootCategory.GetMaxCount(itemInfo.lootFields) > 1 || item.count > 1))
            {
                labelCount.Text = item.count.ToString();
                labelCount.Visible = true;
            }

            HasUpdates = Interactive && item.isNew;
        }

        private void SaS2ItemView_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                return;
            }

            FormItemInfo.ShowItemInfo(item, this);
        }

        private void pictureItem_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                return;
            }

            FormItemInfo.ShowItemInfo(item, this);
        }

        private void pictureUpgrade_Click(object sender, EventArgs e)
        {
            if (item == null || itemInfo == null || !Interactive)
            {
                return;
            }

            // Just cycle values on click
            item.upgrade = item.upgrade >= 10 ? 0 : item.upgrade + 1;

            SetUpgrade(item.upgrade);

            HasUpdates = true;
        }

        private void pictureUpgrade_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureUpgrade, pictureUpgrade.Tag != null && (int)pictureUpgrade.Tag > 0 ? $"Upgrade {(int)pictureUpgrade.Tag}. Click to upgrade" : "No upgrade. Click to upgrade");
        }

        private void pictureItem_MouseHover(object sender, EventArgs e)
        {
            if (item == null || itemInfo == null)
            {
                return;
            }

            toolTip.SetToolTip(pictureItem, itemInfo.title[(int)SaS2Environment.currentLanguage]);
        }

        private void labelCount_MouseHover(object sender, EventArgs e)
        {
            if (!Interactive || !labelCount.Visible || item == null || itemInfo == null)
            {
                return;
            }

            toolTip.SetToolTip(labelCount, "Click to change value");
        }

        private void labelCount_Click(object sender, EventArgs e)
        {
            if (!Interactive || !labelCount.Visible || item == null || itemInfo == null)
            {
                return;
            }

            var newValue = FormEditNumber.ShowEditIntNumber(item.count, "Item Count", new Tuple<int, int>(1, 99));

            if (newValue == null || !newValue.HasValue || newValue <= 0 || newValue > 99)
            {
                return;
            }

            item.count = newValue.Value;
            labelCount.Text = item.count.ToString();

            HasUpdates = true;
        }

        private void labelCount_MouseEnter(object sender, EventArgs e)
        {
            labelCount.Font = new Font(DefaultFont, FontStyle.Bold);
        }

        private void labelCount_MouseLeave(object sender, EventArgs e)
        {
            labelCount.Font = DefaultFont;
        }
    }
}

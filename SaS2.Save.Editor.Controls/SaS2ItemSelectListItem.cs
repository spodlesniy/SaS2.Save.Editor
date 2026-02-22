
using System.ComponentModel;
using static SaS2.Save.SaS2LootCategory;
using static SaS2.Save.SaS2LootCategoryArmor;
using static SaS2.Save.SaS2LootCategoryWeapon;

namespace SaS2.Save.Editor.Controls
{
    public partial class SaS2ItemSelectListItem : UserControl
    {
        public SaS2Item? Item { get; set; } = null;

        public delegate void OnItemSelected(SaS2Item selectedItem);

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks Select button")]
        public event OnItemSelected? OnItemSelectedEvent;

        public SaS2ItemSelectListItem()
        {
            InitializeComponent();
        }

        public void SetItem(SaS2Item item)
        {
            Item = item;

            SuspendLayout();

            try
            {
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

                labelItemNameValue.Text = itemInfo.name;
                labelTitleValue.Text = itemInfo.title[(int)SaS2Environment.currentLanguage];
                labelInfoValue.Text = GetCategoryInfo(itemInfo, lootCategory);

                itemView.SetItem(item);
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (Item == null)
            {
                return;
            }

            OnItemSelectedEvent?.Invoke(Item);
        }

        protected string GetCategoryInfo(SaS2LootDef itemInfo, SaS2LootCategory lootCategory)
        {
            if (lootCategory is SaS2LootCategoryArmor armor)
            {
                return string.Join(" | ",
                [
                    armor.GetSubtypeName(itemInfo.subType),
                    $"Class {itemInfo.lootFields[(int)SaS2LootCategoryArmorFields.FIELD_CLASS_LEVEL].iData}",
                    itemInfo.lootFields[(int)SaS2LootCategoryArmorFields.FIELD_HEAVY].bData ? "Heavy" : "Light"
                ]);
            }

            if (lootCategory is SaS2LootCategoryWeapon weapon)
            {
                return string.Join(" | ",
                [
                    weapon.GetSubtypeName(itemInfo.subType),
                    $"Class {itemInfo.lootFields[(int)SaS2LootCategoryWeaponFields.FIELD_CLASS_LEVEL].iData}",
                ]);
            }

            return lootCategory.GetSubtypeName(itemInfo.subType);
        }
    }
}

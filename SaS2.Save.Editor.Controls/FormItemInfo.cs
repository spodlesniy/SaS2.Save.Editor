using static SaS2.Save.SaS2LootCategory;
using static SaS2.Save.SaS2LootField;

namespace SaS2.Save.Editor.Controls
{
    public partial class FormItemInfo : Form
    {
        protected static FormItemInfo instance = new();

        protected static Label GetNewLabelForLabel(string label, bool bordered)
        {
            return new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(0),
                Margin = new Padding(0),
                Text = label,
                BorderStyle = bordered ? BorderStyle.FixedSingle : BorderStyle.None,
            };
        }

        protected static Label GetNewLabelForValue(string value, bool bordered)
        {
            return new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(0),
                Margin = new Padding(0),
                Text = value,
                BorderStyle = bordered ? BorderStyle.FixedSingle : BorderStyle.None,
            };
        }

        public FormItemInfo()
        {
            InitializeComponent();
        }

        public static void ShowItemInfo(SaS2Item item, IWin32Window? owner)
        {
            instance.tableLayoutSecondaryInfo.RowCount = 2;

            instance.tableLayoutItemDetails.Controls.Clear();
            instance.tableLayoutItemDetails.RowCount = 0;

            instance.labelSubType.Visible = false;

            instance.labelSubTypeValue.Visible = false;
            instance.labelSubTypeValue.Text = "";

            instance.saS2ItemView.SetItem(item);

            var itemInfo = SaS2LootCatalog.lootDefs[item.lootIdx];

            if (itemInfo != null)
            {
                instance.labelItemNameValue.Text = itemInfo.name;

                // title and description are arrays with translations. 0 index is english.
                instance.labelItemTitleValue.Text = itemInfo.title.FirstOrDefault();
                instance.labelItemDescriptionValue.Text = itemInfo.description.FirstOrDefault();

                instance.labelTypeValue.Text = SaS2LootCategory.GetTypeName(itemInfo.type);

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

                var subTypeCount = lootCategory.GetSubtypeCount();

                if (itemInfo.subType >= 0 && subTypeCount > 0)
                {
                    instance.labelSubType.Visible = true;

                    instance.labelSubTypeValue.Visible = true;
                    instance.labelSubTypeValue.Text = lootCategory.GetSubtypeName(itemInfo.subType);
                }

                var fieldCount = lootCategory.GetFieldsCount();

                instance.tableLayoutItemDetails.RowCount = fieldCount + 1; // One row to fill the rest space

                for (int i = 0; i < fieldCount; i++)
                {
                    var field = itemInfo.lootFields[i];
                    var fieldValue = field.dataType switch
                    {
                        (int)SaS2LootFieldDataType.DATA_TYPE_FLOAT => field.fData.ToString("F1"),
                        (int)SaS2LootFieldDataType.DATA_TYPE_INT => field.iData.ToString(),
                        (int)SaS2LootFieldDataType.DATA_TYPE_BOOLEAN => field.bData ? "Yes" : "No",

                        _ => field.strData,
                    };

                    instance.tableLayoutItemDetails.Controls.Add(GetNewLabelForLabel(lootCategory.GetFieldName(i), true));
                    instance.tableLayoutItemDetails.Controls.Add(GetNewLabelForValue(fieldValue, true));
                }
            }

            instance.ShowDialog(owner);
        }
    }
}

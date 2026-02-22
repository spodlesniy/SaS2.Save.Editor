using static SaS2.Save.SaS2LootCategory;
using static SaS2.Save.SaS2LootCategoryArmor;

namespace SaS2.Save.Editor.Controls
{
    public partial class SaS2ItemsGroupsView : UserControl
    {
        protected Dictionary<SaS2ItemGroupType, List<SaS2Item>> itemGroups = [];
        protected SaS2ItemGroupType _selecteItemGroup = SaS2ItemGroupType.ArmorHead;
        protected bool _stockpiled = false;

        public List<SaS2Item>? Items { get; protected set; }

        public SaS2ItemsGroupsView()
        {
            InitializeComponent();
        }

        protected void InitItemGroups()
        {
            for (int i = 0; i < (int)SaS2ItemGroupType.TotalCount; i++)
            {
                itemGroups.Add((SaS2ItemGroupType)i, []);
            }

            itemsGroupSelect.InitItemGroupButtons();
        }

        protected void SelectItemGroup(SaS2ItemGroupType itemGroup)
        {
            _selecteItemGroup = itemGroup;

            Enabled = false;

            SuspendLayout();

            try
            {
                var itemGroupItems = itemGroups.ContainsKey(itemGroup) ? itemGroups[itemGroup].FindAll(item => item.stockPiled == _stockpiled) : [];

                itemList.SetItems(itemGroupItems);

                for (int i = 0; i < (int)SaS2ItemGroupType.TotalCount; i++)
                {
                    var currentItemGroupItems =
                        ((i == (int)itemGroup)
                            ? itemGroupItems
                            : itemGroups[(SaS2ItemGroupType)i].FindAll(item => item.stockPiled == _stockpiled));

                    itemsGroupSelect.UpdateItemGroupCount((SaS2ItemGroupType)i, currentItemGroupItems.Count, itemGroup);
                }
            }
            finally
            {
                ResumeLayout();

                Enabled = true;
            }
        }

        public void SetItems(List<SaS2Item> items)
        {
            SetItems(items, SaS2ItemGroupType.ArmorHead);
        }

        public void SetItems(List<SaS2Item> items, SaS2ItemGroupType selectedGroup)
        {
            Items = items;

            if (itemGroups.Count == 0)
            {
                // Can't init in ctor because ImageSource list is not ready
                InitItemGroups();
            }

            radioButtonPlayer.Checked = true;

            foreach (var itemGroupItems in itemGroups.Values)
            {
                itemGroupItems.Clear();
            }

            for (int i = 0; i < Items.Count; i++)
            {
                SaS2Item? item = Items[i];
                var itemInfo = SaS2LootCatalog.lootDefs[item.lootIdx];

                if (itemInfo == null)
                {
                    continue;
                }

                var itemGroup = itemInfo.type switch
                {
                    (int)SaS2LootCategoryType.TYPE_ARMOR => itemInfo.subType switch
                    {
                        (int)SaS2LootCategoryArmorSubTypes.SUBTYPE_HELM => (int)SaS2ItemGroupType.ArmorHead,
                        (int)SaS2LootCategoryArmorSubTypes.SUBTYPE_ARMOR => (int)SaS2ItemGroupType.ArmorChest,
                        (int)SaS2LootCategoryArmorSubTypes.SUBTYPE_GLOVES => (int)SaS2ItemGroupType.ArmorHands,
                        (int)SaS2LootCategoryArmorSubTypes.SUBTYPE_BOOTS => (int)SaS2ItemGroupType.ArmorLegs,

                        _ => -1,
                    },

                    (int)SaS2LootCategoryType.TYPE_WEAPON => (int)SaS2ItemGroupType.Weapon,
                    (int)SaS2LootCategoryType.TYPE_RANGED => (int)SaS2ItemGroupType.Ranged,
                    (int)SaS2LootCategoryType.TYPE_CHARM => (int)SaS2ItemGroupType.Charm,
                    (int)SaS2LootCategoryType.TYPE_CONSUMABLE => (int)SaS2ItemGroupType.Consumable,
                    (int)SaS2LootCategoryType.TYPE_MATERIAL => (int)SaS2ItemGroupType.Material,
                    (int)SaS2LootCategoryType.TYPE_KEY => (int)SaS2ItemGroupType.Key,
                    (int)SaS2LootCategoryType.TYPE_MAGIC => (int)SaS2ItemGroupType.Magic,
                    (int)SaS2LootCategoryType.TYPE_GESTURE => (int)SaS2ItemGroupType.Gesture,

                    _ => -1
                };

                if (itemGroup == -1)
                {
                    continue;
                }

                itemGroups[(SaS2ItemGroupType)itemGroup].Add(item);
            }

            SelectItemGroup(selectedGroup);
        }

        private void radioButtonPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == null || sender is not RadioButton)
            {
                return;
            }

            _stockpiled = ((RadioButton)sender).Tag != null;

            SelectItemGroup(_selecteItemGroup);
        }

        private void itemsGroupSelect_OnItemGroupChangeChangedEvent(SaS2ItemGroupType group)
        {
            SelectItemGroup(group);
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (Items == null)
            {
                return;
            }

            var newItem = FormSelectItem.ShowItemSelect(Items);

            if (newItem == null)
            {
                return;
            }

            Items.Add(newItem);

            SetItems(Items, _selecteItemGroup);
        }
    }
}

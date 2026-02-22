using System.ComponentModel;
using static SaS2.Save.SaS2LootCategory;
using static SaS2.Save.SaS2LootCategoryArmor;

namespace SaS2.Save.Editor.Controls
{
    public partial class SaS2ItemSelectView : UserControl
    {
        protected List<SaS2Item> allItems = [];
        protected Dictionary<SaS2ItemGroupType, List<SaS2Item>> itemGroups = [];
        protected SaS2ItemGroupType _selectedItemGroup = SaS2ItemGroupType.ArmorHead;

        public HashSet<int>? PlayerItemIds { get; protected set; }

        public delegate void OnItemSelected(SaS2Item selectedItem);

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks Select button")]
        public event OnItemSelected? OnItemSelectedEvent;

        public SaS2ItemSelectView()
        {
            InitializeComponent();
        }

        protected void InitAll()
        {
            for (int i = 0; i < (int)SaS2ItemGroupType.TotalCount; i++)
            {
                itemGroups.Add((SaS2ItemGroupType)i, []);
            }

            itemsGroupSelect.InitItemGroupButtons();

            allItems = [.. SaS2LootCatalog.lootDefs.Select((_, lootIndex) => new SaS2Item(lootIndex))];

            foreach (var itemGroupItems in itemGroups.Values)
            {
                itemGroupItems.Clear();
            }

            for (int i = 0; i < allItems.Count; i++)
            {
                SaS2Item? item = allItems[i];
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
        }

        protected void SelectItemGroup(SaS2ItemGroupType itemGroup)
        {
            _selectedItemGroup = itemGroup;

            Enabled = false;

            SuspendLayout();

            try
            {
                var itemGroupItems =
                    itemGroups.ContainsKey(itemGroup)
                        ? itemGroups[itemGroup].FindAll(item => PlayerItemIds?.Contains(item.lootIdx) != true)
                        : [];

                itemListSelect.SetItems(itemGroupItems);

                for (int i = 0; i < (int)SaS2ItemGroupType.TotalCount; i++)
                {
                    var currentItemGroupItems =
                        ((i == (int)itemGroup)
                            ? itemGroupItems
                            : itemGroups[(SaS2ItemGroupType)i].FindAll(item => PlayerItemIds?.Contains(item.lootIdx) != true));

                    itemsGroupSelect.UpdateItemGroupCount((SaS2ItemGroupType)i, currentItemGroupItems.Count, itemGroup);
                }
            }
            finally
            {
                ResumeLayout();

                Enabled = true;
            }
        }

        public void SetItems(List<SaS2Item> playerItems)
        {
            PlayerItemIds = [.. playerItems.Select(item => item.lootIdx)];

            if (itemGroups.Count == 0)
            {
                // Can't init in ctor because ImageSource list is not ready
                InitAll();
            }

            SelectItemGroup(SaS2ItemGroupType.ArmorHead);
        }

        private void itemsGroupSelect_OnItemGroupChangeChangedEvent(SaS2ItemGroupType group)
        {
            SelectItemGroup(group);
        }

        private void itemListSelect_OnItemSelectedEvent(SaS2Item selectedItem)
        {
            OnItemSelectedEvent?.Invoke(selectedItem);
        }
    }
}

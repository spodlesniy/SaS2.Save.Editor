namespace SaS2.Save.Editor.Controls
{
    public partial class PlayerStatsValue : UserControl
    {
        private static readonly Dictionary<SaS2Stats.PlayerStat, string> statNames = new()
        {
            { SaS2Stats.PlayerStat.Strength, "Strength" },
            { SaS2Stats.PlayerStat.Dexterity, "Dexterity" },
            { SaS2Stats.PlayerStat.Vitality, "Vitality" },
            { SaS2Stats.PlayerStat.Will, "Will" },
            { SaS2Stats.PlayerStat.Endurance, "Endurance" },
            { SaS2Stats.PlayerStat.Arcana, "Arcana" },
            { SaS2Stats.PlayerStat.Conviction, "Conviction" },
            { SaS2Stats.PlayerStat.Resolve, "Resolve" },
            { SaS2Stats.PlayerStat.Luck, "Luck" },
        };

        public PlayerStatsValue()
        {
            InitializeComponent();
        }

        public void SetStat(SaS2Stats.PlayerStat statType, int statValue)
        {
            labelStatName.Text = statNames.ContainsKey(statType) ? statNames[statType] : $"Unknown stat type ({statType})";
            labelStatValue.Text = statValue.ToString();
        }
    }
}

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SaS2.Save.Editor.Controls
{
    public partial class SaveDetails : UserControl
    {
        private SaS2Save? saS2Save;

        public SaveDetails()
        {
            InitializeComponent();

            playerStatsWarning.Image = SystemIcons.Warning.ToBitmap();
        }

        private void numericPlayerXp_ValueChanged(object sender, EventArgs e)
        {
            if (saS2Save == null || sender is not NumericUpDown numeric)
            {
                return;
            }

            saS2Save.stats.xp = (long)numericPlayerXp.Value;

            if (numeric.Tag != null)
            {
                numeric.BackColor = (saS2Save.stats.xp == (long)numeric.Tag) ? Color.FromKnownColor(KnownColor.Window) : Color.LightPink;
            }
        }

        private void numericPlayerSilver_ValueChanged(object sender, EventArgs e)
        {
            if (saS2Save == null || sender is not NumericUpDown editor)
            {
                return;
            }

            saS2Save.stats.silver = (long)editor.Value;

            if (editor.Tag != null)
            {
                editor.BackColor = (saS2Save.stats.xp == (long)editor.Tag) ? Color.FromKnownColor(KnownColor.Window) : Color.LightPink;
            }
        }

        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
            if (saS2Save == null || sender is not TextBox editor)
            {
                return;
            }

            saS2Save.name = editor.Text;

            if (editor.Tag != null)
            {
                editor.BackColor = (saS2Save.name == (string)editor.Tag) ? DefaultBackColor : Color.LightPink;
            }
        }

        public void LoadSaveDetails(SaS2Save saveDetails)
        {
            saS2Save = saveDetails;

            textBoxVersion.Text = saveDetails.version.ToString();
            textBoxHashData.Text = saveDetails.hashData;

            // Save default data to Tag to trace value changes
            textBoxPlayerName.Text = saveDetails.name;
            textBoxPlayerName.Tag = saveDetails.name;
            textBoxPlayerName.BackColor = DefaultBackColor;

            numericPlayerXp.Value = saveDetails.stats.xp;
            numericPlayerXp.Tag = saveDetails.stats.xp;
            numericPlayerXp.BackColor = DefaultBackColor;

            numericPlayerSilver.Value = saveDetails.stats.silver;
            numericPlayerSilver.Tag = saveDetails.stats.silver;
            numericPlayerSilver.BackColor = DefaultBackColor;

            for (int statType = 0; statType < saveDetails.stats.stats.Length; statType++)
            {
                var statValue = saveDetails.stats.stats[statType];

                var statItem = new PlayerStatsValue
                {
                    Dock = DockStyle.Top
                };
                statItem.SetStat((SaS2Stats.PlayerStat)statType, statValue);
                statItem.Parent = flowLayoutPanelStats;
            }

            labelTimePlayedValue.Text = SaS2Stats.GetTimePlayedAsString(saveDetails.stats.timePlayed);
            labelPlayerLevelValue.Text = saveDetails.stats.level.ToString();
            labelNgLevelValue.Text = saveDetails.flags.ngLevel.ToString();

            listBoxPlayerFlags.Items.Clear();
            foreach (var flag in saveDetails.flags.flags)
            {
                listBoxPlayerFlags.Items.Add(flag);
            }

            itemsGroupView.SetItems(saveDetails.equipment.inventoryItems);
        }

        public void ResetState()
        {
            textBoxPlayerName.Tag = textBoxPlayerName.Text;
            textBoxPlayerName.BackColor = DefaultBackColor;

            numericPlayerXp.Tag = numericPlayerXp.Value;
            numericPlayerXp.BackColor = DefaultBackColor;

            numericPlayerSilver.Tag = numericPlayerSilver.Value;
            numericPlayerSilver.BackColor = DefaultBackColor;
        }
    }
}

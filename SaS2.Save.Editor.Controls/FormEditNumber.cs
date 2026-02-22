namespace SaS2.Save.Editor.Controls
{
    public partial class FormEditNumber : Form
    {
        public FormEditNumber()
        {
            InitializeComponent();
        }

        public static int? ShowEditIntNumber(int defaultValue, string title, Tuple<int, int> minMax)
        {
            var form = new FormEditNumber();

            form.labelTitle.Text = title;

            form.numericValue.Value = defaultValue;
            form.numericValue.Minimum = minMax.Item1;
            form.numericValue.Maximum = minMax.Item2;

            if (form.ShowDialog() == DialogResult.OK)
            {
                return (int)form.numericValue.Value;
            }

            return null;
        }
    }
}

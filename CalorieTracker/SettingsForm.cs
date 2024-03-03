using CalorieTracker.Models;

namespace CalorieTracker
{
    public partial class SettingsForm : Form
    {
        public Settings set = new();
        public SettingsForm(Settings set)
        {
            InitializeComponent();
            proteins_Tb.Text = set.Proteins.ToString();
            fats_Tb.Text = set.Fats.ToString();
            carbohydrates_Tb.Text = set.Carbohydrates.ToString();
            calories_Tb.Text = set.Calories.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            set.Proteins = double.Parse(proteins_Tb.Text);
            set.Fats = double.Parse(fats_Tb.Text);
            set.Carbohydrates = double.Parse(carbohydrates_Tb.Text);
            set.Calories = double.Parse(calories_Tb.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

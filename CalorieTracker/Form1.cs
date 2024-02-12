namespace CalorieTracker
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void editing_btn_Click(object sender, EventArgs e)
        {
            FORMEditingAdding form = new FORMEditingAdding();
            form.ShowDialog();
        }
    }
}

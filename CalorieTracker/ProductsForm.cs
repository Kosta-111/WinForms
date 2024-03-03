using System.ComponentModel;
using CalorieTracker.Models;

namespace CalorieTracker
{
    public partial class ProductsForm : Form
    {
        public Product? p { get; set; }
        public bool changes { get; set; }
        public BindingList<Product> products { get; set; }

        public ProductsForm(BindingList<Product> product)
        {
            InitializeComponent();
            p = null;
            products = new();
            foreach (var item in product)
            {
                products.Add(item);
            }
            product_lb.DataSource = this.products;
            Catgr_cb.DataSource = Enum.GetValues(typeof(Category));
            changes = false;
            product_lb.SelectedItem = null;
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            p = new Product()
            {
                Name = name_tb.Text,
                Calories = double.Parse(Calo_tb.Text),
                Carbohydrates = double.Parse(Carb_tb.Text),
                Fats = double.Parse(fat_tb.Text),
                Proteins = double.Parse(Prot_tb.Text),
                ProductCategory = (Category)Catgr_cb.SelectedItem
            };

            changes = true;
            this.products.Add(p);
            product_lb.SelectedIndex = -1;
        }

        private void Cnl_Btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            if (product_lb != null)
            {
                Product p = (Product)product_lb.SelectedItem;
                products.Remove(p);
                product_lb.SelectedIndex = -1;
                changes = true;
            }
        }

        private void product_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (product_lb.SelectedIndex == -1)
            {
                ClearForm();
                return;
            }
            Product pd = (Product)product_lb.SelectedItem;
            name_tb.Text = pd.Name;
            Prot_tb.Text = pd.Proteins.ToString();
            fat_tb.Text = pd.Fats.ToString();
            Carb_tb.Text = pd.Carbohydrates.ToString();
            Calo_tb.Text = pd.Calories.ToString();
            Catgr_cb.SelectedItem = pd.ProductCategory;
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (product_lb.SelectedIndex == -1)
                return;
            p = new Product()
            {
                Name = name_tb.Text,
                Calories = double.Parse(Calo_tb.Text),
                Carbohydrates = double.Parse(Carb_tb.Text),
                Fats = double.Parse(fat_tb.Text),
                Proteins = double.Parse(Prot_tb.Text),
                ProductCategory = (Category)Catgr_cb.SelectedItem
            };
            changes = true;
            int index = product_lb.SelectedIndex;
            products.Remove((Product)product_lb.SelectedItem);
            this.products.Add(p);
            product_lb.SelectedItem = p;
        }

        private void ClearForm()
        {
            name_tb.Text = null;
            Prot_tb.Text = null;
            fat_tb.Text = null;
            Carb_tb.Text = null;
            Calo_tb.Text = null;
            Catgr_cb.SelectedItem = Category.None;
        }
    }
}

using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using CalorieTracker.Classes;

namespace CalorieTracker
{
    public partial class FORMEditingAdding : Form
    {
        public Product p { get; set; }
        public bool changes { get; set; }
        public BindingList<Product> products { get; set; }

        public FORMEditingAdding(BindingList<Product> product)
        {
            InitializeComponent();
            this.products = product;
            product_lb.DataSource = this.products;
            Catgr_cb.DataSource = Enum.GetValues(typeof(Category));
            changes = false;
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
        }

        private void Cnl_Btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            if (product_lb.SelectedItem != null)
            {
                Product p = (Product)product_lb.SelectedItem;
                products.Remove(p);
                changes = true;
            }
        }

        private void product_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (product_lb.SelectedItem != null)
            {
                Product pd = (Product)product_lb.SelectedItem;
                name_tb.Text = pd.Name;
                Prot_tb.Text = pd.Proteins.ToString();
                fat_tb.Text = pd.Fats.ToString();
                Carb_tb.Text = pd.Carbohydrates.ToString();
                Calo_tb.Text = pd.Calories.ToString();
                Catgr_cb.SelectedItem = pd.ProductCategory;
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (product_lb.SelectedItem != null)
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

                products.Remove((Product)product_lb.SelectedItem);
                this.products.Add(p);
            }
        }
    }
}

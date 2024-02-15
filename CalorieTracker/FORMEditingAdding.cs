using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (product_lb != null)
            {
                Product p = (Product)product_lb.SelectedItem;
                products.Remove(p);
                changes = true;

            }

        }
    }
}

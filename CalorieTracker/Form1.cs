using System.ComponentModel;
using System.Text.Json;

namespace CalorieTracker
{
    public partial class Form1 : Form
    {
        BindingList<Product> products = new BindingList<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void editing_btn_Click(object sender, EventArgs e)
        {
            string fileName = "product_list.json";
            string jsonStr;

            if (!products.Any() && File.Exists(fileName))
            {
                jsonStr = File.ReadAllText(fileName);
                products = JsonSerializer.Deserialize<BindingList<Product>>(jsonStr);
            }
            else using (File.Create(fileName)) ;


            FORMEditingAdding form = new FORMEditingAdding(products);
            var result = form.ShowDialog();

            if (result == DialogResult.Cancel && form.changes == true)
            {
                products = form.products;
                jsonStr = JsonSerializer.Serialize(products);
                File.WriteAllText(fileName, jsonStr);
            }

        }

    }
}

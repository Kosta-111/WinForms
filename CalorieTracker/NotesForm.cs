using CalorieTracker.Models;
using System.ComponentModel;
using System.Data;

namespace CalorieTracker
{
    public partial class NotesForm : Form
    {
        public Note n { get; set; }

        public BindingList<Product> products { get; set; }

        public bool changes { get; set; }

        public NotesForm(BindingList<Product> product)
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now.AddMonths(-1);
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now;
            
            products = product;
            changes = false;
            product_cb.DataSource = products.Select(i => $"{i.Name} : {i.ProductCategory}").ToList();
            product_cb.SelectedIndex = -1;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            n = new Note() { 
                Product = products[product_cb.SelectedIndex], 
                Weight = double.Parse(weight_tb.Text),
                DateTime = dateTimePicker1.Value,
            };
            changes = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

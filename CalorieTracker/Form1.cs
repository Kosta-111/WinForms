using CalorieTracker.Classes;
using System.ComponentModel;
using System.Text.Json;

namespace CalorieTracker
{
    public partial class Form1 : Form
    {
        BindingList<Product> products = new BindingList<Product>();
        BindingList<Note> notes = new BindingList<Note>();

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


            FORMEditingAdding form = new FORMEditingAdding(products);
            var result = form.ShowDialog();

            if (result == DialogResult.Cancel && form.changes == true)
            {
                products = form.products;
                jsonStr = JsonSerializer.Serialize(products);
                File.WriteAllText(fileName, jsonStr);
            }

        }

        private void note_btn_Click(object sender, EventArgs e)
        {
            string fileName = "note_list.json";
            string jsonStr;

            if (!notes.Any() && File.Exists(fileName))
            {
                jsonStr = File.ReadAllText(fileName);
                notes = JsonSerializer.Deserialize<BindingList<Note>>(jsonStr);
            }

            NotesForm form = new NotesForm(notes, products);
            var result = form.ShowDialog();

            if (result == DialogResult.Cancel && form.changes == true)
            {
                notes = form.notes;
                jsonStr = JsonSerializer.Serialize(notes);
                File.WriteAllText(fileName, jsonStr);
            }
        }
    }
}

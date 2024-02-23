using CalorieTracker.Classes;
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
    public partial class NotesForm : Form
    {
        public Note n { get; set; }

        public BindingList<Product> products { get; set; }
        public BindingList<Note> notes { get; set; }

        public bool changes { get; set; }

        public NotesForm(BindingList<Note> note, BindingList<Product> product)
        {
            InitializeComponent();
            products = product;
            notes = note;
            changes = false;
            note_lb.DataSource = notes;
            product_cb.DataSource = products;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            n = new Note() { Product = (Product)product_cb.SelectedItem, Weight = double.Parse(weight_tb.Text) };
            notes.Add(n);
            changes = true;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

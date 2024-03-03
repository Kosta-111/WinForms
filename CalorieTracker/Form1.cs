using CalorieTracker.Models;
using System.ComponentModel;
using System.Text.Json;

namespace CalorieTracker;

public partial class Form1 : Form
{
    BindingList<Product> products = new BindingList<Product>();
    BindingList<Note> notes = new BindingList<Note>();
    string fileProducts = "products_list.json";
    string fileNotes = "notes_list.json";
    string fileSettings = "mySettings.json";
    Settings set = new Settings();
    bool canEat = true;

    public Form1()
    {
        InitializeComponent();
        LoadData();
        dataGridView1.DataSource = notes;
        period_Cb.SelectedIndex = 0;
    }

    private void LoadData()
    {
        if (File.Exists(fileNotes))
        {
            string jsonStr = File.ReadAllText(fileNotes);
            notes = JsonSerializer.Deserialize<BindingList<Note>>(jsonStr)!;
        }
        if (File.Exists(fileProducts))
        {
            string jsonStr = File.ReadAllText(fileProducts);
            products = JsonSerializer.Deserialize<BindingList<Product>>(jsonStr)!;
        }
        if (File.Exists(fileSettings))
        {
            string jsonStr = File.ReadAllText(fileSettings);
            set = JsonSerializer.Deserialize<Settings>(jsonStr)!;
        }
    }

    private void Product_btn_Click(object sender, EventArgs e)
    {
        ProductsForm productsForm = new ProductsForm(products);
        var result = productsForm.ShowDialog();

        if (result == DialogResult.OK && productsForm.changes == true)
        {
            products = productsForm.products;
            string jsonStr = JsonSerializer.Serialize(products);
            File.WriteAllText(fileProducts, jsonStr);
        }

    }
    private void Note_btn_Click(object sender, EventArgs e)
    {
        if (!canEat)
        {
            var res = MessageBox.Show(
                    "Stop eating!!!",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Stop,
                    MessageBoxDefaultButton.Button1);
            if (res == DialogResult.OK) 
            {
                return;
            }
        }        

        NotesForm form = new NotesForm(products);
        var result = form.ShowDialog();

        if (result == DialogResult.OK && form.changes == true)
        {
            notes.Insert(0, form.n);
            string jsonStr = JsonSerializer.Serialize(notes);
            File.WriteAllText(fileNotes, jsonStr);
            UpdateResults();
        }
    }

    private void period_Cb_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateResults();
    }

    private void UpdateResults()
    {
        if (notes.Count == 0) return;
        List<Note> filteredNotes = new();        

        switch (period_Cb.SelectedItem!.ToString())
        {
            case "Today":
                filteredNotes = notes.Where(i => i.DateTime.Date == DateTime.Now.Date).ToList();
                break;
            case "Week":
                filteredNotes = notes.Where(i => i.DateTime.AddDays(7).Date >= DateTime.Now.Date).ToList();                
                break;
            case "Month":
                filteredNotes = notes.Where(i => i.DateTime.AddMonths(1).Date >= DateTime.Now.Date).ToList();                
                break;
            case "All":
                filteredNotes = notes.ToList();
                break;
            default:
                return;
        }
        
        var res = filteredNotes.OrderByDescending(i => i.DateTime).ToList();
        dataGridView1.DataSource = res;
        var start = res.Last().DateTime.Date;
        var finish = res.First().DateTime.Date;
        var days = (int)(finish - start).TotalDays + 1;
        int value = 0;

        protein_Pb.Maximum = (int)set.Proteins;
        value = (int)filteredNotes.Sum(i => i.Proteins) / days;
        protein_Pb.Value = value > protein_Pb.Maximum ? protein_Pb.Maximum : value;
        prot_Lb.Text = $"{value} / {protein_Pb.Maximum}";
        prot_Lb.ForeColor = value >= protein_Pb.Maximum ? Color.Red : Color.Black;

        fat_Pb.Maximum = (int)set.Fats;
        value = (int)filteredNotes.Sum(i => i.Fats) / days;
        fat_Pb.Value = value > fat_Pb.Maximum ? fat_Pb.Maximum : value;
        fat_Lb.Text = $"{value} / {fat_Pb.Maximum}";
        fat_Lb.ForeColor = value >= fat_Pb.Maximum ? Color.Red : Color.Black;

        carbohydrates_Pb.Maximum = (int)set.Carbohydrates;
        value = (int)filteredNotes.Sum(i => i.Carbohydrates) / days;
        carbohydrates_Pb.Value = value > carbohydrates_Pb.Maximum ? carbohydrates_Pb.Maximum : value;
        carb_Lb.Text = $"{value} / {carbohydrates_Pb.Maximum}";
        carb_Lb.ForeColor = value >= carbohydrates_Pb.Maximum ? Color.Red : Color.Black;

        calories_Pb.Maximum = (int)set.Calories;
        value = (int)filteredNotes.Sum(i => i.Calories) / days;
        calories_Pb.Value = value > calories_Pb.Maximum ? calories_Pb.Maximum : value;
        calor_Lb.Text = $"{value} / {calories_Pb.Maximum}";
        calor_Lb.ForeColor = value >= calories_Pb.Maximum ? Color.Red : Color.Black;

        canEat = value >= calories_Pb.Maximum ? false : true;
    }

    private void Settings_Click(object sender, EventArgs e)
    {
        SettingsForm form = new (set);
        var result = form.ShowDialog();
        if (result == DialogResult.OK)
        {
            set = form.set;
            UpdateResults();
            string jsonStr = JsonSerializer.Serialize(set);
            File.WriteAllText(fileSettings, jsonStr);
        }
    }
}

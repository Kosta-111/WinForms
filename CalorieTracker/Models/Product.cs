namespace CalorieTracker.Models;
public enum Category
{
    None,
    Vegetables,
    Fruit,
    Grains,
    Meat,
    Seafood,
    Dairy,
    Eggs
}

public class Product
{
    public string Name { get; set; }

    public double Proteins { get; set; }

    public double Fats { get; set; }

    public double Carbohydrates { get; set; }

    public double Calories { get; set; }

    public Category ProductCategory { get; set; }

    public Product()
    {
        Name = "unknown";
        Proteins = 0;
        Fats = 0;
        Carbohydrates = 0;
        Calories = 0;
        ProductCategory = Category.None;
    }

    public Product(string name, double calories)
    {
        Name = name;
        Proteins = 0;
        Fats = 0;
        Carbohydrates = 0;
        Calories = calories;
        ProductCategory = Category.None;
    }

    public Product(string name, double proteins, double fats, double carbohydrates, double calories, Category category)
    {
        Name = name;
        Proteins = proteins;
        Fats = fats;
        Carbohydrates = carbohydrates;
        Calories = calories;
        ProductCategory = category;
    }

    public override string ToString()
    {
        return $"{Name} ({ProductCategory})\t\t\t P/F/C : {Proteins}/{Fats}/{Carbohydrates}\t\t Cal: {Calories}";
    }
}


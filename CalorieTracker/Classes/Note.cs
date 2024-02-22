namespace CalorieTracker.Classes;

class Note
{
    public DateTime DateTime { get; set; } = DateTime.Now;

    public Product Product { get; set; }

    public double Weight { get; set; }

    public double Proteins => Weight * Product.Proteins / 100;
    public double Fats => Weight * Product.Fats / 100;
    public double Carbohydrates => Weight * Product.Carbohydrates / 100;
    public double Calories => Weight * Product.Calories / 100;
}


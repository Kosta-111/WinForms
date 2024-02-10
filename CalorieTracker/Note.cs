namespace CalorieTracker;

class Note
{
    public DateTime DateTime { get; set; } = DateTime.Now;

    public Product Product { get; set; }

    public double Weight { get; set; }

    public double Proteins => Weight * Product.proteins / 100;
    public double Fats => Weight * Product.fats / 100;
    public double Carbohydrates => Weight * Product.carbohydrates / 100;
    public double Calories => Weight * Product.calories / 100;
}


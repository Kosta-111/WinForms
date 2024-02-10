using System;

namespace CalorieTracker
{
    public enum Category
    {
        Vegetables,
        Fruit,
        Grains,
        Meat,
        Seafood,
        Dairy,
        Eggs
    }

    internal class Product
    {
        private string name;
        private double proteins;
        private double fats;
        private double carbohydrates;
        private double calories;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Proteins
        {
            get { return proteins; }
            set { proteins = value; }
        }

        public double Fats
        {
            get { return fats; }
            set { fats = value; }
        }

        public double Carbohydrates
        {
            get { return carbohydrates; }
            set { carbohydrates = value; }
        }

        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public Category ProductCategory { get; set; }

        public Product()
        {
            Name = "unknown";
            Proteins = 0;
            Fats = 0;
            Carbohydrates = 0;
            Calories = 0;
        }

        public Product(string name, double calories)
        {
            Name = name;
            Proteins = 0;
            Fats = 0;
            Carbohydrates = 0;
            Calories = calories;
        }

        public Product(string name, double proteins, double fats, double carbohydrates, double calories)
        {
            Name = name;
            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Calories = calories;
        }
    }
}


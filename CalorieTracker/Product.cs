using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTracker
{
    internal class Product
    {
        enum Category
        {
            Vegetables,
            Fruit,
            Grains,
            Meat,
            Seafood,
            Dairy,
            Eggs
        }


        public string name;
        public double proteins;
        public double fats;
        public double carbohydrates;
        public double calories;


        public Product()
        {
            name = "unknown";
            proteins = 0;
            fats = 0;
            carbohydrates = 0;
            calories = 0;
        }

        public Product(string name, double proteins, double fats, double carbohydrates, double calories)
        {
            this.name = name;
            this.proteins = proteins;
            this.fats = fats;
            this.carbohydrates = carbohydrates;
            this.calories = calories;
        }

        
    }
}

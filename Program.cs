using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Buffet codingdojo = new Buffet();
            Ninja jon = new Ninja();
            jon.Eat(codingdojo.Serve());
            jon.Eat(codingdojo.Serve());
            jon.Eat(codingdojo.Serve());
            jon.Eat(codingdojo.Serve());
            jon.Eat(codingdojo.Serve());
        }
    }

    public class Food
    {
        public string Name;
        public int Calories;
        // Foods canbe Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string nameInput, int caloriesInput, bool isSpicyInput, bool isSweetInput)
        {
            Name = nameInput;
            Calories = caloriesInput;
            IsSpicy = isSpicyInput;
            IsSweet = isSweetInput;
        }
    }

    public class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Crab Legs", 400, false, false),
                new Food("Fried Chicken", 600, true, false),
                new Food("Greek Salad", 100, false, false),
                new Food("Spaghetti", 450, false, false),
                new Food("Sushi", 300, false, false),
                new Food("Macaroon", 150, false, true),
                new Food("Tiramisu", 200, false, true)
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }

    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public bool isFull
        {
            
            get
            {
                if(calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public void Eat(Food item)
        {
            if(!this.isFull)
            {
                this.calorieIntake += item.Calories;
                FoodHistory.Add(item);
                System.Console.WriteLine(item.Name);
                if(item.IsSpicy)
                {
                    System.Console.WriteLine("The food is spicy, becareful...");
                }
                if(item.IsSweet)
                {
                    System.Console.WriteLine("This food is so sweet!");
                }
            }
            else
            {
                System.Console.WriteLine("You've eaten too much, you can't eat anymore!");
            }
        }
    }
}

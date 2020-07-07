using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Fruitsalad
    {
        public Fruit[] _fruits;
        public int GetTotalCalories()
        {
            int totalCalories = 0;
            foreach (Fruit fruit in _fruits)
            {
                totalCalories += fruit._calories;
            }
            return totalCalories;
        }
        public bool ContainsMyFavoriteFruit()
        {
            foreach (Fruit fruit in _fruits)
            {
                if (fruit.IsThisMyFavorite())
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            string allFruits = "";
            foreach (Fruit fruit in _fruits)
            {
                allFruits += fruit.ToString() + "\n";

            }
            return allFruits;
        }

    }
}


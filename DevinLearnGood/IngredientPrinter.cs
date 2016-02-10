using System;
using System.Collections.Generic;
using System.Collections;

namespace DevinLearnGood
{
    public class IngredientPrinter
    {
        public List<string> GetPrintable(List<Ingredient> ingredients)
        {
            // I need to write code that will make a total string from the 3 properties of the Ingrediant List
            // as well as add some filler string text between those properties.

            // GetPrintable(List<Ingredient> ingredients) = new List<Ingredient>();

            Console.WriteLine($"2 Shots of Vodka");
            Console.WriteLine($"4 Leaves of Mint");

            foreach (var totalDrink in ingredients)
            {
                
            }


            throw new System.NotImplementedException();
        }
    }

    public class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string QuantityDescription { get; set; }
    }
}
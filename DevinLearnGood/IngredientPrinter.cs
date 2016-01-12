using System.Collections.Generic;

namespace DevinLearnGood
{
    public class IngredientPrinter
    {
        public List<string> GetPrintable(List<Ingredient> ingredients)
        {
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
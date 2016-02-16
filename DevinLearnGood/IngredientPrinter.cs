using System.Collections.Generic;
using System.Linq;

namespace DevinLearnGood
{
    public class IngredientPrinter
    {
        public List<string> GetPrintable(List<Ingredient> ingredients)
        {
            //ingredients.Where((Ingredient x) => { return true; })
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
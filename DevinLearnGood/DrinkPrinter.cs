using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinLearnGood
{
    public class DrinkPrinter
    {
        private string _prefix = "A awesome ";

        public string PrintDrink(string drinkName)
        {
            if (drinkName == null)
            {
                return _prefix + "alcoholic beverage";
            }
            if (drinkName == "")
            {
                return _prefix + "glass of Dihydrogen Monoxide on the rocks!";
            }

            return _prefix + drinkName.ToLower();

        }
    }
    
}

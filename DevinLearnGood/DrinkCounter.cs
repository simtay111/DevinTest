namespace DevinLearnGood
{
    public class DrinkCounter
    {
        private int EnjoyedBeverages = 0;

        public void EnjoyBeverage()
        {
            EnjoyedBeverages ++;

        }

        public int GetDrinksEnjoyed()
        {
            return EnjoyedBeverages;
        }
    }
}
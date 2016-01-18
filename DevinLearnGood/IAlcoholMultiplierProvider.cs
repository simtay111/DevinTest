using System;
using System.Security.Cryptography.X509Certificates;

namespace DevinLearnGood
{
    public interface IAlcoholMultiplierProvider
    {
        double GetMultiplier();
    }

    public interface IBitternessProvider
    {
        int GetBitterness();
    }
    public class CiderAlcoholMultiplierProvider : IAlcoholMultiplierProvider
    {
        public double GetMultiplier()
        {
            return 3.0;
        }
    }

    public class BeerAlcoholMultiplierProvider : IAlcoholMultiplierProvider, IBitternessProvider
    {
        public double GetMultiplier()
        {
            return 1;
        }

        public void DoThings()
        {

        }

        public int GetBitterness()
        {
            throw new NotImplementedException();
        }
    }

    public class WineAlcoholMultiplierProvider : IAlcoholMultiplierProvider
    {
        //public double GetMultiplier()
        //{
        //    return 1.5;
        //}
        public double GetMultiplier()
        {
            return 1.5;
        }
    }

    public class MockedAlcoholProvider : IAlcoholMultiplierProvider
    {
        private double _valueToReturn;

        public double GetMultiplier()
        {
            return _valueToReturn;
        }

        public void SetupProviderToReturnMultipler(double valueToReturn)
        {
            _valueToReturn = valueToReturn;
        }
    }
}
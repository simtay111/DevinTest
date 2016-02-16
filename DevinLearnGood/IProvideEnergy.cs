namespace DevinLearnGood
{
    public interface IProvideMilesPerGallon
    {
        int GetMilesPerGallon();
    }

    public class EthanolMilesPerGallonProvider : IProvideMilesPerGallon
    {
        public int GetMilesPerGallon()
        {
            return 500;
        }
    }

    public class DrivableDistanceCalculator
    {
        private readonly IProvideMilesPerGallon _milesPerGallonProvider;

        public DrivableDistanceCalculator(IProvideMilesPerGallon milesPerGallonProvider)
        {
            _milesPerGallonProvider = milesPerGallonProvider;
        }

        public int HowManyMilesCanIgetWithProvidedGallonsOfGas(int gallonsOfGas)
        {
           return _milesPerGallonProvider.GetMilesPerGallon() * gallonsOfGas;
         
        }

    }
}
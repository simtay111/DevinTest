using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class DrinkPrinterTests
    {
        private DrinkPrinter _printer;

        [SetUp]
        public void SetUp()
        {
            _printer = new DrinkPrinter();
        }

        [Test]
        public void ReturnsVerboseNameOfDrinkFromSimpleName()
        {
            var resultingString = _printer.PrintDrink("Martini");

            resultingString.Should().Be("A awesome martini");

            resultingString = _printer.PrintDrink("Coors Lite");

            resultingString.Should().Be("A awesome coors lite");
        }

        [Test]
        public void IfNothingIsGivenForDrinkNameItUsesADefaultValue()
        {
            var resultingString = _printer.PrintDrink(null);

            resultingString.Should().Be("A awesome alcoholic beverage");
        }

        [Test]
        public void IfTheUserTypesNothingItServesUpAnEmptyGlass()
        {
            var resultingString = _printer.PrintDrink("");

            resultingString.Should().Be("A awesome glass of Dihydrogen Monoxide on the rocks!");
        }
    }
}

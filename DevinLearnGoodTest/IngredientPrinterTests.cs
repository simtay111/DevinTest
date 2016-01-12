using System.Collections.Generic;
using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class IngredientPrinterTests
    {
        private IngredientPrinter _printer;

        [SetUp]
        public void Setup()
        {
            _printer = new IngredientPrinter();
        }

        [Test]
        public void CanPrintOutIngredients()
        {
            var ingredients = new List<Ingredient>();
            var ingredient1 = new Ingredient { Name = "Vodka", Quantity = 2, QuantityDescription = "Shots" };
            var ingredient2 = new Ingredient { Name = "Mint", Quantity = 4, QuantityDescription = "Leaves" };
            ingredients.Add(ingredient1);
            ingredients.Add(ingredient2);

            var results = _printer.GetPrintable(ingredients);

            results[0].Should().Be("2 Shots of Vodka");
            results[1].Should().Be("4 Leaves of Mint");
        }

        [Test]
        public void CanPrintOutIngredientsWithNoQuantity()
        {
            var ingredients = new List<Ingredient>();
            var ingredient1 = new Ingredient { Name = "Vodka", Quantity = 0, QuantityDescription = "Shots" };
            var ingredient2 = new Ingredient { Name = "Mint", Quantity = 0, QuantityDescription = "Leaves" };
            ingredients.Add(ingredient1);
            ingredients.Add(ingredient2);

            var results = _printer.GetPrintable(ingredients);

            results[0].Should().Be("Vodka");
            results[1].Should().Be("Mint");
        }

        [Test]
        public void CanPrintOutIngredientsWithNoQuantityDescriptoins()
        {
            var ingredients = new List<Ingredient>();
            var ingredient1 = new Ingredient { Name = "Vodka", Quantity = 2, QuantityDescription = "" };
            var ingredient2 = new Ingredient { Name = "Mint", Quantity = 4, QuantityDescription = "" };
            ingredients.Add(ingredient1);
            ingredients.Add(ingredient2);

            var results = _printer.GetPrintable(ingredients);

            results[0].Should().Be("Vodka X 2");
            results[1].Should().Be("Mint X 4");
        }
    }
}
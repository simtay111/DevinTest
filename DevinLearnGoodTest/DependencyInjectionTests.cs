using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class DependencyInjectionTests
    {
        [Test]
        public void CanHandleENglishEmployee()
        {
            var employee = new Employee(new EnglishTranslator());

            var spokenResult = employee.Speak("Hello");

            spokenResult.Should().Be("Hello");
        }

        [Test]
        public void CanHandleFrenchEmployee()
        {
            var employee = new Employee(new FrenchTranslator());

            var spokenResult = employee.Speak("Hello");

            spokenResult.Should().Be("HelloFrench");
        }
    }
}
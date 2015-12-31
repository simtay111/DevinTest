using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace DevinTest
{
    public class Targeter
    {
        private readonly IWeatherFilter _weatherFilter;

        public Targeter(IWeatherFilter weatherFilter)
        {
            _weatherFilter = weatherFilter;
        }

        public bool ShouldFire()
        {
            return _weatherFilter.IsGoodWeather();
        }
    }

    public interface IWeatherFilter
    {
        bool IsGoodWeather();
    }

    public class WeatherFilter : IWeatherFilter
    {
        public bool IsGoodWeather()
        {
            //return true;
            return false;
        }
    }


    public class TargeterTests
    {
        [Test]
        public void SHouldFireIfWeatherIsGood()
        {
            var mockedWeatherFilter = new Mock<IWeatherFilter>();
            mockedWeatherFilter.Setup(x => x.IsGoodWeather()).Returns(true);

            var classToTest = new Targeter(mockedWeatherFilter.Object);

            classToTest.ShouldFire().Should().BeTrue();
        }

        [Test]
        public void ShouldNotFireIfWeatherIsBad()
        {
            var mockedWeatherFilter = new Mock<IWeatherFilter>();
            mockedWeatherFilter.Setup(x => x.IsGoodWeather()).Returns(false);

            var classToTest = new Targeter(mockedWeatherFilter.Object);

            classToTest.ShouldFire().Should().BeFalse();
        }
    }

    public class WeatherFilterTests
    {
        
    }
}

using System;
using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class IronmanFlightControlTests
    {
        private IronmanFlightControl _flightControl;

        [SetUp]
        public void Setup()
        {
            _flightControl = new IronmanFlightControl();
        }

        [Test]
        public void EnsureValidFlightAuthorizationIdIsProvided()
        {
            var jetpack = new Jetpack { Id = 0, Name = "Variable Specific Impulse Magnetoplasma Rocket (VASIMR)" };

            var ex = Assert.Throws<Exception>(() => _flightControl.CanMake(jetpack, 0, 100, 42));
            ex.Message.Should().Be("*JARVIS* \"Sir, I cannot allow you to fly to your destination without a valid flight authorization ID.\"");
        }

        [Test]
        public void ReturnsPrecalculatedFailResultForAltitudeTooHighForSuit()
        {
            var jetpack = new Jetpack { Id = 9, MaxAltitudeInThousandsOfFeet = 50001 };

            var result = _flightControl.CanMake(jetpack, 0, 100, 42);

            result.FailureMessage.Should().
                Be("*JARVIS* \"Sir, I do not recommend flying to that altitude unless you want to gamble loss of flight capabilities due to high altitude freezing.\"");
            result.CanMakeIt.Should().Be(false);
        }

        [Test]
        public void EveryTenPoundsOfTotalSuitWeightReducesFuelEfficiencyByFactorOfOnePercentAndReturnsDescriptiveWarning()
        {
            var jetpack = new Jetpack { Id = 9, MaxAltitudeInThousandsOfFeet = 42000, SuitWeightInPounds = 240, TonyStarksWeightInPounds = 200, FuelEfficiencyInPercentage = 100, DirectionControlRating = 100 };

            var result = _flightControl.CanMake(jetpack, 0, 100, 42);

            result.CanMakeIt.Should().BeTrue();
            result.WarningMessages.Count.Should().Be(1);
            result.WarningMessages[0].Should()
                .Be($"*JARVIS* \"Sir, I've made the necessary preflight weight optimization calculations, and am informing you that your flight efficiency will be reduced down to 99%.\"");
        }

        [Test]
        public void EveryTwoPointsOfInefficientDirectionControlEffectsFuelEfficiencyByFactorOfOnePercentAndReturnsDescriptiveWarningMessage()
        {
            var jetpack = new Jetpack { Id = 9, MaxAltitudeInThousandsOfFeet = 42000, SuitWeightInPounds = 225, TonyStarksWeightInPounds = 200, FuelEfficiencyInPercentage = 100, DirectionControlRating = 96 };

            var result = _flightControl.CanMake(jetpack, 0, 100, 42);

            result.CanMakeIt.Should().BeTrue();
            result.WarningMessages.Count.Should().Be(1);
            result.WarningMessages[0].Should()
                .Be($"*JARVIS* \"Sir, I've made the necessary preflight direction control optimization calculations, and am informing you that your flight efficiency will be reduced down to 98%.\"");
        }

        [Test]
        public void CanWarnAboutWeightAndDirectionalControlFlaws()
        {
            var jetpack = new Jetpack { Id = 9, MaxAltitudeInThousandsOfFeet = 42000, SuitWeightInPounds = 240, TonyStarksWeightInPounds = 200, FuelEfficiencyInPercentage = 100, DirectionControlRating = 96 };

            var result = _flightControl.CanMake(jetpack, 0, 100, 42);

            result.CanMakeIt.Should().BeTrue();
            result.WarningMessages.Count.Should().Be(2);
            result.WarningMessages[0].Should()
                .Be($"*JARVIS* \"Sir, I've made the necessary preflight weight optimization calculations, and am informing you that your flight efficiency will be reduced down to 97%.\"");
            result.WarningMessages[1].Should()
                .Be($"*JARVIS* \"Sir, I've made the necessary preflight direction control optimization calculations, and am informing you that your flight efficiency will be reduced down to 97%.\"");
        }

        [Test]
        public void WillOnlyShowFailureMEssageWithNoWarningMessagesIfAllCalcuationsResultedInZeroEffeciency()
        {
            var jetpack = new Jetpack { Id = 9, MaxAltitudeInThousandsOfFeet = 42000, SuitWeightInPounds = 400, TonyStarksWeightInPounds = 200, FuelEfficiencyInPercentage = 100, DirectionControlRating = 0 };

            var result = _flightControl.CanMake(jetpack, 0, 100, 42);

            result.CanMakeIt.Should().BeFalse();
            result.FailureMessage.Should().Be($"*JARVIS* \"Sir, I've calculated that you will not make it do to sub zero fuel effeciency.\"")
            result.WarningMessages.Count.Should().Be(0);
        }

        [Test]
        public void ReturnsPrecalculatedFailResultForNotEnoughTotalFlightFuel()
        {
            // nerp
        }

    }
}

//Ensure ID Is provided
//Return failed result if above max altitude
// Every ten pounds reduces fueld effeciency by 1.0     === verification should be on fuel burned
// Every Point down from Direction Control Rating (1- 10) costs 1 fuel effeciency === verification should be on fueld burned
// Returns failed result if not enough fuel to make it

//ONCE DONE
//  Throws exception if starting fuel is over MAX fuel
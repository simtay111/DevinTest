using System;
using DevinLearnGood;
using FluentAssertions;
using NUnit.Framework;

namespace DevinLearnGoodTest
{
    [TestFixture]
    public class IronmanWeaponsFireControlTests
    {
        private IronmanWeaponsFireControl _fireControl;

        [SetUp]
        public void SetUp()
        {
            _fireControl = new IronmanWeaponsFireControl();
        }

        [Test] //Simulation validation of the data
        public void WeaponNeedsAnIdToFire()
        {
            var weapon = new Weapon { Id = 0, Ammunition = 44 };

            var ex = Assert.Throws<Exception>(() => _fireControl.FireOnce(weapon));
            ex.Message.Should().Be("Cannot fire weapon without an ID");
        }

        [Test] //Simulation validation of the data
        public void WeaponCannotFireIfNoAmmunitionIsLeft()
        {
            var weapon = new Weapon { Id = 44, Ammunition = 0 };

            var ex = Assert.Throws<Exception>(() => _fireControl.FireOnce(weapon));
            ex.Message.Should().Be("Weapon (44) has no ammunition left");
        }

        [Test]//Simulating something readable despite no user input
        public void ReturnsDescriptionWithoutNameBeingSet()
        {
            var weapon = new Weapon { Id = 44, Ammunition = 4 };

            var result = _fireControl.FireOnce(weapon);

            result.Description.Should().Be("Weapon (44): 'NO NAME' was fired and did 0 damage");
        }

        [Test] //Simulates how a full descriptoin can be provided
        public void CreatesValidDescriptionWhenNameIsProvided()
        {
            var weapon = new Weapon { Id = 44, Damage = 3, Name = "Gun", Ammunition = 4 };

            var result = _fireControl.FireOnce(weapon);

            result.Description.Should().Be("Weapon (44): 'Gun' was fired and did 3 damage");
        }

        [Test]  //Simulating no user input
        public void CanCalculateDamageWhenMultiplierIsNotSet()
        {
            var weapon = new Weapon { Id = 44, Damage = 3, Ammunition = 4 };

            var result = _fireControl.FireOnce(weapon);

            result.DamageDone.Should().Be(3);
        }

        [Test] //Simulates computation from instance values
        public void MultipliesDamageByMultiplier()
        {
            var weapon = new Weapon { Id = 44, Damage = 3, DamageMultiplierFromEnhancements = 4, Ammunition = 4 };

            var result = _fireControl.FireOnce(weapon);

            result.DamageDone.Should().Be(12);
        }

        [Test]
        public void ReturnsTheWeaponUsedToFireWithOneLessShotInTheAmmunition()
        {
            var weapon = new Weapon { Id = 44, Damage = 3, Ammunition = 4 };

            var result = _fireControl.FireOnce(weapon);

            result.WeaponUsed.Should().BeSameAs(weapon);
            result.WeaponUsed.Ammunition.Should().Be(3);
            weapon.Ammunition.Should().Be(3);
        }
    }
}
using System;

namespace DevinLearnGood
{
    public class IronmanWeaponsFireControl
    {
        public WeaponFireResult FireOnce(Weapon weapon)
        {
            EnsureWeaponIdWasProvided(weapon);

            EnsureWeaponHasAmmunition(weapon);
            
            var weaponFireResult = FireWeaponAndGenerateResult(weapon);

            CalculateWeaponDamanage(weapon, weaponFireResult);

            return weaponFireResult;
        }

        private void EnsureWeaponIdWasProvided(Weapon weapon)
        {
            if (weapon.Id <= 0)
                throw new Exception(
                    CreatFormattedString("I cannot allow you to fire weapons without a valid Weapon ID to utilize.\""));
        }

        private void EnsureWeaponHasAmmunition(Weapon weapon)
        {
            if (weapon.Ammunition <= 0)
                throw new Exception(
                    CreatFormattedString(
                        $"Weapon ({weapon.Id}) has zero ammunition left. Recommend switching to backup repulsor weapons.\""));
        }

        private string CreatFormattedString(string message)
        {
            return $"*JARVIS* \"Sir, " + message;
        }

        private WeaponFireResult FireWeaponAndGenerateResult(Weapon weapon)
        {
            var weaponFireResult = new WeaponFireResult();
            var weaponName = GetWeaponNameOrUseDefault(weapon);
            weaponFireResult.Description =
                CreatFormattedString(
                    $"Weapon ({weapon.Id}): '{weaponName}' was fired, and did {weapon.Damage} damage on target.\"");
            weapon.Ammunition--;
            weaponFireResult.WeaponUsed = weapon;
            return weaponFireResult;
        }

        private static string GetWeaponNameOrUseDefault(Weapon weapon)
        {
            var weaponName = string.IsNullOrEmpty(weapon.Name) ? "UNNAMED Prototype" : weapon.Name;
            return weaponName;
        }

        private static void CalculateWeaponDamanage(Weapon weapon, WeaponFireResult weaponFireResult)
        {
            if (weapon.DamageMultiplierFromEnhancements <= 0)
            {
                int mathematicallyCorrectDamageMultiplierFromEnhancements = 1;
                weaponFireResult.DamageDone += weapon.Damage*mathematicallyCorrectDamageMultiplierFromEnhancements;
            }
            else
            {
                weaponFireResult.DamageDone += weapon.Damage*weapon.DamageMultiplierFromEnhancements;
            }
        }
    }

    public class WeaponFireResult
    {
        public int DamageDone { get; set; }
        public string Description { get; set; }
        public Weapon WeaponUsed { get; set; }
    }

    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ammunition { get; set; }
        public int Damage { get; set; }
        public int DamageMultiplierFromEnhancements { get; set; }
    }
}
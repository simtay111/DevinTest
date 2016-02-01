namespace DevinLearnGood
{
    public class IronmanWeaponsFireControl
    {
        public WeaponFireResult FireOnce(Weapon weapon)
        {
            throw new System.NotImplementedException();
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
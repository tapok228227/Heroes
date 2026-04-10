using Heroes.Core.Weapons;
using Heroes.Core.Weapons.Base;
using Heroes.Core.Weapons.Mage;
using Heroes.Core.Weapons.Physical;

namespace Heroes.Core.Factories;

public static class WeaponFactory
{
    public static WeaponBase CreateMageSword(string name, int damage, int mageDamage)
    {
        return new MageSword()
        {
            Name = name,
            Damage = damage,
            MageDamage = mageDamage
        };
    }
    
    public static WeaponBase CreateWarriorSword(string name, int damage, int warriorDamage)
    {
        return new PhysicalSword()
        {
            Name = name,
            Damage = damage,
            PhysicalDamage = warriorDamage
        };
    }
}
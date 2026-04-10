using Heroes.Core.Weapons.Base;

namespace Heroes.Core.Weapons.Physical;

public class PhysicalSword : WeaponBase, IPhysicalWeapon
{
    public int PhysicalDamage { get; init; }
}
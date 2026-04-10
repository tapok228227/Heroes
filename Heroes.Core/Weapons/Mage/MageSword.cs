using Heroes.Core.Weapons.Base;

namespace Heroes.Core.Weapons.Mage;

public class MageSword : WeaponBase, IMageWeapon
{
    public int MageDamage { get; init; }
}
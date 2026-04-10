using Heroes.Core.Heroes.Base;
using Heroes.Core.Heroes.Interfaces;
using Heroes.Core.Weapons;
using Heroes.Core.Weapons.Base;
using Heroes.Core.Weapons.Mage;

namespace Heroes.Core.Heroes;

public class Mage : HeroBase, IMage
{
    public override WeaponBase? Weapon
    {
        get;
        set
        {
            if (value is IMageWeapon mageWeapon)
            {
                field = value;
            }
        }
    }

    public override void Attack(Person enemy)
    {
        base.Attack(enemy);
        MagicAttack(enemy);
    }

    public void MagicAttack(Person enemy)
    {
        //var weaponDamageValue = ((IMageWeapon)Weapon).MageDamage;
        var weaponDamageValue = (Weapon as IMageWeapon)?.MageDamage ?? 0;
        var enemyHero = enemy as HeroBase;

        enemyHero.Health -= weaponDamageValue;
    }
}
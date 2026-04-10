using Heroes.Core.Heroes.Base;
using Heroes.Core.Heroes.Interfaces;
using Heroes.Core.Weapons;
using Heroes.Core.Weapons.Base;
using Heroes.Core.Weapons.Physical;

namespace Heroes.Core.Heroes;

public class Warrior : HeroBase, IWarrior
{
    public override WeaponBase? Weapon 
    { 
        get;
        set
        {
            if (value is IPhysicalWeapon physicalWeapon)
            {
                field = value;
            }
        } 
    }

    public override void Attack(Person enemy)
    {
        base.Attack(enemy);
        PhysicalAttack(enemy);
    }

    public void PhysicalAttack(Person enemy)
    {
        var weaponDamageValue = ((IPhysicalWeapon)Weapon).PhysicalDamage;
        var enemyHero = (HeroBase)enemy;

        enemyHero.Health -= weaponDamageValue;
    }
}
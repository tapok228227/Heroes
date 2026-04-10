using Heroes.Core.Weapons;
using Heroes.Core.Weapons.Base;

namespace Heroes.Core.Heroes.Base;

public abstract class HeroBase : Person, IAttack
{
    public abstract WeaponBase? Weapon { get; set; } 
    
    public int Health
    {
        get;
        set => field = value < 0 ? 0 : value; //TODO: вынести в метод валидации
    }

    public int Damage
    {
        get;
        init => field = value < 0 ? 0 : value; //TODO: вынести в метод валидации
    }
    
    public bool IsAlive => this.Health > 0 ;
    public bool IsDead => !this.IsAlive;

    protected virtual int TotalDamage => this.Damage + Weapon?.Damage ?? 0;

    public virtual void Attack(Person enemy)
    {
        var heroEnemy = (HeroBase)enemy;
        heroEnemy.Health -= TotalDamage;
    }
}
using Heroes.Core.Heroes;
using Heroes.Core.Heroes.Base;

namespace Heroes.Core.Factories;

public static class HeroFactory
{
    public static HeroBase CreateMage(string name, int health, int damage)
    {
        return new Mage()
        {
            Name = name,
            Health = health,
            Damage = damage
        };
    }

    public static HeroBase CreateWarrior(string name, int health, int damage)
    {
        return new Warrior()
        {
            Name = name,
            Health = health,
            Damage = damage
        };
    }
}
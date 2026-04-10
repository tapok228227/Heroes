namespace Heroes.Core.Weapons.Base;

public abstract class WeaponBase
{
    public required string Name { get; init; }
    public int Damage { get; init; }
}
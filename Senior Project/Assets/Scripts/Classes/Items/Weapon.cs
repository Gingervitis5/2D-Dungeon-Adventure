using System;
public class Weapon : Item
{
    protected int MaxDamage, MinDamage, RoundsPerAction;
    protected double CritChance, CritMultiplier, Handling;
    protected string WeaponType;

    public Weapon(string name) : base(name) { }

    public void SetStats(int max, int min, int rpa, double critChance, double critMult, double handling)
    {
        MaxDamage = max; MinDamage = min;
        RoundsPerAction = rpa;
        CritChance = critChance; CritMultiplier = critMult;
        Handling = handling;
    }

    public void SetWeaponType(string type)
    {
        WeaponType = type;
    }

    public string GetWeaponType()
    {
        return WeaponType;
    }

    public int getMaxDamage() { return MaxDamage; }
    public int getMinDamage() { return MinDamage; }
    public double getHandling() { return Handling; }
    public double getCritChance() { return CritChance; }
    public double getCritMultiplier() { return CritMultiplier; }
    public int getRoundsPerAction() { return RoundsPerAction; }
}

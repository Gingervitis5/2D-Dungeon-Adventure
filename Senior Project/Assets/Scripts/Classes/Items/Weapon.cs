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

    public int GetMaxDamage() { return MaxDamage; }
    public int GetMinDamage() { return MinDamage; }
    public double GetHandling() { return Handling; }
    public double GetCritChance() { return CritChance; }
    public double GetCritMultiplier() { return CritMultiplier; }
    public int GetRoundsPerAction() { return RoundsPerAction; }
}

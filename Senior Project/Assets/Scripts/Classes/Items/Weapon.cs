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

<<<<<<< HEAD
    public int getMaxDamage() { return MaxDamage; }
    public int getMinDamage() { return MinDamage; }
    public double getHandling() { return Handling; }
    public double getCritChance() { return CritChance; }
    public double getCritMultiplier() { return CritMultiplier; }
    public int getRoundsPerAction() { return RoundsPerAction; }
=======
    public int GetMaxDamage() { return MaxDamage; }
    public int GetMinDamage() { return MinDamage; }
    public double GetHandling() { return Handling; }
    public double GetCritChance() { return CritChance; }
    public double GetCritMultiplier() { return CritMultiplier; }
    public int GetRoundsPerAction() { return RoundsPerAction; }
>>>>>>> be95e78810f9adc1a1524b5ca21b78f2444a4a44
}

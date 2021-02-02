using System;
public class Weapon : Item
{
    protected int MaxDamage, MinDamage, RoundsPerAction;
    protected double CritChance, CritMultiplier, Handling;

    public Weapon(string name) : base(name)
    {}

    public void SetStats(int max, int min, int rpa, double critChance, double critMult, double handling)
    {
        MaxDamage = max; MinDamage = min;
        RoundsPerAction = rpa;
        CritChance = critChance; CritMultiplier = critMult;
        Handling = handling;
    }

}

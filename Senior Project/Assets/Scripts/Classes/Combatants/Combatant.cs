using System;
using UnityEngine;
public abstract class Combatant : ScriptableObject
{
    protected int Health, HealthMax, Shield, ShieldMax, Initiative;
    protected int Brawn, Agility, Luck, Reason, Wit, Glamour;
    protected double Aim, CritChance, CritMultiplier, Dodge;
    protected Weapon weapon;
    public string CharacterName;
    public Sprite CharacterImage;

}

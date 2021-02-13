using System;
using UnityEngine;
public abstract class Ally : Combatant
{
    protected int Level, EXP, NextEXP;
    protected string CharClass;

    public int GetBrawn() { return this.Brawn; }
    public int GetAgility() { return this.Agility; }
    public int GetLuck() { return this.Luck; }
    public int GetReason() { return this.Reason; }
    public int GetWit() { return this.Wit; }
    public int GetGlamour() { return this.Glamour; }
    public Weapon GetWeapon() { return this.weapon; }
    public int GetLevel() { return this.Level; }
    public string GetClass() { return this.CharClass; }

    public void SetBrawn(int brawn) { this.Brawn = brawn; }
    public void SetAgility(int agility) { this.Agility = agility; }
    public void SetLuck(int luck) { this.Luck = luck; }
    public void SetReason(int reason) { this.Reason = reason; }
    public void SetWit(int wit) { this.Wit = wit; }
    public void SetGlamour(int glamour) { this.Glamour = glamour; }
    public void SetWeapon(Weapon newWeapon) { this.weapon = newWeapon; }
    public void SetLevel(int level) { this.Level = level; }
    public void SetClass(string charClass) { this.CharClass = charClass; }
}

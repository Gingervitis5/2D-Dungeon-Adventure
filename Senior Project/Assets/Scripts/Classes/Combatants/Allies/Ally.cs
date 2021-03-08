using System;
using UnityEngine;
public abstract class Ally : Combatant
{
    protected int Level, EXP, NextEXP;
    protected string CharClass;
    protected bool skillTwoUnlocked = false;
    protected bool skillThreeUnlocked = false;
    protected bool skillFourUnlocked = false;

    enum SkillType
    {
        Self,
        Ally,
        AllAlly,
        Enemy,
        BoostAttack
    }

    public int GetLevel() { return this.Level; }
    public string GetClass() { return this.CharClass; }
    public bool GetSkillTwoUnlocked() { return this.skillTwoUnlocked; }
    public bool GetSkillThreeUnlocked() { return this.skillThreeUnlocked; }
    public bool GetSkillFourUnlocked() { return this.skillFourUnlocked; }

    public void SetLevel(int level) { this.Level = level; }
    public void SetClass(string charClass) { this.CharClass = charClass; }

    public void SetSkillTwoUnlocked(bool b) { this.skillTwoUnlocked = b; }
    public void SetSkillThreeUnlocked(bool b) { this.skillThreeUnlocked = b; }
    public void SetSkillFourUnlocked(bool b) { this.skillFourUnlocked = b; }
}

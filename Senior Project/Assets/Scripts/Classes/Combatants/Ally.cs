using System;
using UnityEngine;
public abstract class Ally : Combatant
{
    protected int Level, EXP, NextEXP;
    protected string CharClass;

    public int GetLevel() { return this.Level; }
    public string GetClass() { return this.CharClass; }

    public void SetLevel(int level) { this.Level = level; }
    public void SetClass(string charClass) { this.CharClass = charClass; }
}

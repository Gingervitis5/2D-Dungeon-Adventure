using System;
using UnityEngine;
public abstract class Ally : Combatant
{
    protected int Level, EXP, NextEXP;

    public int GetLevel() { return this.Level; }
    public void SetLevel(int level) { this.Level = level; }
}

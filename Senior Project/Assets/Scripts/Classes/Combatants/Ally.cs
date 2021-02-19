using System;
using UnityEngine;
public abstract class Ally : Combatant
{
    protected int Level, EXP, NextEXP;

    public int GetLevel() { return this.Level; }
<<<<<<< HEAD
=======
    public string GetClass() { return this.CharClass; }

>>>>>>> be95e78810f9adc1a1524b5ca21b78f2444a4a44
    public void SetLevel(int level) { this.Level = level; }
}

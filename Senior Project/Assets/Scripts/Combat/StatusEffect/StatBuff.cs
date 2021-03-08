using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatBuff : StatusEffect
{
    protected int buff;

    public int GetBuff() { return this.buff; }
    public void SetBuff(int b) { this.buff = b; }
}

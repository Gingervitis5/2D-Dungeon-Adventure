using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Combatant
{
    protected int expValue;

    public int GetExpValue() { return this.expValue; }

    public void SetExpValue(int i) { this.expValue = i;  }
}

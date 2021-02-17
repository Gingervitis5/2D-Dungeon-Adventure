using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatusEffect : MonoBehaviour
{
    protected Combatant com;
    protected int duration;

    public Combatant GetCombatant() { return this.com; }
    public void SetCombatant(Combatant c) { this.com = c; }
    public int GetDuration() { return this.duration; }
    public void SetDuration(int d) { this.duration = d; }
}

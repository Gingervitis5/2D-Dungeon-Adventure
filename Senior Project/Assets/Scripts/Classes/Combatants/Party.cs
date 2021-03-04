using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party 
{
    List<Combatant> list = new List<Combatant>();
    bool isAI;

    public Party(List<Combatant> l, bool b)
    {
        this.list = l;
        this.isAI = b;
    }

    public List<Combatant> GetList() { return this.list; }
    public void SetLinkedList(List<Combatant> l) { this.list = l; }
    public bool GetIsAI() { return this.isAI; }
    public void SetIsAI(bool b) { this.isAI = b; }
}

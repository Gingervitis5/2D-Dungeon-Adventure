using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgilityBuff : StatBuff
{
    AgilityBuff(Combatant c, int buff, int dur)
    {
        this.com = c;
        this.buff = buff;
        this.duration = dur;
    }
    
    public void Apply()
    {
        //this.com.GetAgility() = this.com.GetAgility() + this.buff;
    }
    public void Tick()
    {
        this.duration--;
    }
    public void Remove()
    {
        //this.com.GetAgility() = this.com.GetAgility() - this.buff;
    }
}

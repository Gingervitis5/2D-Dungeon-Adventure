using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : Ally
{
    public Sprite sprite;
    protected string skillOneType = "AllyAllBuff";
    protected string skillTwoType = "AllyAllBuff";
    protected string skillThreeType = "EnemyAllAttack";
    protected string skillFourType = "AllySingleBuff";

    public void SkillOne(Party p)
    {
        Combatant c;
        for (int i = 0; i < p.GetList().Count; i++)
        {
            //Apply a 10% damage increase for All, 4 turns
        }
    }
    public void SkillTwo(Party p)
    {
        Combatant c;
        for (int i = 0; i < p.GetList().Count; i++)
        {
            //Apply a 10% Health Regin for All, 4 turns
        }
    }
    public double SkillThree()
    {
        return 65;
    }
    public void SkillFour(Combatant c)
    {
        //Ally a SE that triggers at death and revives with 40% Health, for 4 turns 
    }

    public string getSkillOneType() { return this.skillOneType; }
    public string getSkillTwoType() { return this.skillTwoType; }
    public string getSkillThreeType() { return this.skillThreeType; }
    public string getSkillFourType() { return this.skillFourType; }

    public void setSkillOneType(string s) { this.skillOneType = s; }
    public void setSkillTwoType(string s) { this.skillTwoType = s; }
    public void setSkillThreeType(string s) { this.skillThreeType = s; }
    public void setSkillFourType(string s) { this.skillFourType = s; }
}

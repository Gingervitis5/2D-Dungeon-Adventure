using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operative : Ally
{
    protected string skillOneType = "Attack";
    protected string skillTwoType = "";
    protected string skillThreeType = "";
    protected string skillFourType = "";

    private bool stealth = false;

    public double SkillOne(Combatant c)
    {
        double damage;
        //Apply status effect for one turn (Single attack )
        //50% damage boost (Weapon)
        //25% Crit Chance
        damage = this.Attack(c);
        return damage;
    }
    public void SkillTwo()
    {
        stealth = true;
        //Apply miss chance status effect (40%)
        //Apply status effect damage increase (60%)
    }
    public void SkillThree()
    {

    }
    public void SkillFour()
    {

    }

    /*public override double Attack(Combatant c)
    {
        Weapon w = c.GetWeapon();
        double cChance = c.GetCritChance() + w.GetCritChance(), critMult = c.GetCritMultiplier() + w.GetCritMultiplier();
        double damage = 0;
        for (int i = 0; i < w.GetRoundsPerAction(); i++)
        {
            int roundDamage = Random.Range(w.GetMinDamage() + 1, w.GetMaxDamage() + 1);
            if (Random.Range(0, 101) < (w.GetHandling() + c.GetDodge() - this.aim)) //Checks for if the round hits the target
            {
                if (Random.Range(0, 101) < cChance) //Checks for if the round is a critical hit
                {
                    damage = damage + (roundDamage * critMult);
                }
                else
                {
                    damage = damage + roundDamage;
                }
            }
        }
        Debug.Log("Damage: " + damage);
        stealth = false;
        return damage;
    }*/

    public string getSkillOneType() { return this.skillOneType; }
    public string getSkillTwoType() { return this.skillTwoType; }
    public string getSkillThreeType() { return this.skillThreeType; }
    public string getSkillFourType() { return this.skillFourType; }

    public void setSkillOneType(string s) { this.skillOneType = s; }
    public void setSkillTwoType(string s) { this.skillTwoType = s; }
    public void setSkillThreeType(string s) { this.skillThreeType = s; }
    public void setSkillFourType(string s) { this.skillFourType = s; }
}

using System;
using UnityEngine.UI;
using UnityEngine;

public class Technician : Ally
{
    public Sprite sprite;
    protected string skillOneType = "AllySingleBuff";
    protected string skillTwoType = "";
    protected string skillThreeType = "";
    protected string skillFourType = "";

    public void SkillOne(Combatant c)
    {
        //Apply SE to increase c's Max Health and Shields
        c.SetHealth(c.GetHealth() + 30);
        c.SetShield(c.GetShield() + 30);
    }
    public void SkillTwo()
    {

    }
    public void SkillThree()
    {

    }
    public void SkillFour()
    {

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

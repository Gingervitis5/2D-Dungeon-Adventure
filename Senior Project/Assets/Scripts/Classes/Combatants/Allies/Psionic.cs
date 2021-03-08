using System;
using UnityEngine.UI;
using UnityEngine;

public class Psionic : Ally
{
    public Sprite sprite;
    protected string skillOneType = "EnemyAttack";
    protected string skillTwoType = "";
    protected string skillThreeType = "";
    protected string skillFourType = "EnemyAttack";

    public double SkillOne()//Does this deal damage?
    {
        //Apply debuff to a random enemy stat
        return 35;
    }
    public void SkillTwo()
    {

    }
    public void SkillThree()
    {

    }
    public double SkillFour()
    {
        //Applies a stun debuff to enemies.
        return 100;
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

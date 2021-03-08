using System;
using UnityEngine.UI;
using UnityEngine;

public class Scholar : Ally
{
    public Sprite sprite;
    protected string skillOneType = "EnemyDebuff";
    protected string skillTwoType = "EnemyAllAttack";
    protected string skillThreeType = "EnemyAllDebuff";
    protected string skillFourType = "EnemyAllAttack";

    public void SkillOne()
    {
        //Applys debuff on single enemy that increases damage to by 10% for three turns
    }
    public double SkillTwo()
    {
        //Applys the Fire debuff to all enemies.
        return 20; //This is the ccurrent base damage for Firebomb
    }
    public void SkillThree()
    {
        //Applys debuff that makes it so that enemies cant preform abilities.
    }
    public double SkillFour()
    {
        return 60;
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

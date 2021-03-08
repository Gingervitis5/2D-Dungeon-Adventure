using System;
using UnityEngine.UI;
using UnityEngine;

public class Wildlander : Ally
{
    public Sprite sprite;
    protected string skillOneType = "";
    protected string skillTwoType = "";
    protected string skillThreeType = "";
    protected string skillFourType = "";

    public void SkillOne()
    {

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

    public string GetSkillOneType() { return this.skillOneType; }
    public string GetSkillTwoType() { return this.skillTwoType; }
    public string GetSkillThreeType() { return this.skillThreeType; }
    public string GetSkillFourType() { return this.skillFourType; }

    public void SetSkillOneType(string s) { this.skillOneType = s; }
    public void SetSkillTwoType(string s) { this.skillTwoType = s; }
    public void SetSkillThreeType(string s) { this.skillThreeType = s; }
    public void SetSkillFourType(string s) { this.skillFourType = s; }

}

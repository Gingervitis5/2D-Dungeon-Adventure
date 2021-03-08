using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : Ally
{
    public Sprite sprite;
    protected string skillOneType = "Self";
    protected string skillTwo = "Double Tap";
    protected string skillTwoType = "Attack";
    protected string skillThreeType = "Self";
    protected string SkillFourType = "";

    public void SkillOne()
    {
        //In the future will need to create a menu in order to 
        //Apply status effect that boosts damage (25%)
        //Apply ststus effect that boosts aim (15%)
    }
    public double SkillTwo(Combatant c)//this is temperary, well need to be built better in the future.
    {
        if (skillTwo == "Double Tap")
        {
            return SkillTwoDoubleTap(c);
        }
        else
        {
            return 0;
        }
    }
    public double SkillTwoDoubleTap(Combatant c)
    {
        double damage;
        //Apply status effect to reduce damage for one turn (20%)
        //Apply status effect to reduce aim for one turn (10%)
        //Apply status effect to double RPA for one turn
        damage = this.Attack(c);
        return damage;
    }
    public void SkillThree()
    {
        //Apply status effect that boosts ShieldMax for 4 turns (50)
        this.shield = this.shield + 50;
        //Apply status effect that gives damage reduction for 4 turns (40%)
    }
}

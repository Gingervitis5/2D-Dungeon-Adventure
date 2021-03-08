using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLevelupFactory : MonoBehaviour
{
    public void LevelUpAchieved(Ally ally)
    {
        ally.SetLevel(ally.GetLevel()+1);

        if (ally.GetLevel() == 2)
        {
            ally.SetSkillTwoUnlocked(true);
        } 
        else if (ally.GetLevel() == 3)
        {
            ally.SetSkillThreeUnlocked(true);
        }
        else if (ally.GetLevel() == 4)
        {
            ally.SetSkillFourUnlocked(true);
        }

        HealthLevelUp(ally);
    }
    private void HealthLevelUp(Ally ally)
    {
        double increase;
        increase = (ally.GetBrawn() / 2) + 10;
    }
}

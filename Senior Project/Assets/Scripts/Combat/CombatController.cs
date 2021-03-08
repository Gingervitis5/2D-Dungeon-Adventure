using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CombatController
{
    Party mPlayerParty, mAIParty;
    Dictionary<Combatant, int> mOrder = new Dictionary<Combatant, int>(); //This is the turn order;
    int mExpGain = 0;
    bool mPlayerWin;

    public CombatController(Party p, Party a)
    {
        this.mPlayerParty = p;
        this.mAIParty = a;
    }

    public void Combat()
    {
        StartCombat();
        int state = 1;
        while (state == 1)
        {
            for(int i = 0; i < mOrder.Count; i++)
            {
                Combatant c = mOrder.ElementAt(i).Key;
                /* In here the code will run through
                 * the combat, connected to a combat menu,
                 * where attacks will be made and skills
                 * will be used.*/

                PurgeDead(); //Looks for dead characters and removes them from the turn order
                //Trigger for status effects.
                if (mAIParty.GetList().Count == 0)
                {
                    state--;
                    i = mOrder.Count;
                    mPlayerWin = true;
                }
                else if(mPlayerParty.GetList().Count == 0)
                {
                    state--;
                    i = mOrder.Count;
                    mPlayerWin = false;
                }
            }
        }
        if (mPlayerWin)
        {
            for (int i = 0; i < mAIParty.GetList().Count; i++)// This is to calculate EXP gain for the Player
            {
                //mExpGain = mExpGain + mAIParty.GetList()[i].GetE;
            }
            //Will make a call to deal with characters leveling up.
        }
        else if (!mPlayerWin)
        {
            //Trigger Defeat
        }
        else
        {
            //Incase of a situation where no one wins and no one loses, this is an error state.
        }

    }

    private void PurgeDead()
    {
        for(int i = 0; i < mPlayerParty.GetList().Count; i++)
        {
            if (mPlayerParty.GetList()[i].GetHealth() <= 0)
            {
                mOrder.Remove(mPlayerParty.GetList()[i]);
            }
        }
        for(int i=0; i < mAIParty.GetList().Count; i++)
        {
            if (mAIParty.GetList()[i].GetHealth() <= 0)
            {
                mOrder.Remove(mAIParty.GetList()[i]);
            }
        }
    }

    public void StartCombat()
    {
        List<Combatant> player = mPlayerParty.GetList();
        List<Combatant> ai = mAIParty.GetList();
        for(int i = 0; i < player.Count; i++) 
        {
            int time = CalculateInitiative(player[i]);
            mOrder.Add(player[i], time);
        }
        for(int i = 0; i <ai.Count; i++)
        {
            int time = CalculateInitiative(ai[i]);
            mOrder.Add(ai[i], time);
        }
        //Sorting turn order by highest value
        mOrder = (Dictionary<Combatant, int>)(from entry in mOrder orderby entry.Value ascending select entry);
    }
    public int CalculateInitiative(Combatant c) { return c.GetAgility() + c.GetWit(); }
}


using AssemblyCSharp.Assets.Scripts.Classes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMenu : MonoBehaviour
{
    Ally a;
    //Combatant c;
    CharacterFactory CF = new CharacterFactory();
    ItemFactory IF = new ItemFactory();
    PurchaseWeapon PW = new PurchaseWeapon();

    public Button mAttack;
    public Button mHunkerDown;
    public Button mInventory;
    public Button mInspect;
    public Button mSkillOne;
    public Button mSkillTwo;
    public Button mSkillThree;
    public Button mSkillFour;

    void Start()
    {
        /* This is a testing character;
         * this.a = CF.CreateNewSoldier(10, 10, 10, 10, 10, 10);
         * Weapon NewAR3117 = IF.CreateNewWeapon("AR-3117");
         * NewAR3117.SetStats(20, 10, 6, 5, 10, 35);
         * NewAR3117.SetWeaponType("Assault Rifle");
         * a.SetWeapon(NewAR3117);*/

    }
    void Update()
    {
        mAttack.onClick.AddListener(() => OnClickAttack());
        mHunkerDown.onClick.AddListener(() => OnClickHunkerDown());
        mInventory.onClick.AddListener(() => OnClickInventory());
        mInspect.onClick.AddListener(() => OnClickInspect());
        mSkillOne.onClick.AddListener(() => OnClickSkillOne());
        mSkillTwo.onClick.AddListener(() => OnClickSkillTwo());
        mSkillThree.onClick.AddListener(() => OnClickSkillThree());
        mSkillFour.onClick.AddListener(() => OnClickSkillFour());
    }
    public void OnClickAttack()
    {
        Combatant t = null;
        //Gets Responsive click/action that gets the attack target.
        a.Attack(t);
    }
    public void OnClickHunkerDown()
    {
        /*StatusEffect se = new StatusEffect();
         * Will need to decide on how the bunker down 
         * machanics will work. Will they be a complete 
         * damage reduction? Its own buff? or 
         * c.addStatusEffect;*/
    }
    public void OnClickInventory()
    {
        /* Opens up an Inventory, using a method  to do so.
         * If self target item the use on self
         * Otherwise calls SelectTarget();*/
    }
    public void OnClickInspect()
    {
        SelectTarget();
        /* Calls Select target
         * after you select the target 
         * display on a side menu.*/
    }
    public void OnClickSkillOne()
    {
        /*check if the skill targets
         * If so the call SelectTarget
         * then c.SkillOne(); */
        Combatant c;
        c = SelectTarget();
    }
    public void OnClickSkillTwo()
    {
        Combatant c;
        if (a.GetSkillTwoUnlocked())
        {
            c = SelectTarget();
        }
    }
    public void OnClickSkillThree()
    {
        Combatant c;
        if (a.GetSkillTwoUnlocked())
        {
            c = SelectTarget();
        }
    }
    public void OnClickSkillFour()
    {
        Combatant c;
        if (a.GetSkillTwoUnlocked())
        {
            c = SelectTarget();
        }
    }
    public Combatant SelectTarget()
    {
        return null;
        /*This method allows you to choose a target on the field*/
    }
}

using System;
using UnityEngine;
using Random = UnityEngine.Random;
public abstract class Combatant : ScriptableObject
{
    protected int health, healthMax, shield, shieldMax, initiative;
    protected int brawn, agility, luck, reason, wit, glamour;
    protected double aim, critChance, critMultiplier, dodge;
    protected Weapon weapon;
    public string characterName;
    public Sprite characterImage;
    public string charClass;

    public double Attack(Combatant c)
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
        return damage;
    }


    public int GetBrawn() { return this.brawn; }
    public int GetAgility() { return this.agility; }
    public int GetLuck() { return this.luck; }
    public int GetReason() { return this.reason; }
    public int GetWit() { return this.wit; }
    public int GetGlamour() { return this.glamour; }
    public Weapon GetWeapon() { return this.weapon; }
    public double GetCritChance() { return this.critChance; }
    public double GetCritMultiplier() { return this.critMultiplier; }
    public double GetDodge() { return this.dodge; }
    public string GetClass() { return this.charClass; }
    public string GetCharacterName() { return this.characterName; }

    public void SetBrawn(int brawn) { this.brawn = brawn; }
    public void SetAgility(int agility) { this.agility = agility; }
    public void SetLuck(int luck) { this.luck = luck; }
    public void SetReason(int reason) { this.reason = reason; }
    public void SetWit(int wit) { this.wit = wit; }
    public void SetGlamour(int glamour) { this.glamour = glamour; }
    public void SetWeapon(Weapon newWeapon) { this.weapon = newWeapon; }
    public void SetCritMultiplier(double c) { this.critMultiplier = c; }
    public void SetCritChance(double c) { this.critChance = c; }
    public void SetDodge(double d) { this.dodge = d; }
    public void SetClass(string charClass) { this.charClass = charClass; }
    public void SetCharacterName(string characterName) { this.characterName = characterName; }
}

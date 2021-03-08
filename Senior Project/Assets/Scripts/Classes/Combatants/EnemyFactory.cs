using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public EnemyFactory() { }

    public Legionaire CreateLegionaire()
    {
        Legionaire NewLegionaire = ScriptableObject.CreateInstance<Legionaire>();
        NewLegionaire.SetHealth(100);
        NewLegionaire.SetHealthMax(100);
        NewLegionaire.SetShield(20);
        NewLegionaire.SetShieldMax(20);
        NewLegionaire.SetAim(65);
        NewLegionaire.SetBrawn(16);
        NewLegionaire.SetAgility(12);
        NewLegionaire.SetLuck(10);
        NewLegionaire.SetReason(8);
        NewLegionaire.SetWit(12);
        NewLegionaire.SetGlamour(10);
        NewLegionaire.characterName = "Legionaire"; //Imperial Legionaire might be a good name
        return NewLegionaire;
    }
    public Warmonger CreateWarmonger()
    {
        Warmonger NewWarmonger = ScriptableObject.CreateInstance<Warmonger>();
        NewWarmonger.SetHealth(100);
        NewWarmonger.SetHealthMax(100);
        NewWarmonger.SetShield(40);
        NewWarmonger.SetShieldMax(40);
        NewWarmonger.SetAim(70);
        NewWarmonger.SetBrawn(17);
        NewWarmonger.SetAgility(13);
        NewWarmonger.SetLuck(10);
        NewWarmonger.SetReason(8);
        NewWarmonger.SetWit(12);
        NewWarmonger.SetGlamour(10);
        NewWarmonger.characterName = "Warmonger"; 
        return NewWarmonger;
    }

}

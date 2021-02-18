
using System;
using UnityEngine;


namespace AssemblyCSharp.Assets.Scripts.Classes
{
    public class CharacterFactory
    {
        public CharacterFactory() { }

        public Wildlander CreateNewWildlander(int brawn, int agility, int luck, int reason, int wit, int glamour)
        {
            Wildlander NewWildlander = ScriptableObject.CreateInstance<Wildlander>();
            NewWildlander.SetBrawn(brawn);
            NewWildlander.SetAgility(agility);
            NewWildlander.SetLuck(luck);
            NewWildlander.SetReason(reason);
            NewWildlander.SetWit(wit);
            NewWildlander.SetGlamour(glamour);
            NewWildlander.characterName = "Wildlander";
            return NewWildlander;
        }

        public Technician CreateNewTechnician(int brawn, int agility, int luck, int reason, int wit, int glamour)
        {
            Technician NewTechnician = ScriptableObject.CreateInstance<Technician>();
            NewTechnician.SetBrawn(brawn);
            NewTechnician.SetAgility(agility);
            NewTechnician.SetLuck(luck);
            NewTechnician.SetReason(reason);
            NewTechnician.SetWit(wit);
            NewTechnician.SetGlamour(glamour);
            NewTechnician.characterName = "Technician";
            return NewTechnician;
        }

        public Scholar CreateNewScholar(int brawn, int agility, int luck, int reason, int wit, int glamour)
        {
            Scholar NewScholar = ScriptableObject.CreateInstance<Scholar>();
            NewScholar.SetBrawn(brawn);
            NewScholar.SetAgility(agility);
            NewScholar.SetLuck(luck);
            NewScholar.SetReason(reason);
            NewScholar.SetWit(wit);
            NewScholar.SetGlamour(glamour);
            NewScholar.characterName = "Scholar";
            return NewScholar;
        }

        public Psionic CreateNewPsionic(int brawn, int agility, int luck, int reason, int wit, int glamour)
        {
            Psionic NewScholar = ScriptableObject.CreateInstance<Psionic>();
            NewScholar.SetBrawn(brawn);
            NewScholar.SetAgility(agility);
            NewScholar.SetLuck(luck);
            NewScholar.SetReason(reason);
            NewScholar.SetWit(wit);
            NewScholar.SetGlamour(glamour);
            NewScholar.characterName = "Psionic";
            return NewScholar;
        }
        public Soldier CreateNewSoldier(int brawn, int agility, int luck, int reason, int wit, int glamour)
        {
            Soldier newSoldier = ScriptableObject.CreateInstance<Soldier>();
            newSoldier.SetBrawn(brawn);
            newSoldier.SetAgility(agility);
            newSoldier.SetLuck(luck);
            newSoldier.SetReason(reason);
            newSoldier.SetWit(wit);
            newSoldier.SetGlamour(glamour);
            newSoldier.characterName = "Soldier";
            return newSoldier;
        }
        public Operative CreateNewOperative(int brawn, int agility, int luck, int reason, int wit, int glamour)
        {
            Operative newOperative = ScriptableObject.CreateInstance<Operative>();
            newOperative.SetBrawn(brawn);
            newOperative.SetAgility(agility);
            newOperative.SetLuck(luck);
            newOperative.SetReason(reason);
            newOperative.SetWit(wit);
            newOperative.SetGlamour(glamour);
            newOperative.characterName = "Operative";
            return newOperative;
        }
        public Delegate CreateNewDelegate(int brawn, int agility, int luck, int reason, int wit, int glamour)
        {
            Delegate newDelegate = ScriptableObject.CreateInstance<Delegate>();
            newDelegate.SetBrawn(brawn);
            newDelegate.SetAgility(agility);
            newDelegate.SetLuck(luck);
            newDelegate.SetReason(reason);
            newDelegate.SetWit(wit);
            newDelegate.SetGlamour(glamour);
            newDelegate.characterName = "Delegate";
            return newDelegate;
        }
    }
}

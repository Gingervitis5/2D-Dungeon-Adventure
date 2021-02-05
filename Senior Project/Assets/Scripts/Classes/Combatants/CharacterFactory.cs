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
            NewWildlander.CharacterName = "Wildlander";
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
            NewTechnician.CharacterName = "Technician";
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
            NewScholar.CharacterName = "Scholar";
            return NewScholar;
        }
    }
}

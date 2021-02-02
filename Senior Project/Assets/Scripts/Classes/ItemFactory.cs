using System;
using UnityEngine;
namespace AssemblyCSharp.Assets.Scripts.Classes
{
    public class ItemFactory    //Implement Factory method for Item creation
    {

        public ItemFactory(){}

        public Consumable CreateNewConsumable(string name)
        {
            Consumable NewConsumable = ScriptableObject.CreateInstance<Consumable>();
            NewConsumable.SetItemName(name);
            return NewConsumable;
        }

        public Weapon CreateNewWeapon(string name)
        {
            Weapon NewWeapon = ScriptableObject.CreateInstance<Weapon>();
            NewWeapon.SetItemName(name);
            return NewWeapon;
        }
    }
}

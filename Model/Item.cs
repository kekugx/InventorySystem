using System;
using Assets.InventorySystem.Interfaces;
using Assets.InventorySystem.Utility;
using UnityEngine;

namespace Assets.InventorySystem.Model
{
    [Serializable]
    public class Item : IItem
    {
        public int id = 0;
        public int Id => id;

        public string name = "";
        public string Name => name;

        public string description;
        public string Description => description;

        public ItemRarity rarity = ItemRarity.Common;
        public ItemRarity Rarity => rarity;

        public Sprite icon;
        public Sprite Icon => icon;
    }
}

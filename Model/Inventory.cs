using Assets.InventorySystem.Interfaces;
using System;
using UnityEngine;

namespace Assets.InventorySystem.Model
{
    [Serializable]
    public class Inventory :  IInvertory
    {
        public Slot[] slots;
        public Slot[] Slots { get { return slots; } set { slots = value; } }

    }
}

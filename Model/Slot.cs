using Assets.InventorySystem.Interfaces;
using Assets.InventorySystem.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.InventorySystem.Model
{
    [Serializable]
    public class Slot : ISlot
    {
        public Item item;
        public Item Item { get => item; set => item = value; }

        public SlotType slotType;
        public SlotType SlotType { get => slotType; set => slotType = value; }

        public bool stackable;
        public bool Stackable { get => stackable; set => stackable = value; }

        public GameObject target;
        public GameObject Target => target;
    }
}

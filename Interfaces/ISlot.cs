using System;
using UnityEngine;
namespace Assets.InventorySystem.Interfaces
{
    using Assets.InventorySystem.Model;
    using Assets.InventorySystem.Utility;

    public interface ISlot 
    {
        Item Item { get; set; }
        SlotType SlotType { get; set; }
        bool Stackable { get; set; }
        GameObject Target { get; }
    }
}

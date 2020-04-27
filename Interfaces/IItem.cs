
using Assets.InventorySystem.Utility;
using UnityEngine;

namespace Assets.InventorySystem.Interfaces
{
    public interface IItem
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
        ItemRarity Rarity { get; }
        Sprite Icon { get; }
    }
}

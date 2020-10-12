using System;
using UnityEngine;

public enum Rarity { Common, Rare, Epic, Legendary }
public enum Slot { Hands, Head, Legs, Boots, Ring, Neck, MainHand, OffHand }

[Serializable]
public class Equipment
{
    public string name;
    public int attack;
    public int defence;
    public Rarity rarity;
    public Slot slot;
}
public class Inventory : MonoBehaviour
{
    public Equipment AddEquipment;
    public int ItemSlot;
    public Equipment[] CurrentEquipment;
    

    public void AddEquipementFunction()
    {
        CurrentEquipment[ItemSlot].name = AddEquipment.name;
        CurrentEquipment[ItemSlot].attack = AddEquipment.attack;
        CurrentEquipment[ItemSlot].defence = AddEquipment.defence;
        CurrentEquipment[ItemSlot].rarity = AddEquipment.rarity;
        CurrentEquipment[ItemSlot].slot = AddEquipment.slot;
    }
}

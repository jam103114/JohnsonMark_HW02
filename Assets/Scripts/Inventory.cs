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
    //public int ItemSlot;
    public Equipment[] CurrentEquipment;
    

    public void AddEquipementFunction(int ItemSlot)
    {
        if (CurrentEquipment.Length < ItemSlot)
        {
            CurrentEquipment = new Equipment[ItemSlot +1];
        }
        AddEquipmentFunTwo(ItemSlot);

        Debug.Log("Called");
    }

    public void DropEquipmentFunction(int ItemSlot)
    {
        if (CurrentEquipment.Length < ItemSlot)
        {
            Debug.Log("Item Slot doesn't exist");
            return;
        }
        else 
        {
            CurrentEquipment = new Equipment[ItemSlot];
        }
    }

    public void AddEquipmentFunTwo(int IS)
    {
        CurrentEquipment[IS].name = AddEquipment.name;
        CurrentEquipment[IS].attack = AddEquipment.attack;
        CurrentEquipment[IS].defence = AddEquipment.defence;
        CurrentEquipment[IS].rarity = AddEquipment.rarity;
        CurrentEquipment[IS].slot = AddEquipment.slot;
    }
}

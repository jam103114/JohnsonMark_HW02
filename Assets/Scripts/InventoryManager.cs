using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int ItemSlot;


    public void AddItemFun()
    {
        Inventory inv = gameObject.GetComponent<Inventory>();
        inv.AddEquipementFunction(ItemSlot);
    }

    public void ItemDrop()
    {
        Inventory inv = gameObject.GetComponent<Inventory>();
        inv.DropEquipmentFunction(ItemSlot);
    }
}

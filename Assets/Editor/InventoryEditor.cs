using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Inventory))]
public class InventoryEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Inventory inventory = (Inventory)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Add Item"))
        {
            Debug.Log(inventory.AddEquipment.name + "was added");

        }

        base.OnInspectorGUI();
    }
}

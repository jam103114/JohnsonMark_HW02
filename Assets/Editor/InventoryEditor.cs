using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(InventoryManager))]
public class InventoryEditor : Editor
{
    
    public override void OnInspectorGUI()
    {
        InventoryManager invMan = (InventoryManager)target;
        base.OnInspectorGUI();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Add Item"))
        {
            //Debug.Log(inventory.name + "was added");
            invMan.AddItemFun();
        }

        if (GUILayout.Button("Resize Bags"))
        {
            //Debug.Log(inventory.name + "was added");
            invMan.ItemDrop();
        }

        GUILayout.EndHorizontal();

        
     }


}

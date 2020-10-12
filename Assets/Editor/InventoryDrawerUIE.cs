using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEngine;


[CustomPropertyDrawer(typeof(Inventory))]
public class InventoryDrawerUIE : PropertyDrawer
{
    public override VisualElement CreatePropertyGUI(SerializedProperty property)
    {
        GUILayout.BeginHorizontal();
        var container = new VisualElement();

        var nameField = new PropertyField(property.FindPropertyRelative("name"), "Some Name");
        var attackField = new PropertyField(property.FindPropertyRelative("attack"));
        var defenceField = new PropertyField(property.FindPropertyRelative("defence"));
        var rarityField = new PropertyField(property.FindPropertyRelative("rarity"));
        var slotField = new PropertyField(property.FindPropertyRelative("slot"));

        container.Add(nameField);
        container.Add(attackField);
        container.Add(defenceField);
        container.Add(rarityField);
        container.Add(slotField);
        GUILayout.EndHorizontal();
        return container;

        // return base.CreatePropertyGUI(property);
    }
}
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Cube cube = (Cube)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Generate Color"))
        {
            Debug.Log("Gen color");
            cube.GenerateColor();
        }

        if (GUILayout.Button("Reset"))
        {
            Debug.Log("rest");
            cube.Reset();
        }

        GUILayout.EndHorizontal();
    }
}

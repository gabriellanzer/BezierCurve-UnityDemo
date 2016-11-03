using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(control))]
[ExecuteInEditMode]
public class ConeCreator : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        control myScript = (control)target;
        if (GUILayout.Button("Add Point"))
        {
            myScript.AddPoint();
        }

        if (GUILayout.Button("Clear"))
        {
            myScript.ClearPoints();
        }

        if (GUILayout.Button("Update Line Renderer"))
        {
            myScript.UpdateLineRender();
        }
    }
}
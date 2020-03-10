using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Node))]
public class NodeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Node skillMap = (Node)target;

        if (GUILayout.Button("Generate New Skill Map"))
        {
            // Create new node
            // Hook up the connection
        }
    }
}

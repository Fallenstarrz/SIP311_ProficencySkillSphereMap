using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Node))]
public class NodeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Node skillMap = (Node)target;

        if (GUILayout.Button("Create New Connection and Node"))
        {
            // Create new node
            // Hook up the connection
        }

        if (GUILayout.Button("Create Connection To Existing Node"))
        {

        }
    }
}
